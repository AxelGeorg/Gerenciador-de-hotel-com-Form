select * from employees;

select * from employees;

insert into employees (emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password) values ('Vilson', 'Lima', '123456','nada','daniteste','123');

select emp_id,emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password from employees order by emp_cpf asc; 

drop table frigobarproduto;
drop table frigobar;
drop table room;
select fri_id, fri_nome, fri_cocaCola, fri_cocaColaConsumido, fri_bolacha, fri_bolachaConsumida from frigobar;

insert into frigobar (fri_nome,fri_cocaCola,fri_cocaColaConsumido,fri_bolacha,fri_bolachaConsumida) values ('A02',5,0,9,2);