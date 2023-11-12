
--Creating tipes user tables
CREATE TABLE tipo_usuarios(
    id serial,
    descripcion CHARACTER VARYING(10) NOT NULL,
    CONSTRAINT tuser_pk PRIMARY KEY(id)
);
--Creating Users Tables
CREATE TABLE usuarios(
    id serial,
    nombres CHARACTER VARYING(60) NOT NULL,
    apellidos CHARACTER VARYING(60) NOT NULL,
    username CHARACTER VARYING(15) NOT NULL,
	mail CHARACTER VARYING(15) NOT NULL,
    password CHARACTER VARYING(16) NOT NULL,
    id_tuser INT NOT NULL,
    CONSTRAINT user_pk PRIMARY KEY(id),
    CONSTRAINT tuser_pk FOREIGN KEY(id_tuser) REFERENCES tipo_usuarios(id)
);

--Creating Types of clothes
CREATE TABLE categorias(
    id serial,
    descripción CHARACTER VARYING(15),
    CONSTRAINT cat_pk PRIMARY KEY(id)
);
--Creating tables proveedores
CREATE TABLE proveedores(
    id serial,
    ruc INT NOT NULL,
    nombre CHARACTER VARYING(100) NOT NULL,
    direccion CHARACTER VARYING(100) NOT NULL,
    telefono CHARACTER VARYING(10) NOT NULL,
    email CHARACTER VARYING(60) NOT NULL,
    CONSTRAINT prov_pk PRIMARY KEY(id)
);

--Creating producto tables
CREATE TABLE productos (
    id serial,
    nombre CHARACTER VARYING(50) NOT NULL,
    precio NUMERIC(10,2) NOT NULL,
    cantidad INT NOT NULL,
    id_cat int NOT NULL,
    id_prov int NOT NULL,
    CONSTRAINT prod_pk PRIMARY KEY(id),
    CONSTRAINT cat_fk FOREIGN KEY(id_cat) REFERENCES categorias(id),
    CONSTRAINT prod_fk FOREIGN KEY(id_prov) REFERENCES proveedores(id)
);

--Creating ventas tables
CREATE TABLE VENTAS(
    id serial,
    id_usuario INT NOT NULL,
    id_producto INT NOT NULL,
    total_venta NUMERIC(10,2) NOT NULL,
    CONSTRAINT vent_pk PRIMARY KEY(id),
    CONSTRAINT user_pk FOREIGN KEY(id_usuario) REFERENCES usuarios(id),
    CONSTRAINT prod_pk FOREIGN KEY(id_producto) REFERENCES productos(id)
);
