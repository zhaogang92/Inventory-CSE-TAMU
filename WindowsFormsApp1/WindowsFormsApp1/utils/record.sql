drop table if exists record;
Create TABLE record(
recordID int PRIMARY KEY NOT NULL AUTO_INCREMENT,
staffID int NOT NULL,
foreign key(staffID) references staff(staffID),
itemID int NOT NULL,
foreign key(itemID) references inventory(asset),
isReturn boolean NOT NULL DEFAULT 0,
recordDate date
);

drop table if exists borrowRecord;
Create TABLE borrowRecord(
borrowRecordID int PRIMARY KEY NOT NULL AUTO_INCREMENT,
staffID int NOT NULL,
foreign key(staffID) references staff(staffID),
itemID int NOT NULL,
foreign key(itemID) references inventory(asset),
borrowRecordDate date
);

drop table if exists lendRecord;
Create TABLE lendRecord(
lendRecordID int PRIMARY KEY NOT NULL AUTO_INCREMENT,
staffID int NOT NULL,
foreign key(staffID) references staff(staffID),
itemID int NOT NULL,
foreign key(itemID) references inventory(asset),
lendRecordDate date
);
