# aspnetcore_mvc_dapper_crud
 This example project build with asp net core mvc and orm dapper
 
 Status: <b>Release Version 1.0</b>
 
 # Technology
 1. ASP .NET Core 3.1
 2. ORM Dapper
 3. MySQL
 
 # Required Project
 1. MySQL
 2. Visual Studio IDE or another
 3. Net Core SDK 3.1 or above
 
 # Instalation
1. Clone this project with new repository or download project file
2. Create database ex: dapper
3. Create table book with : 
~~~
CREATE TABLE `book` (
	`ID` INT(11) NOT NULL AUTO_INCREMENT,
	`Title` VARCHAR(250) NOT NULL,
	`Author` VARCHAR(250) NOT NULL,
	`PublishedDate` DATETIME NOT NULL,
	PRIMARY KEY (`ID`)
);

INSERT INTO book(Title,Author,PublishedDate)
VALUES ('Dream of Krabs','Fauzi','2020-05-24');
~~~
4. Setting connection database in <code>appsettings.json</code>
5. Finish..

<br><br><br>Created by: <a href="https://www.instagram.com/fauzigalihajisaputro/">@fauzigalihajisaputro</a>

