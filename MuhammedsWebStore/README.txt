Assignment 2 PART 1
2023-10-30 - 11:27 EST

Welcome to Muhammed's Web Store MVC app for the 4th time, Again I messed up the Git pull and push 

11:28	Created Muhammeds Book Store project using ASP.NET Core Web App (MVC) - SDK 5.0
11:28	Created README.txt
11:28	Comment out the port number in order for the app to work at school - in properties folder/launchSetting.json

11:29	updated Database by going to NuGet console manager, PM then inserted the command
11:29	Checked the website - Its working on the default view- we are going to change that soon
11:30	removed between () in startup.cs services.addDefaultIdentity<IdentityUser> Line 35
11:52	Added 2 breakpoints (debugging) on index and privacy methods in the HomeControllers.cs
11:52	Downloaded my favourite theme on bootswatch.com - Slate
11:53	Replaced the existing bootstrap.css file with the new downloaded one ( Lib -> dist -> css)
11:55	changed the link on layout.cshtml on line 7 from the minifind version to the regular one.
------------------------------------------------------
2023-10-31
00:01	Removed the text dark from the home and privacy links
00:03	Removed the text dark from the login and Register in LoginPartial.cshtml
00:22	Added the Datepicker from jqueryui.com, the box is not working or move with my mouse, iam going to fix that later
00:23	Adding a new dropdown menu with extra 3 subs
11:45	comment out the dragablle box as its not working as it should
11:45	Created 3 Projects of the solution Muhammed's DataAccess -Models & Utility
11:46	copied the data folder to the dataAccess
11:47	Installed Microsoft Entity Framework - tools - Manage NuGet Package for solution - install 5.0.11 as mentioned in the slides
11:48	installed the following libraries to MuhammedsWebStore

Installing:

Microsoft.EntityFrameworkCore.Relational.5.0.11

-----------------------------------------------------
11:51	Installing SQL server package 5.0.11
MuhammedsWebStore

Updates:

Microsoft.EntityFrameworkCore.SqlServer.5.0.17 -> Microsoft.EntityFrameworkCore.SqlServer.5.0.11

-----------------------------------------------------

11:53	Delete the migration folder
11:54	Install NuGet Package Identity Entity FrameWork Core as requested in the slides 5.0.2
11:59	Modify the namespace to namespace MuhammedsWebStore.DataAccess.Data in ApplicationDbcontext.cs
12:01	Deleted the default class1.cs file in all projects
12:05	Copied the model folder from the webstore to the MuhammedsBooks.Models folder
12:07	Add project Reference to .DataAccess and . Models by going to the solution right click add project references then I rename the model folder to ViewModels
12:08	Changed the errorViewModels.cs namespace to .Models.ViewModels
12:17	changed the project reference to the new @model MuhammedsWebStore.Models.ViewModels.ErrorViewModel

12:37	Created class in the utility project called it SD.cs and changed the properties of the class  from class SD to public static class SD
12:40	Added project references to models and utility Models
12:45	Added Area - Customer to Area Folder
12:45	Changed the scaffoldingReadMe.txt to pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
12:47	changed the route in startup.cs to pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
12:48	moved the HomeControllers.cs to the area - customer - controller Folder and deleted the data and models
12:49	Defined the homecontroller.cs in the customer Area
12:55	Copied viewImport and viewstart to customer area
12:55	Modified the layout reference in _ViewStart.cshtml for the new path
12:59	Added new area in Areas and called it Admin
13:01	Deleted the controller Folder
-------------------------------------------------------
									PART 2

	2023 - 10 - 31
14:50	Built the new application
14:50	changed the code in  appsetting.json from "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MuhammedsWebStore;Trusted_Connection=True;MultipleActiveResultSets=true" to the new one as per the powerpoint
15:09	used the Nuget Package Manager to add the migration 
		PM > add-migration AddDefaultIdentityMigration 
		added to the default project.DataAccess


-------------------------------------------------------
	2023 - 11 - 06
14:10	added the migration file in readme - Package Manager Console Host Version 5.11.4.13 - Type 'get-help NuGet' to see all available NuGet commands.
14:14	Reviewed the SQL syntax and statments
14:15	updated DataBase using this command pm> update-database
14:19	Reviewed the updated database tables and ran the application - its Working
14:30	Creating new class called Category.cs in the Models folder
14:35	Modified the Category Class Category.cs and added the ComponentModel.DataAnnotations Library
-------------------------------------------------------

	2023 - 11- 13
11:50	Added the Migration via pm console using this command -   add-migration AddCategoryToDb 20231113182417_AddCategoryToDb
11:52	I had Build Failed error while trying to add the migration
11:55	Comment out the unsused libraries 
11:56	Found a spelling error - changed the key to Key in the category class
11:57	Cleaned the code and rebuild it, no errors
12:00	Tried to add the migration again, I got another error
		"Build succeeded. Your target project 'MuhammedsWebStore' doesn't match your migrations assembly 'MuhammedsBooks.DataAccess'. Either change your target project or change your migrations assembly.
		Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("MuhammedsWebStore")). By default, the migrations assembly is the assembly containing the DbContext.
		Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project."
12:02	Changed the default project to DataAccess and tried again
12:12	I had an error on line 16   -  public DbSet<Category> Categories { get; set; }
13:05	I had to take a break for my sanity 
13:05	I found the issue, I added public to the class for accissiblity
13:06	I had CS0006 error - Severity	Code	Description	Project	File	Line	Suppression State
		Error	CS0006	Metadata file 'C:\Users\W0837901\Source\Repos\MuhammedAdwan\MuhammedsWebStore\MuhammedsBooks.DataAccess\bin\Debug\net5.0\ref\MuhammedsBooks.DataAccess.dll' could not be found	MuhammedsWebStore	C:\Users\W0837901\Source\Repos\MuhammedAdwan\MuhammedsWebStore\MuhammedsWebStore\CSC	1	Active

13:29	updated the library and the applicationDbcontent.cs - deleted the migration - added the migration command
13:30	updated database update-database
13:32   Added new folder called it Repository and added IRepository folder inside Repo parent folder, then added IRepository.cs interface
13:44   Modified the IRepository.cs interface with the code below to do all the CRUD operations    
            IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

13:50   Implemented the class that implement the repo
13:51   Modified the Repository.cs class by adding the using library and implement interface by rightclicking on the IRepository<T>
14:07   modify the database w/ the db context and creating constructors and dependencies injection
14:12   Added this code snippet to Repository.cs under public class Repository<T> : IRepository<T> where T : class
        //modify the database w/ the db context
        private readonly ApplicationDbContext _db; //get the db instance using the constructor and DI
        internal DbSet<T> dbset;

        public Repository(ApplicationDbContext db) //use hot keys C-T-O-R to build the constructor
        {
            _db = db;
            this.dbset = _db.Set<T>();
        }

14:19   Created individual repos CategoryRepository.cs inside Repository Folder and ICategoryRepository.cs inside IRepository Folder
14:20   Added using libraries using MuhammedsBooks.DataAccess.Repository.IRepository;
        and using MuhammedsBooks.Models; to CategoryRepository

14:25   Added using Microsoft.EntityFrameworkCore library to Repository.cs
18:40   Modified CategoryRepository.cs
18:55   Modified CategoryRepository.cs by adding this code snippet
                public void Update(Category category)
        {
            //use .net LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
19:10   Created and modified ISP_Call.cs
19:20   Adding S_Call.cs class to Repository folder, and implemented the interface
19:21   Adding using libraries to SP_Call.cs
19:32   update SP_Calls.cs to add a connection to the database
19:51   Created IUnitOfWork interface inside the IRepository folder and modified the code
        Created UnitOfWork Class and modified the code

-------------------------------------------------------------------------------------------
        2023-11-14
11:30   trying to fix the categorey in CategoryRespository.cs
11:47   Updated startup.cs with services.AddScoped<UnitOfWork, UnitOfWork>();and added new using libraries
12:21   Fixed Category issue by adding public to the controller and IcategoryRep
12:33   Created category folder in views and index.cshtml
12:37   run the application and working, now we need to add the category to the drop down menu
12:40   edited the navigation bar to add category
12:50   Added the js script to the solution
12:55   I got an error in the layout.cshtml - fixed the layout issue, i forgot the href# in the dropdown menu
13:00   Created Upsert.cshtml and added the given code + added the razor view
13:25   modifid upsert.cshtml with the edit and back
13:30   updated CategoryController.cs
13:36   Added the delete function to the category js

--------------------------------------------------------------------------------------------

        2023-11-17
11:48   updating Category Controllers.cs and Unit of works, as my upsert.cshtml not working properly
11:59   fixed the Upsert class, I can see add a category page, but I cant create any list

-------------------------------------------------------------------------------------------
        2023-11-20
11:55   Started Part 3
12:16   Created CoverType.cs in the models folder
12:25   Added the migration via PM console using the command add-migration AddCoverTypeToDb in DataAccess Default project (TIME STAMP 20231120172504_AddCoverTypeToDb)
12:30   modified the ApplicationDbcontext.cs to add public DbSet<CoverType> CoverTypes { get; set; } and modified the Migration file of AddCoverTypeToDb.cs
