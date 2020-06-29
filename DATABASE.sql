use hotel;

select * from employees;

create table room (
	room_id              int primary key auto_increment,
    room_numeroQuarto    varchar(15) not null,
    room_quantPessoa     int not null,
    room_quantCasal      int not null,
    room_quantSolteiro   int not null,
    room_disponibilidade bool not null,
    room_limpeza  		 bool not null,
    room_precoDiaria     float not null,
    room_precoTotal      float,
    fk_frigID int,
    CONSTRAINT fk_frigoBar FOREIGN KEY (fk_frigID) REFERENCES frigoBar (frig_id)
);

insert into room (room_numeroQuarto, room_quantPessoa, room_quantCasal, room_quantSolteiro, room_disponibilidade, room_limpeza, room_precoDiaria, fk_frigID)
           values('A01', 4, 1, 2, true, true, 120, 2);

insert into frigoBar (frig_identificacao) values ('FrigoBar A03');

create table frigoBarProduto (
	frigP_id          int primary key auto_increment,
    frigP_nomeProduto varchar(30) not null,
    frigP_preco       float not null,
    frigP_quant		 int not null	
);

create table frigoBar (
	frig_id            int primary key auto_increment,
    frig_identificacao varchar (30) not null,
    fk_frigPID         int,
    CONSTRAINT fk_frigoP FOREIGN KEY (fk_frigPID) REFERENCES frigoBarProduto (frigP_id)
);

drop table frigoBarProduto;