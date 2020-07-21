create table employees (
	emp_id          int primary key auto_increment,
    emp_nome        varchar(20) not null,
    emp_sobrenome   varchar(35) not null,
    emp_cpf         varchar(15) not null,
    emp_titulo      varchar(15) not null,
    emp_email       varchar(55) not null,
    emp_password 	varchar(15) not null
);

create table room (
	room_id              int primary key auto_increment,
    room_numeroQuarto    varchar(15) not null,
    room_quantPessoa     int not null,
    room_quantCasal      int not null,
    room_quantSolteiro   int not null,
    room_disponibilidade bool not null,
    room_limpeza  		 bool not null,
    room_precoDiaria     float not null
); 

create table foods(
	food_id    int primary key auto_increment,
    food_nome  varchar(15),
    food_preco float,
    food_tipo  varchar(15)
);

create table drinks(
	dri_id int primary key auto_increment,
    dri_nome  varchar(15),
    dri_preco float,
    dri_tipo  varchar(15)
);

create table guest (
	gue_id int primary key auto_increment,
    gue_nome varchar (30) not null,
    gue_cpf varchar(15) not null,
    gue_dataNascimento date not null,
    gue_diasReservado int,
    gue_precoTotal float,
    gue_fk_room int,
    CONSTRAINT fk_room FOREIGN KEY (gue_fk_room) REFERENCES room (room_id)
);
