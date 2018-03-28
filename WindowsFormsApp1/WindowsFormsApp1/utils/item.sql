
drop table if exists item;
CREATE TABLE item(
asset int PRIMARY KEY NOT NULL,
description char(150) NOT NULL,
bldg char(8) NOT NULL,
room char(20) NOT NULL,
otherLocation varchar(20),
acqDate date,
totalCost decimal(12,2),
Model varchar(30),
serialNumber char(30) NOT NULL,
groupCode char(8),
isDelete boolean NOT NULL DEFAULT 0,
picture MediumBlob 
);




