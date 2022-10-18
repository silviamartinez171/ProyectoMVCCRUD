CREATE DATABASE DBACTA
USE DBACTA


CREATE TABLE NOTASEST(
Id int identity (1,1) primary key,
Carnet nvarchar(12),
Apellido nvarchar(30),
Nombre nvarchar(30),
IPN smallint,
IIPN smallint,
Sist smallint,
Proyec smallint,
NF smallint
)

select * from NOTASEST

Create trigger Tr_SDNC 

on dbo.NOTASEST after insert as update NOTASEST set NF=IPN+IIPN+Proyec+Sist 

  

Create trigger Tr_SDNU 

on dbo.NOTASEST after update as update NOTASEST set NF=IPN+IIPN+Proyec+Sist 

