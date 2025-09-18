USE Assignment

SELECT * FROM LOCATIONS
SELECT * FROM EMPLOYEES
SELECT * FROM COUNTRIES
SELECT * FROM DEPARTMENTS
SELECT * FROM JOB_HISTORY
SELECT * FROM JOBS
SELECT * FROM LOCATIONS

----1----
/*Write a query to display the lastname, department number, and department name for all employees.*/
SELECT 
    E.LASTNAME,
    E.DEPARTMENT_ID,
    D.DEPARTMENT_NAME
FROM 
    EMPLOYEES E
JOIN 
    DEPARTMENTS D ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;

 ----2----
 /*Create a unique listing of all jobs that are in department 30. Include the location id in the output.*/
SELECT DISTINCT
	E.JOB_ID,
	D.LOCATION_ID
FROM
	EMPLOYEES E
JOIN
	DEPARTMENTS D ON E.DEPARTMENT_ID = D.DEPARTMENT_ID

WHERE
	E.DEPARTMENT_ID = 30;

----3----
/*Write a query to display the employee lastname, department name, location id, and city of all employees who earn a commission.*/
SELECT 
	E.LASTNAME,
	D.DEPARTMENT_NAME,
	L.LOCATION_ID,
	L.CITY
FROM
	EMPLOYEES E
JOIN 
	DEPARTMENTS D ON E.DEPARTMENT_ID = D.DEPARTMENT_ID
JOIN
	LOCATIONS L ON D.LOCATION_ID = L.LOCATION_ID
WHERE 
	E.COMMISSION_PCT IS NOT NULL;

----4----
/*Display the employee lastname, and department name for all employees who have an "a" in their lastname.*/
SELECT
    e.lastname,
    d.department_name
FROM 
    employees e
JOIN 
    departments d ON e.department_id = d.department_id
WHERE 
    e.lastname LIKE '%a%';
----5----
/*Write a query to display the lastname, job, department number, and department name for all employees who work in Toronto.*/
SELECT
    E.LASTNAME,
    E.JOB_ID,
    E.DEPARTMENT_ID,
    D.DEPARTMENT_NAME
FROM 
    EMPLOYEES E
JOIN 
    DEPARTMENTS D ON E.DEPARTMENT_ID = D.DEPARTMENT_ID
JOIN 
    LOCATIONS L ON D.LOCATION_ID = L.LOCATION_ID
WHERE 
    L.CITY = 'Toronto';


----6----
/*Display the employee lastname and employee number along with their manager's lastname and manager number. Label the columns "Employee", "Emp#", "Manager" and "Manager#" respectively.*/
SELECT 
	E.LASTNAME AS "Employee",
	E.EMPLOYEE_ID AS "Emp#",
	M.LASTNAME AS "Manager",
	M.EMPLOYEE_ID AS "Manager#"
FROM 
	EMPLOYEES E
JOIN 
	EMPLOYEES M ON E.MANAGER_ID = M.EMPLOYEE_ID;


----7----
/*Modify the above to display the same columns for all employees (including "King", who has no manager). Order the result by the employee number.*/
SELECT
    E.LASTNAME AS 'Employee',
    E.EMPLOYEE_ID AS 'Emp#',
    M.LASTNAME AS 'Manager',
    M.EMPLOYEE_ID AS 'Manager#'
FROM 
    EMPLOYEES E
LEFT JOIN 
    EMPLOYEES M ON E.MANAGER_ID = M.EMPLOYEE_ID
ORDER BY 
    E.EMPLOYEE_ID;

----8----
/*Create query that displays employee lastnames, department numbers, and all the employees who work in the same department as a given employee. Give each column an appropriate label.*/
SELECT
	E.LASTNAME AS "EMPLOYEE",
	E.DEPARTMENT_ID AS "DEPT ID",
	C.LASTNAME AS "COLLEAGUE"
FROM 
	EMPLOYEES E
JOIN
	EMPLOYEES C ON E.DEPARTMENT_ID = C.DEPARTMENT_ID
WHERE E.EMPLOYEE_ID <> C.EMPLOYEE_ID
ORDER BY
	E.EMPLOYEE_ID, C.EMPLOYEE_ID

----9----
/*Create a query that displays the name, job, department name, salary and grade for all employees.*/
SELECT 
	E.LASTNAME AS "EMPLOYEES",
	J.JOB_TITLE AS "JOB",
	D.DEPARTMENT AS "DEPARTMENT",
	E.SALARY AS "SALARY",
	CASE
		WHEN E.SALARY > 20000 THEN 'A'
		WHEN E.SALARY >15000 THEN 'B'
		WHEN E.SALARY > 1000 THEN 'C'
		WHEN E.SALARY > 5000 THEN 'D'
		ELSE 'E'
	END AS 'GRADE'
JOIN 
	DEPARTMENT D ON E.EMPLOYEE_ID = D.DEPARTMENT_ID  


----10---- 
/*Create a query to display the name and hiredate of any employee hired after employee "Davies"*/
select lastname,HIRE_DATE 
from EMPLOYEES 
where HIRE_DATE >(select HIRE_DATE 
								 from EMPLOYEES 
								 where lastname='Davies');

----11----
/*Display the names and hire dates for all employees who were hired before their managers, along with their manager's names and hiredates. Label the columns "Employee", "Emp hired", */
select emp.LASTNAME as "Employee",emp.HIRE_DATE as "Emp hired",manager.LASTNAME as "Manager",manager.HIRE_DATE as "Manager hired" 
from EMPLOYEES emp left join EMPLOYEES manager 
on emp.MANAGER_ID = manager.EMPLOYEE_ID where emp.HIRE_DATE < manager.HIRE_DATE;

----12---- 
/*Display the highest, lowest, sum and average salary of all employees. Label the columns "Maximum", "Minimum", "Sum", and "Average" respectively.*/
select Max(SALARY) as "Maximum" ,min(SALARY) as "Minimum", sum(SALARY) as "Sum" ,avg(SALARY) AS "Average" from EMPLOYEES;

----13---- 
/*Modify the above query to display the same data for each job type.*/
/*select * from JOBS;*/
select max(MAX_SALARY)+max(MIN_SALARY) as "Maximum",min(MIN_SALARY) + min(MAX_SALARY) as "Minimum",sum(MIN_SALARY)+ sum(MAX_SALARY) as "Sum" ,avg(MIN_SALARY) + avg(MAX_SALARY) as "Average" from JOBS;

----14---- 
/*Write a query to display the number of people with the same job.*/
select count(*) as "Number of people",emp.JOB_ID from EMPLOYEES emp group by emp.JOB_ID

----15----
/*Determine the number of managers without listing them. Label the column "Number of Managers". [Hint: use the MANAGER_ID column to determine the number of managers]*/
select * from EMPLOYEES

select count(distinct MANAGER_ID) as "Number of Managers" from EMPLOYEES;

----16----
/*Write a query that displays the difference between the highest and the lowes salaries. Label the column as "Difference".*/
select max(SALARY)-min(SALARY) as "Difference" from EMPLOYEES 

----17---- 
/*Display the manager number and the salary of the lowest paid employee for that manager. Exclude anyone whose manager is not known. Exclude any group where the minimum salary is less than $6000. Sort the output in descending order of salary.*/
select MANAGER_ID as "Manager Number", min(SALARY) as "Lowest Salary"  from EMPLOYEES
where MANAGER_ID is not NUll
GROUP BY MANAGER_ID
HAVING min(SALARY)>=6000
ORDER BY min(SALARY) DESC;

----18----
/*Write a query to display each department's name, location, number of employees, and the average salary for all employees in that department. Label the columns "Name", "Location", "No.of people", and "SAlary" respectively. Round the average salary to two decimal places.*/

select dept.DEPARTMENT_NAME as "Name",count(*) as "NO.of people",Round(avg(emp.SALARY),2) as "Salary",l.CITY as "Location" from EMPLOYEES emp join DEPARTMENTS dept on emp.DEPARTMENT_ID = dept.DEPARTMENT_ID 
join LOCATIONS l ON dept.LOCATION_ID = l.LOCATION_ID
group by dept.DEPARTMENT_NAME,l.CITY


----19----
/*Write a query to display the lastname, and hiredate of any employee in the department as the employee "Zlotkey". Exclude "Zlotkey".*/
select * from EMPLOYEES where LASTNAME = 'Zlotkey'; 
select LASTNAME,HIRE_DATE from EMPLOYEES where DEPARTMENT_ID= (select DEPARTMENT_ID from EMPLOYEES where LASTNAME='Zlotkey') and LASTNAME<>'Zlotkey';


----20----
/*Create a query to display the employee numbers and lastnames of all employees who earn more than the average salary. Sort the result in ascending order of salary.*/
SELECT EMPLOYEE_ID,LASTNAME FROM EMPLOYEES WHERE SALARY > (select avg(SALARY) FROM EMPLOYEES)
order by SALARY;

----21----
/*Write a query that displays the employee number and lastname of all employees who work in a department with any employee whose lastname contains a "u".*/
select EMPLOYEE_ID,LASTNAME from EMPLOYEES where DEPARTMENT_ID in (select DEPARTMENT_ID from EMPLOYEES where LASTNAME like '%u%');

----22----
/*Display the lastname, department number, and job id of all employees whose department location id is 1700.*/
select emp.LASTNAME,emp.DEPARTMENT_ID,emp.JOB_ID from EMPLOYEES emp join DEPARTMENTS dept on emp.DEPARTMENT_ID=dept.DEPARTMENT_ID
where dept.LOCATION_ID=1700;

----24----
/*Display the department number, lastname, and job id for every employee in the "Executive" department.*/
select emp.LASTNAME,emp.DEPARTMENT_ID,emp.JOB_ID from EMPLOYEES emp join DEPARTMENTS dept on emp.DEPARTMENT_ID=dept.DEPARTMENT_ID
where dept.DEPARTMENT_NAME='Executive'



----26----
/*Write a query to get unique department ID from employee table.*/
select distinct DEPARTMENT_ID from EMPLOYEES;

----27----
/*Write a query to get all employee details from the employee table order by first name, descending.*/
select * from EMPLOYEES order by FIRSTNAME DESC;

----28----
/*Write a query to get the names (first_name, last_name), salary, PF of all the employees (PF is calculated as 15% of salary).*/
select (FIRSTNAME + ' ' + LASTNAME) as names ,salary, salary*0.15 as PF from Employees

----29----
/*Write a query to get the employee ID, names (first_name, last_name), salary in ascending order of salary.*/
select EMPLOYEE_ID,(FIRSTNAME + ' ' + LASTNAME) as names ,salary from Employees order by SALARY 


----31----
/*Write a query to get the maximum and minimum salary from employees table.*/
select min(salary) as "minimum salary",max(salary) as "maximum salary" from EMPLOYEES

----32----
/*Write a query to get the average salary and number of employees in the employees table.*/
select avg(salary) as "Average Salary",count(EMPLOYEE_ID) as "number of employees" from EMPLOYEES

----35----
/*Write a query get all first name from employees table in upper case.*/
select UPPER(FIRSTNAME) as "Names in UpperCase" from EMPLOYEES;

----36----
/*Write a query to get the first 3 characters of first name from employees table.*/
select FIRSTNAME from EMPLOYEES where FIRSTNAME like '___';

----37----
/*Write a query to get the names (for example Ellen Abel, Sundar Ande etc.) of all the employees from employees table.*/
select (FIRSTNAME + ' ' + LASTNAME) as names from EMPLOYEES

----38----
/*Write a query to get first name from employees table after removing white spaces from both side.*/

select TRIM(FIRSTNAME),LEN(FIRSTNAME) as "First Name" from EMPLOYEES;

----39----
/*Write a query to get the length of the employee names (first_name, last_name) from employees table.*/
select (FIRSTNAME + LASTNAME),LEN(FIRSTNAME + LASTNAME) as "Full Name" from EMPLOYEES;

----40----
/*Write a query to check if the first_name fields of the employees table contains numbers.*/
select ISNUMERIC(FIRSTNAME) from EMPLOYEES;

----41----
/*Write a query to select first 10 records from a table.*/
select top(10) * from EMPLOYEES;

----42----
/*Write a query to get monthly salary (round 2 decimal places) of each and every employee.*/
select ROUND((salary/12),2) as "monthly salary" from EMPLOYEES

----43----
/*Write a query to display the name (first_name, last_name) and salary for all employees whose salary is not in the range $10,000 through $15,000.*/
select (FIRSTNAME + LASTNAME) as "full Name" ,salary from EMPLOYEES where salary not Between 10000 and 15000;

----44---- 
/*Write a query to display the name (first_name, last_name) and department ID of all employees in departments 30 or 100 in ascending order.*/
select (FIRSTNAME + LASTNAME) as "full name" ,DEPARTMENT_ID  from Employees 
where DEPARTMENT_ID in (30,100) order by DEPARTMENT_ID;

----45----
/*Write a query to display the name (first_name, last_name) and salary for all employees whose salary is not in the range $10,000 through $15,000 and are in department 30 or 100.*/
select (FIRSTNAME + LASTNAME) as "full Name" ,salary,DEPARTMENT_ID from EMPLOYEES where 
salary not Between 10000 and 15000 and (DEPARTMENT_ID in (30,100)) ;

----47----
/*Write a query to display the first_name of all employees who have both "b" and "c" in their first name.*/
select FIRSTNAME from EMPLOYEES where FIRSTNAME like '%b%' and FIRSTNAME like '%c%';

----49----
/*Write a query to display the last name of employees whose names have exactly 6 characters.*/
select LASTNAME from EMPLOYEES where LEN(LASTNAME)=6;

----50----
/*Write a query to display the last name of employees having 'e' as the third character.*/
select LASTNAME from EMPLOYEES where LASTNAME like '__e%'

