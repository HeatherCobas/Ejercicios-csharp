CREATE DATABASE DBLogin;
USE DBLogin;

CREATE TABLE Usuarios (
    Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_Usuario VARCHAR(50) NOT NULL UNIQUE,
    Contraseña VARCHAR(255) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Fecha_Registro DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1,
    Recordar BIT DEFAULT 0,
    RutaFotoPerfil NVARCHAR(500)
);


CREATE TABLE Roles (
    Id_Rol INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE UsuarioRoles (
    Id_UsuarioRol INT IDENTITY(1,1) PRIMARY KEY,
    Id_Usuario INT,
    Id_Rol INT,
    FOREIGN KEY (Id_Usuario) REFERENCES Usuarios(Id_Usuario),
    FOREIGN KEY (Id_Rol) REFERENCES Roles(Id_Rol)
);

CREATE TABLE Mensajes (
    IdMensaje INT PRIMARY KEY IDENTITY,
    IdUsuario INT,
    Asunto VARCHAR(100),
    Contenido NVARCHAR(MAX),
    FechaEnvio DATETIME DEFAULT GETDATE(),
    Respuesta NVARCHAR(MAX),
    FechaRespuesta DATETIME,
    Contestado BIT DEFAULT 0,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id_Usuario)
);


CREATE PROCEDURE SP_RegistrarUsuario
    @Nombre_Usuario VARCHAR(50),
    @Contraseña VARCHAR(255),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Email VARCHAR(150)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario)
    BEGIN
        RAISERROR('El nombre de usuario ya existe.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Usuarios WHERE Email = @Email)
    BEGIN
        RAISERROR('El correo electrónico ya está registrado.', 16, 1);
        RETURN;
    END

    INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Nombre, Apellido, Email)
    VALUES (@Nombre_Usuario, @Contraseña, @Nombre, @Apellido, @Email);
END


CREATE PROCEDURE  SP_IniciarSesion
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id_Usuario, Nombre_Usuario, Nombre, Apellido, Email, RutaFotoPerfil
    FROM Usuarios
    WHERE Nombre_Usuario COLLATE Latin1_General_CI_AS = @NombreUsuario
      AND Contraseña COLLATE Latin1_General_CI_AS = @Contraseña;
END



CREATE PROCEDURE SP_RecordarUsuario
    @IdUsuario INT,
    @Recordar BIT
AS
BEGIN

    UPDATE Usuarios SET Recordar = 0
    IF @Recordar = 1
    BEGIN
        UPDATE Usuarios SET Recordar = 1 WHERE Id_Usuario = @IdUsuario
    END
END


CREATE PROCEDURE SP_ObtenerUsuarioRecordado
AS
BEGIN
    SELECT TOP 1 * FROM Usuarios WHERE Recordar = 1
END

CREATE PROCEDURE SP_ValidarUsuario
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    DECLARE @ContrasenaEncriptada VARCHAR(255)
    SET @ContrasenaEncriptada = CONVERT(VARCHAR(255), HASHBYTES('SHA2_256', @Contraseña), 2)
    
    SELECT 
        Id_Usuario,
        Nombre_Usuario,
        Nombre,
        Apellido,
        Email
    FROM 
        Usuarios
    WHERE 
        Nombre_Usuario = @NombreUsuario 
        AND Contraseña = @ContrasenaEncriptada
        AND Activo = 1
END


CREATE PROCEDURE SP_ObtenerRolesPorUsuario
    @IdUsuario INT
AS
BEGIN
    SELECT R.NombreRol
    FROM Roles R
    INNER JOIN UsuarioRoles UR ON R.Id_Rol = UR.Id_Rol
    WHERE UR.Id_Usuario = @IdUsuario;
END


CREATE PROCEDURE SP_InsertarUsuario
    @Nombre_Usuario NVARCHAR(50),
    @Contraseña NVARCHAR(255),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @Activo BIT,
    @RutaFotoPerfil NVARCHAR(255)
AS
BEGIN
    BEGIN TRY

        INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Nombre, Apellido, Email, Activo, RutaFotoPerfil)
        VALUES (@Nombre_Usuario, @Contraseña, @Nombre, @Apellido, @Email, @Activo, @RutaFotoPerfil)


        SELECT 1 AS Resultado, 'Usuario registrado correctamente' AS Mensaje
    END TRY
    BEGIN CATCH

        IF ERROR_NUMBER() = 2627 OR ERROR_NUMBER() = 2601
        BEGIN
            SELECT 0 AS Resultado, 'El correo o nombre de usuario ya está registrado' AS Mensaje
        END
        ELSE
        BEGIN
            SELECT 0 AS Resultado, 'Error al registrar el usuario' AS Mensaje
        END
    END CATCH
END



CREATE PROCEDURE SP_ActualizarUsuario
    @Id_Usuario INT,
    @Nombre_Usuario VARCHAR(50),
    @Contraseña VARCHAR(255),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Email VARCHAR(150),
    @Activo BIT,
    @RutaFotoPerfil NVARCHAR(500)
AS
BEGIN
    UPDATE Usuarios
    SET Nombre_Usuario = @Nombre_Usuario,
        Contraseña = @Contraseña,
        Nombre = @Nombre,
        Apellido = @Apellido,
        Email = @Email,
        Activo = @Activo,
        RutaFotoPerfil = @RutaFotoPerfil
    WHERE Id_Usuario = @Id_Usuario
END


CREATE PROCEDURE SP_EliminarUsuario
    @IdUsuario INT
AS
BEGIN
    UPDATE Usuarios
    SET Activo = 0
    WHERE Id_Usuario = @IdUsuario;
END



CREATE PROCEDURE SP_BuscarUsuarios
    @Filtro NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Usuarios
    WHERE 
        Nombre_Usuario LIKE '%' + @Filtro + '%' OR
        Nombre LIKE '%' + @Filtro + '%' OR
        Apellido LIKE '%' + @Filtro + '%' OR
        Email LIKE '%' + @Filtro + '%'
END


CREATE PROCEDURE SP_ObtenerUsuarios
AS
BEGIN
    SELECT 
        u.Id_Usuario, 
        u.Nombre_Usuario, 
        u.Nombre, 
        u.Apellido, 
        u.Email, 
        u.Activo, 
        u.RutaFotoPerfil,
        r.NombreRol
    FROM Usuarios u
    INNER JOIN UsuarioRoles ur ON u.Id_Usuario = ur.Id_Usuario
    INNER JOIN Roles r ON ur.Id_Rol = r.Id_Rol;
END


CREATE PROCEDURE SP_EditarUsuario
    @IdUsuario INT,
    @NombreUsuario NVARCHAR(50),
    @Contraseña NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @RutaFotoPerfil NVARCHAR(250),
    @Activo BIT,
    @IdRol INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Usuarios
    SET Nombre_Usuario = @NombreUsuario,
        Contraseña = @Contraseña,
        Nombre = @Nombre,
        Apellido = @Apellido,
        Email = @Email,
        RutaFotoPerfil = @RutaFotoPerfil,
        Activo = @Activo
    WHERE Id_Usuario = @IdUsuario;

    IF EXISTS (SELECT 1 FROM UsuarioRoles WHERE Id_Usuario = @IdUsuario)
    BEGIN
        UPDATE UsuarioRoles
        SET Id_Rol = @IdRol
        WHERE Id_Usuario = @IdUsuario;
    END
    ELSE
    BEGIN
        INSERT INTO UsuarioRoles (Id_Usuario, Id_Rol)
        VALUES (@IdUsuario, @IdRol);
    END
END




CREATE PROCEDURE ObtenerRoles
AS
BEGIN
    SELECT Id_Rol, NombreRol FROM Roles
END



CREATE PROCEDURE ObtenerRolPorUsuario
    @IdUsuario INT
AS
BEGIN
    SELECT r.Id_Rol, r.NombreRol
    FROM Roles r
    INNER JOIN UsuarioRoles ur ON ur.Id_Rol = r.Id_Rol
    INNER JOIN Usuarios u ON u.Id_Usuario = ur.Id_Usuario
    WHERE u.Id_Usuario = @IdUsuario;
END



CREATE PROCEDURE SP_EnviarMensajePorNombreUsuario
    @NombreUsuario VARCHAR(50),
    @Asunto NVARCHAR(100),
    @Contenido NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @IdUsuario INT
    
    SELECT @IdUsuario = Id_Usuario FROM Usuarios 
    WHERE Nombre_Usuario = @NombreUsuario
    
    IF @IdUsuario IS NOT NULL
    BEGIN
        INSERT INTO Mensajes (IdUsuario, Asunto, Contenido, FechaEnvio)
        VALUES (@IdUsuario, @Asunto, @Contenido, GETDATE());
        
        RETURN 1 
    END
    ELSE
    BEGIN
        RAISERROR('El nombre de usuario no existe en el sistema', 16, 1);
        RETURN 0 -- Falla
    END
END


CREATE PROCEDURE SP_ObtenerMensajesUsuario
    @IdUsuario INT
AS
BEGIN
    SELECT 
        m.IdMensaje,
        m.Asunto,
        m.Contenido,
        m.FechaEnvio,
        m.Contestado,
        m.Respuesta,
        m.FechaRespuesta
    FROM Mensajes m
    WHERE m.IdUsuario = @IdUsuario
    ORDER BY m.FechaEnvio DESC
END

SELECT * FROM Usuarios WHERE Id_Usuario = 1;



CREATE PROCEDURE SP_ObtenerTodosMensajes
AS
BEGIN
    SELECT m.IdMensaje, u.Nombre_Usuario, m.Asunto, m.Contenido, m.FechaEnvio, 
           m.Contestado, m.Respuesta, m.FechaRespuesta
    FROM Mensajes m
    INNER JOIN Usuarios u ON m.IdUsuario = u.Id_Usuario
    ORDER BY m.FechaEnvio DESC
END


CREATE PROCEDURE SP_ResponderMensaje
    @IdMensaje INT,
    @Respuesta NVARCHAR(MAX)
AS
BEGIN
    UPDATE Mensajes
    SET Respuesta = @Respuesta,
        FechaRespuesta = GETDATE(),
        Contestado = 1
    WHERE IdMensaje = @IdMensaje
END


CREATE PROCEDURE SP_ObtenerUsuarioPorId
    @IdUsuario INT
AS
BEGIN
    SELECT 
        Id_Usuario,
        Nombre_Usuario,
        Nombre,
        Apellido,
        Email,
        Activo,
        Recordar,
        RutaFotoPerfil
    FROM Usuarios
    WHERE Id_Usuario = @IdUsuario
END


INSERT INTO Mensajes (IdUsuario, Asunto, Contenido, FechaEnvio)
VALUES (1, 'Asunto del mensaje', 'Este es el contenido del mensaje.', GETDATE());

INSERT INTO Roles (NombreRol) VALUES ('Administrador'), ('Usuario'), ('Soporte');


INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Nombre, Apellido, Email)
VALUES ('admin_Pita', 1234, 'Admin', 'Principal', 'admin@correo.com');

UPDATE Usuarios
SET Contraseña = '1234'
WHERE Id_Usuario = 1;



CREATE PROCEDURE SP_EnviarMensaje
    @NombreUsuario NVARCHAR(50),
    @Asunto NVARCHAR(100),
    @Contenido NVARCHAR(MAX)
AS
BEGIN
    DECLARE @IdUsuario INT

    SELECT @IdUsuario = Id_Usuario
    FROM Usuarios
    WHERE Nombre_Usuario = @NombreUsuario

    IF @IdUsuario IS NULL
    BEGIN
        RAISERROR('El usuario con ese nombre no existe.', 16, 1)
        RETURN
    END

    INSERT INTO Mensajes (IdUsuario, Asunto, Contenido, FechaEnvio)
    VALUES (@IdUsuario, @Asunto, @Contenido, GETDATE())
END

CREATE PROCEDURE SP_ResponderMensaje
    @IdMensaje INT,
    @Respuesta NVARCHAR(MAX),
    @Contestado BIT
AS
BEGIN
    UPDATE Mensajes
    SET Respuesta = @Respuesta, Contestado = @Contestado, FechaRespuesta = GETDATE()
    WHERE IdMensaje = @IdMensaje
END


CREATE PROCEDURE SP_ObtenerTodosLosMensajes
AS
BEGIN
    SELECT 
        m.IdMensaje, 
        u.Nombre_Usuario AS NombreUsuario,
        m.Asunto, 
        m.Contenido,
        m.FechaEnvio, 
        m.Respuesta, 
        m.FechaRespuesta,
        m.contestado
    FROM Mensajes m
    INNER JOIN Usuarios u ON m.IdUsuario = u.Id_Usuario
    ORDER BY m.FechaEnvio DESC
END

CREATE PROCEDURE SP_ObtenerMensajesPendientes
AS
BEGIN
    SELECT m.IdMensaje, u.Nombre_Usuario, m.Asunto, m.Contenido, m.Respuesta, m.FechaEnvio, m.Contestado
    FROM Mensajes m
    JOIN Usuarios u ON m.IdUsuario = u.Id_Usuario
    WHERE m.Contestado = 0
    ORDER BY m.FechaEnvio DESC
END

CREATE PROCEDURE SP_ObtenerRespuestasPorUsuario
    @IdUsuario INT
AS
BEGIN
    SELECT 
        m.IdMensaje,
        m.Asunto,
        m.Contenido,
        m.Respuesta,
        m.FechaRespuesta
    FROM Mensajes m
    WHERE m.IdUsuario = @IdUsuario AND m.Contestado = 1
    ORDER BY m.FechaRespuesta DESC
END

CREATE PROCEDURE sp_GuardarUsuario
    @NombreUsuario NVARCHAR(50),
    @Contraseña NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @Activo BIT,
    @RutaFotoPerfil NVARCHAR(250),
    @IdRol INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Usuarios WHERE Email = @Email)
    BEGIN
        RAISERROR('El correo electrónico ya está registrado.', 16, 1);
        RETURN;
    END

    INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Nombre, Apellido, Email, Activo, RutaFotoPerfil)
    VALUES (@NombreUsuario, @Contraseña, @Nombre, @Apellido, @Email, @Activo, @RutaFotoPerfil);

    DECLARE @IdUsuario INT = SCOPE_IDENTITY();

    INSERT INTO UsuarioRoles (Id_Usuario, Id_Rol)
    VALUES (@IdUsuario, @IdRol);
END

UPDATE Usuarios
SET Contraseña = CONVERT(VARCHAR(100), HASHBYTES('SHA2_256', '12'), 2)
WHERE Id_Usuario = 15;


SELECT * FROM Usuarios WHERE Id_Usuario = 3

UPDATE Usuarios
SET Contraseña = CONVERT(VARCHAR(100), HASHBYTES('SHA2_256', '12'), 2)
WHERE Id_Usuario = 15;

INSERT INTO UsuarioRoles (Id_Usuario, Id_Rol)
VALUES (2, 2); 


Select * From Usuarios
Select * From Roles
Select * From UsuarioRoles
Select * From Mensajes

SELECT Contraseña FROM Usuarios WHERE Id_Usuario = 3;


DELETE FROM Usuarios
WHERE ID_Usuario = 9;

DELETE FROM Mensajes
WHERE IdUsuario = 9;

DELETE FROM UsuarioRoles
WHERE Id_Usuario = 9;

DELETE FROM Usuarios
WHERE ID_Usuario = 2;

