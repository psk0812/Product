CREATE DATABASE Hamburger;
Use Hamburger;
go
CREATE TABLE product
(
	product_name VARCHAR(20),
	pruduct_day DATE,
	Defective VARCHAR(20),
	Defective_code VARCHAR(20)

)
GO
insert into dbo.product Values ('CheeseWhaper', '2023-10-02', 'TRUE', '02');
insert into dbo.product Values ('CheeseWhaper', '2023-10-02', 'FALSE', NULL);
insert into dbo.product Values ('CheeseWhaper', '2023-10-03', 'TRUE', '02');
insert into dbo.product Values ('CheeseWhaper', '2023-10-04', 'TRUE', '03');
insert into dbo.product Values ('CheeseWhaper', '2023-10-04', 'TRUE', '02');
insert into dbo.product Values ('CheeseWhaper', '2023-10-05', 'TRUE', '04');
insert into dbo.product Values ('CheeseWhaper', '2023-10-05', 'TRUE', '02');
insert into dbo.product Values ('CheeseWhaper', '2023-10-06', 'FALSE', NULL);
insert into dbo.product Values ('CheeseWhaper', '2023-10-06', 'FALSE', NULL);
insert into dbo.product Values ('CheeseWhaper', '2023-10-07', 'FALSE', NULL);
insert into dbo.product Values ('CheeseWhaper', '2023-10-07', 'FALSE', NULL);


insert into dbo.product Values ('MonsterX', '2023-10-03', 'TRUE', '01');
insert into dbo.product Values ('MonsterX', '2023-10-04', 'TRUE', '02');
insert into dbo.product Values ('MonsterX', '2023-10-04', 'TRUE', '02');
insert into dbo.product Values ('MonsterX', '2023-10-05', 'TRUE', '03');
insert into dbo.product Values ('MonsterX', '2023-10-05', 'TRUE', '01');
insert into dbo.product Values ('MonsterX', '2023-10-03', 'FALSE', NULL);
insert into dbo.product Values ('MonsterX', '2023-10-04', 'FALSE', NULL);
insert into dbo.product Values ('MonsterX', '2023-10-05', 'FALSE', NULL);
insert into dbo.product Values ('MonsterX', '2023-10-06', 'FALSE', NULL);
insert into dbo.product Values ('MonsterX', '2023-10-07', 'FALSE', NULL);

insert into dbo.product Values ('BulgogiWhaper', '2023-10-06', 'TRUE', '01');
insert into dbo.product Values ('BulgogiWhaper', '2023-10-02', 'TRUE', '02');
insert into dbo.product Values ('BulgogiWhaper', '2023-10-03', 'TRUE', '02');
insert into dbo.product Values ('BulgogiWhaper', '2023-10-04', 'TRUE', '03');
insert into dbo.product Values ('BulgogiWhaper', '2023-10-02', 'TRUE', '01');
insert into dbo.product Values ('BulgogiWhaper', '2023-10-02', 'FALSE', NULL);
insert into dbo.product Values ('BulgogiWhaper', '2023-10-03', 'FALSE', NULL);
insert into dbo.product Values ('BulgogiWhaper', '2023-10-04', 'FALSE', NULL);
insert into dbo.product Values ('BulgogiWhaper', '2023-10-05', 'FALSE', NULL);
insert into dbo.product Values ('BulgogiWhaper', '2023-10-07', 'FALSE', NULL);


insert into dbo.product Values ('ShrimpWhaper', '2023-10-03', 'TRUE', '04');
insert into dbo.product Values ('ShrimpWhaper', '2023-10-04', 'TRUE', '03');
insert into dbo.product Values ('ShrimpWhaper', '2023-10-04', 'TRUE', '01');
insert into dbo.product Values ('ShrimpWhaper', '2023-10-05', 'TRUE', '01');
insert into dbo.product Values ('ShrimpWhaper', '2023-10-05', 'TRUE', '02');
insert into dbo.product Values ('ShrimpWhaper', '2023-10-02', 'FALSE', NULL);
insert into dbo.product Values ('ShrimpWhaper', '2023-10-03', 'FALSE', NULL);
insert into dbo.product Values ('ShrimpWhaper', '2023-10-04', 'FALSE', NULL);
insert into dbo.product Values ('ShrimpWhaper', '2023-10-05', 'FALSE', NULL);
insert into dbo.product Values ('ShrimpWhaper', '2023-10-07', 'TRUE', '02');

go

SELECT * FROM dbo.product
ORDER BY product_day;

go