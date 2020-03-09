I declare that, except where duly acknowledged, this project is entirely my own work.

INSTALLATION INSTRUCTION

In order to run this project locally the following is required:
Visual Studio 2019 with ASP.NET Core 3.0
SQL Server Management Studio 2017

The project will not run without the database set up. To install the database on your machine, You must run the "LocationerDatabase" SQL script in the project folder. You may need to adjust the file path of Inventory and Inventory_log at the top of the script in order to match the equivalent of the path on your machine, in particular, the "MSSQL14.MSSQLSERVER part of the script. 

Once this database is installed the filepath of the database connection in the project itself needs to be changed in the appsettings.json file. In the InventoryDatabase variable, change "DESKTOP2" to whatever the name of the server you installed the Inventory database on is called. This can be seen in the left panel of SQL Server Management Studio.

CODE GENEREATION TOOLS

Visual Studio generates a template ASP.NET Core project whenever a new project is created. This process generated the following:
wwwroot/css
wwwroot/js
wwwroot/vendor
Controllers/HomeController
Models
Views/Home/Index.cshtml
Views/Shared
Program.cs
Startup.cs
This gave me a lot of code to start off with

Microsoft Entity Framework Core was used to generate the models: InventoryContext.cs, City.cs and Country.cs.I used the following packet manager console command to scaffold them:
Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
Then I used the "add MVC Controller with Views, using Entity Framework" option in Visual Studio to generate the controllers:
CitiesController.cs and CountriesController.cs as well as the View folders for Cities and Countries.
More information about this process can be found here: https://www.syncfusion.com/blogs/post/build-crud-application-with-asp-net-core-entity-framework-visual-studio-2019.aspx

In order to create the data tables I used for the Microsoft Identity feature, I had to generate them using a migration which can be found in the Migrations folder. I used the following package manager command to do this: Add-Migration AddingIdentity.
More information about this process can be found here: https://csharp-video-tutorials.blogspot.com/2019/06/aspnet-core-identity-tutorial-from.html

THIRD PARTY COMPONENTS

Travelo HTML Template by colorlib
https://colorlib.com/wp/template/travelo/
wwwroot/travelo

LeafletJS 1.6.0 w/ OpenStreetMaps & Mapbox
https://leafletjs.com/examples/quick-start/
Views/Map.cshtml 


