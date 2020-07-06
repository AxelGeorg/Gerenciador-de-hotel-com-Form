create table employees (
	emp_id          int primary key auto_increment,
    emp_nome        varchar(15) not null,
    emp_sobrenome   varchar(15) not null,
    emp_cpf         varchar(15) not null,
    emp_titulo      varchar(15) not null,
    emp_email       varchar(15) not null,
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
    room_precoDiaria     float not null,
    room_precoTotal      float
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





