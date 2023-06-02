# Pierre's Sweet and Savory Treats App

#### Web app using C#, EF Core, SQL, and ASP.NET Identity to display treats for Pierre's Bakery.

#### By Gareth Grindeland

## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL Workbench
* Enity Framework Core version 6.0.0
* ASP.NET Core Identity version 6.0.0
* HTML & CSS
* Bootstrap version 5.2.3


## Description
__

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory at ```./PierresTreats.Solution/PierresTreats/```._

#### To Configure and Access the Database:
* _Within the production directory "PierresTreats", create a new file called ```appsettings.json```._
* _Within ```appsettings.json```, put the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your desired database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the terminal command ```dotnet ef database update``` to create the initial MySQL database._

#### To Run the App in the browser:
* _Navigate to this project's production directory named "PierresTreats"._
* _Run ```dotnet watch run``` in the command line to start the application in development mode with a watcher. This will open the webpage in your browser._
* _To exit out of the application, you can use the keyboard command "CTRL+C" on Mac and Windows._
* _Optionally, you can run ```dotnet build``` within the production directory to compile this app without running it._
* _On the webpage, click the "Create or Manage Account" button to register for an account. After creating an account and logging in, you can begin adding or updating the lists of treats and flavors._
* _Users who are not logged have read-only access to view the lists and details of available treats._


## Known Bugs

* _No Known Issues_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_