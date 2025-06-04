CREATE DATABASE DBSistemaLogin;
USE DBSistemaLogin;

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


CREATE TABLE HistorialLogin (
    Id_Login INT IDENTITY(1,1) PRIMARY KEY,
    Id_Usuario INT,
    FechaLogin DATETIME DEFAULT GETDATE(),
    IP_Acceso VARCHAR(50),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Mensajes (
    IdMensaje INT PRIMARY KEY IDENTITY,
    IdUsuario INT,
    Asunto VARCHAR(100),
    Contenido NVARCHAR(MAX),
    FechaEnvio DATETIME DEFAULT GETDATE(),
    Respuesta NVARCHAR(MAX),
    FechaRespuesta DATETIME,
    Respondido BIT DEFAULT 0,
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


CREATE PROCEDURE SP_IniciarSesion
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(255)
AS
BEGIN
    SELECT Id_Usuario, Nombre_Usuario, Nombre, Apellido, Email, RutaFotoPerfil
    FROM Usuarios
    WHERE Nombre_Usuario COLLATE Latin1_General_CS_AS = @NombreUsuario
      AND Contraseña COLLATE Latin1_General_CS_AS = @Contraseña;
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


CREATE PROCEDURE SP_RegistrarHistorialLogin
    @IdUsuario INT,
    @IPAcceso VARCHAR(50)
AS
BEGIN
    INSERT INTO HistorialLogin (Id_Usuario, IP_Acceso)
    VALUES (@IdUsuario, @IPAcceso);
END


CREATE PROCEDURE SP_InsertarUsuario
    @Nombre_Usuario VARCHAR(50),
    @Contraseña VARCHAR(255),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Email VARCHAR(150),
    @Activo BIT,
    @RutaFotoPerfil NVARCHAR(500)
AS
BEGIN
    INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Nombre, Apellido, Email, Activo, RutaFotoPerfil)
    VALUES (@Nombre_Usuario, @Contraseña, @Nombre, @Apellido, @Email, @Activo, @RutaFotoPerfil)
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
    DELETE FROM Usuarios
    WHERE Id_Usuario = @IdUsuario
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
    SELECT * FROM Usuarios
END


CREATE PROCEDURE SP_EditarUsuario
    @IdUsuario INT,
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(255),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Email VARCHAR(150),
    @RutaFotoPerfil NVARCHAR(500),
    @Activo BIT
AS
BEGIN
    UPDATE Usuarios
    SET Nombre_Usuario = @NombreUsuario,
        Contraseña = @Contraseña,
        Nombre = @Nombre,
        Apellido = @Apellido,
        Email = @Email,
        RutaFotoPerfil = @RutaFotoPerfil,
        Activo = @Activo
    WHERE Id_Usuario = @IdUsuario
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
        m.Respondido,
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
           m.Respondido, m.Respuesta, m.FechaRespuesta
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
        Respondido = 1
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


INSERT INTO UsuarioRoles (Id_Usuario, Id_Rol)
VALUES (1, 1); 

Select * From Usuarios

UPDATE Usuarios
SET Contraseña = '1234'
WHERE Id_Usuario = 1;


