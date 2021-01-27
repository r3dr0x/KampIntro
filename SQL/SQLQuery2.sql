﻿--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'


--case insensitive
SeLecT * from Products where categoryId=1 or categoryId=3

SeLecT * from Products where categoryId=1 and UnitPrice>10

SelEcT * from Products where categoryId=1  order by UnitPrice desc --ascending --descenfing

Select count(*) Adet from Products where CategoryID=2

select categoryID,count(*) from products where unitPrice>20 group by CategoryID having count(*)<10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null