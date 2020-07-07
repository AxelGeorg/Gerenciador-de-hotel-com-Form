drop database hotel;
create database hotel;
use hotel;

select * from room;
select * from employees;
select * from foods;
select * from drinks;
select emp_id,emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password from employees order by emp_cpf asc; 

insert into employees (emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password) values ('axel', 'erwer', '12341234','ceo','teste','123');

drop table employees;
