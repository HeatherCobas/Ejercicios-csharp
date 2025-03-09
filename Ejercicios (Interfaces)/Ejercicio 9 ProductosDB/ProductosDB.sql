CREATE DATABASE ProductoDB
USE ProductoDB


CREATE TABLE Categoria (
    Id_cat INT PRIMARY KEY IDENTITY(1,1),
    Nombre_cat VARCHAR(100) NOT NULL,
    Activo BIT DEFAULT 1
);


CREATE TABLE Medidas (
    Id_Medida INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Me VARCHAR(50) NOT NULL,
	Descripción NVARCHAR(255) NULL,
    Activo BIT DEFAULT 1
);


CREATE TABLE Producto (
    Id_Prod INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Prod VARCHAR(250) NOT NULL,  
    Descripcion VARCHAR(100) NOT NULL,
    Marca VARCHAR(100) NOT NULL,
    Id_Medida INT FOREIGN KEY REFERENCES Medidas(Id_Medida),
    Id_cat INT FOREIGN KEY REFERENCES Categoria(Id_cat),
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL,
    Activo BIT DEFAULT 1
);


CREATE PROCEDURE sp_EliminarProducto
    @Id_Prod INT
AS
BEGIN

    UPDATE Producto
    SET Activo = 0
    WHERE Id_Prod = @Id_Prod;
END;


CREATE PROCEDURE sp_Guardar_pr
    @id_prod INT = NULL,
    @Nombre_Prod NVARCHAR(100),
    @Marca NVARCHAR(100),
    @Id_Medida INT,
    @Stock INT,
    @Precio DECIMAL(18, 2),
    @Id_cat INT,
    @Descripcion NVARCHAR(255),
    @opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        INSERT INTO Producto (Nombre_Prod, Marca, Id_Medida, Stock, Precio, Id_cat, Descripcion, Activo)
        VALUES (@Nombre_Prod, @Marca, @Id_Medida, @Stock, @Precio, @Id_cat, @Descripcion, 1);
    END
    ELSE 
    BEGIN
        IF @opcion = 2
        BEGIN
            UPDATE Producto 
            SET Nombre_Prod = @Nombre_Prod,
                Marca = @Marca,
                Id_Medida = @Id_Medida,
                Stock = @Stock,
                Precio = @Precio,
                Id_cat = @Id_cat,
                Descripcion = @Descripcion
            WHERE Id_Prod = @id_prod;
        END
	END
END;

CREATE PROCEDURE sp_Listar_pr
    @valor VARCHAR(50)
AS
BEGIN
    SELECT 
        p.Id_Prod,
        p.Nombre_Prod,
        p.Descripcion,
        p.Marca,
        p.Id_Medida,
        m.Nombre_Me,
        p.Stock,
        p.Precio,
        p.Id_cat,
        c.Nombre_cat
    FROM Producto p
    INNER JOIN Categoria c ON p.Id_cat = c.Id_cat
    INNER JOIN Medidas m ON p.Id_Medida = m.Id_Medida
    WHERE p.Activo = 1 AND p.Nombre_Prod LIKE '%' + @valor + '%'
    ORDER BY p.Id_Prod;
END;




CREATE PROCEDURE sp_Listar_Categorias
AS
BEGIN
    SELECT Id_cat, Nombre_cat
    FROM Categoria
    WHERE Activo = 1;
END;


INSERT INTO Categoria (Nombre_cat)
VALUES
    ('Frutas frescas'), ('Verduras frescas'), ('Hierbas y especias frescas'), ('Carne de res'),
    ('Carne de cerdo'), ('Pollo'), ('Pescados y mariscos'), ('Embutidos'), ('Leche'), ('Yogur'),
    ('Quesos'), ('Mantequilla'), ('Pan'), ('Pasteles y galletas'), ('Bollería'),
    ('Panes especiales'), ('Agua'), ('Jugos'), ('Refrescos'), ('Bebidas alcohólicas'),
    ('Café y té'), ('Verduras congeladas'), ('Carnes y pescados congelados'),
    ('Comidas preparadas congeladas'), ('Arroz'), ('Pasta'), ('Frijoles'), ('Lentejas'),
    ('Snacks y Golosinas'), ('Papas fritas'), ('Galletas'), ('Chocolates'),
    ('Dulces y caramelos'), ('Jabón y gel de ducha'), ('Pasta de dientes'), ('Desodorantes'),
    ('Papel higiénico'), ('Detergentes'), ('Limpiadores'), ('Desinfectantes'), ('Bolsas de basura'),
    ('Salsas'), ('Atún'), ('Verduras en conserva'), ('Sopas y caldos'),
    ('Productos de Salud y Bienestar'), ('Vitaminas'), ('Suplementos alimenticios'),
    ('Medicamentos sin receta'), ('Alimentos para perros y gatos'), ('Juguetes y accesorios'),
    ('Utensilios de cocina'), ('Platos y vasos'), ('Toallas y sábanas');


INSERT INTO Medidas (Nombre_Me, Descripción) 
VALUES 
('Unidad', 'Producto por unidad'),
('Litro', 'Producto en litros'),
('Mililitro', 'Producto en mililitros'),
('Kilogramo', 'Producto en kilogramos'),
('Gramo', 'Producto en gramos'),
('Metro', 'Producto en metros'),
('Centímetro', 'Producto en centímetros'),
('Caja', 'Producto en cajas'),
('Paquete', 'Producto en paquetes'),
('Galón', 'Producto en galones'),
('Tarro', 'Producto en tarros'),
('Bolsa', 'Producto en bolsas'),
('Botella', 'Producto en botellas'),
('Juego', 'Producto en juegos'),
('Pieza', 'Producto por pieza');


select * From Categoria


SELECT Id_Prod, Nombre_Prod, Marca, Descripcion, Id_Medida, Id_cat, Precio, Stock, Activo
FROM Producto;


UPDATE Producto
SET Activo = 1  
WHERE Id_Prod = 1

EXEC sp_EliminarProducto @Id_Prod = 1;
