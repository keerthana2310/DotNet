/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[ProductName]
      ,[Productcost]
  FROM [ProductDB].[dbo].[Product]