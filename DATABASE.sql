create database hotel;
use hotel;

create table Employees (
	emp_id      int(8) primary key auto_increment,
    emp_name    varchar(15) not null,
    emp_surname varchar(15) not null,
    emp_CPF     varchar(15) not null,
    emp_office  varchar(15) not null,
    emp_salary  float(8) not null,
    emp_status   varchar(15) not null
);