# WebAPINumberInput

This project contains the development of two applications - server (REST API) and client. The client sends some input that is going to be processed by the server. The input is either a number that is going to be added to a database, or a list of numbers that are the indexes of database numbers, so that the server can add them and return the value of the sum.

# Main Features

- Add a number to the DB
- Get the sum of 2 or more numbers
- Display the list of items in the DB

# Technologies

- ASP.NET core (c#)
- MySQL
- JavaScript
- React
- HTML
- CSS

# Purpose of this exercise

- Design the solution
- Get to know the .NET environment
- Data modeling

# Build the server

You should clone this repo and open the WebAPIInput.sln in Visual Studio. This solution uses MySQL as the RDMS - if you want to user other one, you should change line 28 of Startup.cs to better suit your Database. Next step is to check the ConnectionString in the appsettings.json - you should check the port, database name, user and password. You should also check the SSL port in launchSettings.json file under the Properties folder. After all this checks you can start debugging by either pressing F5, or click Debug in Visual Studio toolbar - and a Tab should open in your Browser automatically with the application running ready to be tested :)
