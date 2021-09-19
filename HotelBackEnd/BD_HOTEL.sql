CREATE TABLE TBL_MAESTRA(
	CO_MAESTRA INTEGER PRIMARY KEY,
	TX_MAESTRA NVARCHAR(200),
	NU_CODIGO INTEGER,
	TX_DESCRIPCION NVARCHAR(200),
	TX_VALOR_GENERAL01 NVARCHAR(200),
	TX_VALOR_GENERAL02 NVARCHAR(200),
	TX_VALOR_GENERAL03 NVARCHAR(200),
	TX_VALOR_GENERAL04 NVARCHAR(200),
	TX_VALOR_GENERAL05 NVARCHAR(200),
	FL_ESTADO CHAR(1)
);


CREATE TABLE TBL_PERSONA (
CO_PERSONA  INTEGER IDENTITY PRIMARY KEY,
--CO_MAESTRO_TIPO_PERSONA INTEGER NOT NULL,  -- SI ES PERSONA NATURAL O JURIDICA
CO_TIPO_PERSONA INTEGER NOT NULL,
--CO_MAESTRO_TIPO_DOC INTEGER NOT NULL,  -- SI ES DNI, RUC, ETC
CO_TIPO_DOC INTEGER NOT NULL,
TX_NUMERO_DOCUMENTO NVARCHAR(50) NOT NULL,
TX_NOMBRE_COMPLETO NVARCHAR(300) NOT NULL,
TX_CORREO NVARCHAR(300) NOT NULL,
TX_TELEFONO NVARCHAR(15) NOT NULL,
TX_DIRECCION  NVARCHAR(300) NOT NULL,
FE_NACIEMIENTO DATE,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER

);

CREATE TABLE TBL_CLIENTE(
CO_CLIENTE INTEGER IDENTITY PRIMARY KEY,
CO_PERSONA INTEGER,

FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),

FOREIGN KEY (CO_PERSONA) REFERENCES TBL_PERSONA(CO_PERSONA)
);



CREATE TABLE TBL_CARACTERISTICAS_HAB(
CO_CARACTERISTICAS_HAB INTEGER IDENTITY PRIMARY KEY,
TX_DESCRIPCION VARCHAR(200),
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER
);




CREATE TABLE TBL_TIPO_HABITACION(
CO_TIPO_HABITACION INTEGER IDENTITY PRIMARY KEY, 
TX_TIPO_HABITACION VARCHAR(200),
TX_DESCRIPCION VARCHAR(2000),
NU_CAPACIDAD INTEGER,
NU_PRECIO MONEY,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER
);

CREATE TABLE TBL_DETALLE_TIPO_HAB(
CO_TIPO_HABITACION INTEGER,
CO_CARACTERISTICAS_HAB INTEGER,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
FOREIGN KEY (CO_CARACTERISTICAS_HAB) REFERENCES TBL_CARACTERISTICAS_HAB(CO_CARACTERISTICAS_HAB),
FOREIGN KEY (CO_TIPO_HABITACION) REFERENCES TBL_TIPO_HABITACION(CO_TIPO_HABITACION)
);


CREATE TABLE TBL_HABITACION(
CO_HABITACION INTEGER IDENTITY PRIMARY KEY, 
CO_TIPO_HABITACION INTEGER,
NU_HABITACION INTEGER,
NU_PISO INTEGER,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER,
FOREIGN KEY (CO_TIPO_HABITACION) REFERENCES TBL_TIPO_HABITACION(CO_TIPO_HABITACION)
);


CREATE TABLE TBL_RESERVA(
CO_RESERVA INTEGER IDENTITY PRIMARY KEY,
CO_CLIENTE INTEGER,
CO_TIPO_HABITACION INTEGER,
FE_INGRESO 	DATETIME,
FE_SALIDA 	DATETIME,
FL_PAGO_TOTAL CHAR(1),
NU_ACOMPANIANTES INTEGER,
NU_MONTO_ADELANTO MONEY,
NU_TIPO_PAGO INTEGER,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
FOREIGN KEY (CO_CLIENTE) REFERENCES TBL_CLIENTE(CO_CLIENTE),
FOREIGN KEY (CO_TIPO_HABITACION) REFERENCES TBL_TIPO_HABITACION(CO_TIPO_HABITACION)
);

CREATE TABLE TBL_CHECK_IN(
CO_CHECK_IN INTEGER IDENTITY PRIMARY KEY, 
CO_CLIENTE INTEGER,
CO_HABITACION INTEGER,
CO_RESERVA INTEGER,
NU_ACOMPANANTES INTEGER,
FE_INGRESO DATETIME,
FE_SALIDA DATETIME,
NU_MONTO_ADELANTADO MONEY,
NU_PRECIO_TOTAL MONEY,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER,
FOREIGN KEY (CO_CLIENTE) REFERENCES TBL_CLIENTE(CO_CLIENTE),
FOREIGN KEY (CO_HABITACION) REFERENCES TBL_HABITACION(CO_HABITACION)
);

CREATE TABLE TBL_HUESPEDES_CHEK_IN(
CO_HUESPED INTEGER IDENTITY PRIMARY KEY,
CO_CHECK_IN INTEGER,
CO_PERSONA INTEGER,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
CO_USUARIO INTEGER,
FOREIGN KEY (CO_CHECK_IN) REFERENCES TBL_CHECK_IN(CO_CHECK_IN),
FOREIGN KEY (CO_PERSONA) REFERENCES TBL_PERSONA(CO_PERSONA)
);

CREATE TABLE TBL_PERFIL(
CO_PERFIL INTEGER IDENTITY PRIMARY KEY,
TX_NOMBRE NVARCHAR(200),
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
);

CREATE TABLE TBL_USUARIO(
CO_USUARIO INTEGER IDENTITY PRIMARY KEY,
CO_PERSONA INTEGER,
CO_PERFIL INTEGER,
FE_REGISTRO DATETIME,
FL_ESTADO CHAR(1),
FOREIGN KEY (CO_PERSONA) REFERENCES TBL_PERSONA(CO_PERSONA),
FOREIGN KEY (CO_PERFIL) REFERENCES TBL_PERFIL(CO_PERFIL)
);

