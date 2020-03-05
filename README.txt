I declare that, except where duly acknowledged, this project is entirely my own work.

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

LeafletJS 1.6.0 w/ OpenStreetMaps & Mapbox
https://leafletjs.com/examples/quick-start/
Views/Map.cshtml 


