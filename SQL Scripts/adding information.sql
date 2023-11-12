--Creating type user
INSERT INTO tipo_usuarios (descripcion) VALUES ('user'), ('admin');
-- creating user
INSERT INTO usuarios (nombres, apellidos, username, mail, password, id_tuser) 
VALUES ('Jhon', 'Bohorquez', 'jhon', 'jhon@gmail.com', '1234', (SELECT id FROM tipo_usuarios WHERE descripcion = 'user'));

-- creating categories of cloth
insert into categorias("descripción") Values ('vestidos'),('pantalon'),('camiseta'),('camisa'),('pantaloneta')

-- creating proveedores
INSERT INTO proveedores (ruc, nombre, direccion, telefono, email) VALUES
(123456789, 'Susana Horia', 'Calle Falsa 123', '1234567890', 'susanaHo@gmail.com'),
(234567890, 'Axel Torres', 'Avenida Principal 456', '2345678901', 'axto@gmail.com'),
(345678901, 'Marco Polo', 'Boulevard del Sol 789', '3456789012', 'polo@gmail.com'),
(456789012, 'Juan Doumet', 'Ruta Norte 101', '4567890123', 'juan@gmail.com'),
(567890123, 'Eliza Rendon ', 'Paseo de la Montaña 202', '5678901234', 'elRen@gmail.com');

-- creating products
INSERT INTO productos (nombre, precio, cantidad, id_cat, id_prov) VALUES
('AnaClothEx', 19.99, 100, (SELECT id FROM categorias WHERE descripción = 'vestidos'), 1),
('MariaClothEx', 29.99, 150, (SELECT id FROM categorias WHERE descripción = 'pantalon'), 2),
('LauraClothEx', 9.99, 200, (SELECT id FROM categorias WHERE descripción = 'camiseta'), 3),
('SofiaClothEx', 24.99, 120, (SELECT id FROM categorias WHERE descripción = 'camisa'), 4),
('CarlaClothEx', 14.99, 130, (SELECT id FROM categorias WHERE descripción = 'pantaloneta'), 5),
('ElenaClothEx', 20.99, 110, (SELECT id FROM categorias WHERE descripción = 'vestidos'), 1),
('PatriciaClothEx', 30.99, 140, (SELECT id FROM categorias WHERE descripción = 'pantalon'), 2),
('LuisaClothEx', 10.99, 210, (SELECT id FROM categorias WHERE descripción = 'camiseta'), 3),
('DianaClothEx', 25.99, 115, (SELECT id FROM categorias WHERE descripción = 'camisa'), 4),
('NataliaClothEx', 15.99, 135, (SELECT id FROM categorias WHERE descripción = 'pantaloneta'), 5);


