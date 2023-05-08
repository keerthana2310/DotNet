CREATE TABLE Jobs(
job_id int primary key,
job_title varchar(20),
min_salary money,
max_salary money);

CREATE TABLE departments(
department_id int primary key,
department_name varchar(50),
manager_id int,
location_id int);

CREATE TABLE countries(
country_id int primary key,
country_name varchar(20),
region_id int
);

CREATE TABLE EMPLOYEE
(employee_id int primary key,
first_name varchar(20),
last_name varchar(20),
email varchar(20),
phone_number numeric,
hire_date DATE,
job_id int,
salary money,
commision_pct money,
manager_id int,
department_id int,
foreign key(job_id)references jobs(job_id),
foreign key (department_id)references departments(department_id)
);



CREATE TABLE Locations(
location_id int primary key,
street_address varchar(20),
postal_code int,
city varchar(20),
state_province varchar(20),
country_id int,
foreign key (country_id) references countries(country_id)
);




--insert into Locations values(101,"kalabham",678543,"cochin","kerala",101);

SELECT first_name,salary,12*salary+100 from EMPLOYEE;

alter TABLE employee update phone_number 

UPDATE EMPLOYEE SET phone_number = 2000000+phone_number;

SELECT*FROM EMPLOYEE
INSERT INTO EMPLOYEE values(101,'ram','gokul','kee@gmail.com',345678,'2000-11-21',456,5000,3000,789,567)
insert into EMPLOYEE values(4001,'John ','Smith','abc@gmail.com',98543322,'2023-02-02',23456,23000,5000,456,201);


DELETE FROM EMPLOYEE WHERE employee_id=90;

SELECT distinct(department_id) FROM	EMPLOYEE WHERE	last_name='smith';
select first_name,last_name ,hire_date  HIREDATE from EMPLOYEE 
order by hire_date asc;

CREATE TABLE STUDENTSGRADE(
STUDENT_ID NUMBER(12) 
SEMESTER_END DATE 
GPA NUMBER(4,3) );
SELECT STUDENT_ID,SEMESTER_END,GPA from STUDENTSGRADE
ORDER BY GPA desc;


SELECT first_name from	EMPLOYEE WHERE department_id NOT IN (SELECT department_id FROM departments
SELECT CONCAT(DEAR CUSTOMER,CUSTOMER_NAME) FROM CUSTOMERS  

insert into EMPLOYEE	(employee_id,first_name,salary,commision_pct,pf)

 values

 (1,'John Doe',50000,0.05,5000),

 (2,'Jane Smith',60000,0.1,6000),

 (3,'Bob',75000,0.15,7500);

 update Emp set

 hra=0.12*sal,

 tearn=sal+hra,

 tded=0.04*sal,

 net=tearn-tded;





