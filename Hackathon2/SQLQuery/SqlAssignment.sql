USE Assignment

CREATE Table Employee_Manager (
EmpID int primary key, 
Name varchar(50),
Salary Int, Manager_Id int null);

Insert into Employee_Manager(EmpId,Name,Salary,Manager_Id)Values
(1, 'Rohit', 20000,3),
(2,'Sangeeta',12000,5),
(3,'Sanjay',10000,5),
(4,'Arun',25000,3),
(5,'Zaheer',30000,null);

select e.Name as emp_Name, m.Name AS mgr_Name
from Employee_Manager e
Left join Employee_Manager m
on e.Manager_Id = m.EmpId
order by e.Name;
