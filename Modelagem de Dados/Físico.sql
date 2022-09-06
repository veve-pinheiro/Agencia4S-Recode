use fourseasons;
CREATE TABLE DESTINO
(
id int not null,
cidade varchar (45) not null ,
estado varchar (45) not null,
PRIMARY KEY (cidade)
);

CREATE TABLE PRECO
(
id int not null,
valornormal double not null,
valorpromo double not null,
valordesconto double not null,
PRIMARY KEY (id)
);


CREATE TABLE PACOTES
(
id varchar (45) not null,
cidade varchar (45) not null,
id_preco int not null,
Primary Key (id),
CONSTRAINT fk_city foreign key (cidade) REFERENCES DESTINO (cidade),
CONSTRAINT fk_idpreco foreign key (id_preco) REFERENCES PRECO (id)
);
