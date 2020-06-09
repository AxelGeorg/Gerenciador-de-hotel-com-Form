drop table Employees;
create table Employees (
	emp_id      int(8) primary key auto_increment,
    emp_name    varchar(15) not null,
    emp_surname varchar(15) not null,
    emp_CPF     varchar(15) not null,
    emp_office  varchar(15) not null,
    emp_salary  float(8) not null,
    emp_status   varchar(15) not null,
    emp_password varchar(15) not null,
    emp_email varchar(40) not null
);

insert into Employees (emp_name,emp_surname,emp_CPF,emp_office,emp_salary,emp_status,emp_email,emp_password) values ('Axel','Georg','22131343','ceo',3000,'clt','axelgeorggfertylkjjh','12345');

select * from Employees;