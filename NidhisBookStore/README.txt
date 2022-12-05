Assignment 2

PART 1 - SETTING UP THE PROJECT
-------------------------------------------------------------------

2022-10-24 1324
Spun up default ASP.NET Core MVC application
using HTTPS
Individual Account Authorization
Razor Runtime

(Found your database table into your SQL databses injection for initial create migration (like first assignment))

PART 1.1 - REVIEW
-------------------------------------------------------------------

Application project is called "NidhisBookStore"

1325 - Create GITHUB respository
1328 - Create GITHUB repo ...now confirming the ability to push the repository

Commented out hte SSL port restrictions from launchSettings.json file in Properties folder

PART 1.2 - DEBUGGING
-------------------------------------------------------------------

Run and Tested the application first to see how does it goes with the browsers..

2022-10-27
pulled repo down to 45N ... reviewed README and code... start to complete
the "debugging" activity, confirm, then apply the bootstrap theme

Remove the (options => options.SignIn.RequireConfirmedAccount = true) line from startup.cs

PART 1.3 - BOOTSTRAP
-------------------------------------------------------------------

Try to add new spacelab theme css into bootstrap.css file according to ppt of assignment 2 part 1

1258
Adding info to the README on the friday, and tweaked the HomeController to return an IActionResult to the Error page

1318
Completed the debugging exercise... homework.. How do I call the Error.cshtml file?
first download the bootstrap.css and rename the existing bootstrap.css from the folder..
then modify  the link rel in _Layout.cshtml

Not succeded..

1324
I have to remove some properties in the _Layout.cshtml
in line 24, 27 text-Dark..
Add some properties in line 40..

1331
Reviewed the bootswatch theme - Spacelab
Now its time to go home!!

2022-10-31
1155
Added Spacelab theme from bootswatch.com website and made neccessary changes into __Layout.cshtml and _LoginPartial.cshtml file..
upload changes into GitHub..

1349
Added Dropdown menu named Content Management according to the given code and made changes neccesary into _Layout.cshtml file..

2022-11-03
20:00
Try to cloned repository from GitHub but can not see the last changes that I made - Dropdown
So I deleted the old project from users/source/repos/NidhikumariVadodariya floder
Then I download file from GitHub and replace at the deleted file and cloned that file into visual studio 2019..

Started this file and did rebuid and clean the project so I can make sure that my work is working by making the last changes likr dropdown..
Project running successfully..

PART 1.4 - PROJECTS ADDED AND MODIFIED
-------------------------------------------------------------------

now started 1.4 project adding and modifying part..
Added new project - NidhisBooks.DataAccess into the existing project along with the solution one.
Project added successfully..

like first project - NidhisBooks.DataAccess - I added 2 more projects, NidhisBooks.Models and NidhisBooks.Utility
Two projects added successfully..

Then Copied Data folder from the main NidhisBookStore project and paste into NidhisBooks.DataAccess folder..

21:00
Through NuGet Package Manager solution window, Installed new package of Microsoft.EntityFrameworkCore.Relational into the packages(3.1.16)
Then deleted Migration folder from Data folder from .DataAccess project

As the error shown in ApplicationDbContext due to another package of Identity.EntityFrameworkCore for reference, I added that package as well..
Errors have been gone and I gave "namespace NidhisBookStore.DataAccess.Data" namespace which reflects the project..

As per instructions, then I removed default Class1.cs file from all three projects..

By mistakenly added three projects inside the main project to main project so deleted the inside one main project and moved all three .DataAccess, .Model, and .Utility projects into main one..
Then tried to buid all three projects those were build successfully but main NidhisBookStore is showing errors..
Try to solve those errors..

Error did not solved so deleted all three projects and made new one.. same as before one.. 
cloned GitHub zip file and replace it with the old one into source/repos/NidhikumariVadodariya/NidhisBookStore folder

But, I forgot to see next slides and Irealised that I had not given references to the main projects so far..
so for main project - NidhisBookStore - The errors were coming because of not giving reference of .DataAccess and .Models files to the main project as the Data and Model files were deleted..
Both projects build successfully..

Repository was not worked so created old repository and made new one on GitHub and push all the changes that I did..
Rename the Models folder to ViewModels..

Could not solve errors of the main NidhisBookStore project..
Try to solve those errors still..

Errors are of Duplicate attribute in project files..
Feeling very sad..

Though the errors mostly because of Error.cshtml file from Views/Shared/.. folder, I tried to solve and edit those errors in this file but I could not solve anything or edit anything in this file..

Took break.. and went for fresh..

1:00
Tried to solve errors and add SD.cs class into .Utility project and Add Customer Area into Area project of Main..

Now I am going to try another time by saving this project on GitHub and on my Local Path as well..

1:45 AM
I Created new project whole again.. and It works now success fully till adding SD.cs file and Customer area into Areas folder..

ScaffoldingReadMe.txt file created and done all the changes..
Moved HomeController.cs file to the Area/Customer/Controller folder..and then edit the namespace in it and explicitly define the Customer area like this [Area("Customer")]
One Error came for not changed {area:exists} to the {area=Customer} into the HomeController.cs
Error solved and got output like given in the browser..
Then Copied _ViewImports.cshtml and _ViewStart.cshtml files into the Customer Area's View folder

Changed the reflected path "Layout = "~/Views/Shared/_Layout.cshtml" and application run successfully at the 3:04 AM..

Created Admin area into Area folder...

Forgot to delete Data and Models folder from Customer so I deleted it with the Admin Folder and Deleted COntroller Folder as well..

Now I Update GitHub repository at last..

FINALLY DONE AS GIVEN.. at early morning 3:25 AM..
NOW SLEEPING..HAHAHA..



Assignment 2

PART 2 BUILD THE PROJECT

PART 2.1 - CREATE THE DB
-------------------------------------------------------------------

2022-11-11
13:30
Run the application just make sure that it is well worked to execute the next part

Application run successfully without any errors and ready to build for the next part..

In the appsettings.json file, after reviewed the database conection string (Database=NidhisBookStore) for update it with my application name and saved it using code-first..

20:00
For migration, first I added wrong migration name "add-migration AddDefaultIdentityMigration" but it gives me error of "Your target project 'NidhisBookStore' doesn't match your migrations assembly 'NidhisBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("NidhisBookStore")). By default, the migrations assembly is the assembly containing the DbContext."
Though build was succeeded.. ****20221112011029_AddDefaultIdentityMigration.cs****

Now I added correct one by changing the default project name "NidhisBooks.DataAccess" and run the command for migration and "Build succeeded".

Now Database needs to be updated by the command update-database and checked that all tables are added into SQL Server Object Explorer.

Added now new table by creating Category.cs class into "NidhisBooks.Models" and modify it.
Now Added migration to it.. It is empty because it does not have Application DB Context..

Added "public DbSet<Category> Categories { get; set; }" this line into ApplicationDbContext.cs file..
Then I re-run the "add-migration AddCategoryToDb" but as the name is being used once it would give an erroe "The name 'AddCategoryToDb' is used by an existing migration."
So solve this duplication error and added new name migration "add-migration AddCategoryIntoDB" and update the database to confirm the new category table added into SQL Server Object Explorer..


PART 2.2 - REPOSITORY
-------------------------------------------------------------------

Make new folder "Repository" and inside it also created "IRepository" folder where into added class name for interface "IRepository.cs" to the project in "NidhisBooks.DataAccess".
Add neccessary changes into that file and or in interface to use on Category class and and perfrom all the CRUD operations..

Methods to use for CRUD are added into the "IRepository.cs":
- Get item from the DB
- List of Categories
- Add objects
- Remove objects

Add "Repository.cs" file into the "Repository" folder where Implement the interface from the potential fixes using  IRepository<T> and
Modify the code to create the constructors and Dependancy Injection (DI).

2022-11-13
12:45 AM
From the given Assignment 2 Files folder, modify the code for implement the constructors and Dependancy Injection (DI) in Repository.cs file.

Added ICategoryRepository.cs and CategoryRepository.cs files into IRepository and Repository folder, respectively..

Modify the CategoryRepository but got below error for ICategoryRepository (as classes can not have base multiple class)
"Class 'class' cannot have multiple base classes"

After modifying the ICategoryRepository.cs file by void Update method it shows gain new error like "CategoryRepository does not implement interface member 'ICategoryRepository.Update(Category)' ".

Now I reviewed this error and complete the interface implementation code into CategoryRepository.cs file.........

And there you go.. Errors are gone...

Modify the anothe code in CategoryRepository.cs to retrive the first or default category object..

Added new Interface in IRepository folder called ISP_Call.cs and extends IDisposable..
Added Dapper and install its latest version according to the potential fixing errors..

Modify  ISP_Call.cs interface according to the implementation..

Make a new class file  SP_Call.cs into the Repository folder and modify the code for database coonection string 

Now add the Wrapper for Unit of Work...

take a break, commit in GitHub repository and Sleep now..

11:30 AM

I wake up and did fresh start...

Make IUnitOfWork interface  into the IRepository folder and UnitOfWork to the Repository folder and modify UnitOfWork.cs file according to given..
and I make sure that public class implements the IUnitOfWork interface that I make - UnitOfWork : IUnitOfWork 
Got errors due to not adding using statement before but it has been solved by potential fixes..

Register that both of them into the Startup.cs with adding necessary using statements.

Buid the default project and no errors found..
Now jump on to the next part...


PART 2.3 - CATEGORY CRUD
-------------------------------------------------------------------

Took break..

5:30PM
After registration in Startup.cs file, I added new MVC controller called "CategoryController.cs" and modify the code (API CALLS) using IUnitOfWork from .DataAccess/IRepository.

Add a new folder called Catedory same like controller name and add a new view - Razor view, named Index.cshtml and modify the code as per given.
But when I went to run the application, Admin/Category page was not showing to me in the browser..
I tired many times to solve that but I could not..
So I go back and again re-checked all the code and I found isse of not giving  [Area("Admin")] to the CategoryCOntroller.cs and after when I run the application, it was run successfully and my page has shown in the browser.
Then I moved the Category link to the ContentManagement dropdown so that it can show the Category from the dropdown menu in it.

Worked Well..
Now I commit the changes to the GitHub..

Create "Edit and Delete" buttons and "Create new Category" using Upsert action
Where I added IActionResult to the "CategoryController.cs"..
After that just like Index.cshtml view, I added another one called "Upsert.cshtml" but it is with only for Layout page option enable..
in "Upsert.cshtml", modify the code as per given and now its time to add "_CreateAndBackToListButton.cshtml" into the outer side of (general (main)) "Views/Shared/... folder..
It will add another one like for Edit "_EditAndBackToListButton.cshtml"
NOTE - CODE ADDITION WITH THE @MODEL RAZOR STATEMENT

Modify the Upsert.cshtml view with @Model razor..

Took break at 10:00PM

Start again at 12:00AM
Modify the Upsert.cshtml view by adding @model statement on first line
And after that add asp-action into the "Index.cshtml" file for connection..

And run the application but it was giving me error of not adding category in upsert file so I rechecked the "Upsert.cshtml" file code and add @title reference at the place of TITLE..
And Application now run successfully as it is shown..

I also called @session to scripts to validate the input to the client side test..

Later on I opened CategoryController.cs file for create Upsert POST action method; as save method was not available at that time, 
IunitOfWork.cs file has added void save(); method by potential fixes from the CategoryController.cs file.
Then I removed _db.SaveChanges() method from CategoryRepository.cs file and move _unitOfWork.Save() along with the return RedirectToAction method according to given..

At last while the time of running the application, I got error as given for update and create the category..
Categories was not displaying correctly, so I changed @if(Model.Id != 0) instead of @if(Model.Id != null) in Upsert.cs file

For delete category, in CategoryController.cs file, I add Application Programming Interface (API).

Then Implement the [HttpDelete] with the delete method in category.js file located in wwwroot/js/.
which shows wheather there is an error while delete the category or not..

Add the delete functionality in category.js file with including the onClick event to the delete function
At last and finally I modified and added the code for Delete(url) from the last slide which uses a "sweet alert" 
for success and error messages and "Toastr" for notifications..

Try to add, update, delete categories.. and performed all the actiones successfully..

Now GitHub commit and sleeping time at 2:15 AM..


Assignment 2

PART 3 BUILD THE PROJECT - FOR COVERTYPE

PART 3.1 - CREATE THE COVERTYPE CRUD SAME LIKE CATEGORY
-------------------------------------------------------------------

2022-11-23
10:00 PM

Run the project just to make sure that privious part is working..
Run successfully..
Start to follow the instructions for part 3 where I need to make the same table and type as Category for CoverType..

Open the Assignment 2's part 2.1 where I created CoverType.cs class file in NidhisBooks.Models just like Category.cs
After that I added (modify) table for CoverType Model for Id and Name 
Then I added migration for CoverType in PM Console by adding code add-migration AddCoverTypeToDb by choosing default project type for .DataAccess

WHERE THE FIRST MIGRATION FILE NAME WITH THE MIGRATION TIMESTAMP IS *****20221124032926_AddCoverTypeToDb.cs*****
- This "20221124032926_AddCoverTypeToDb.cs" migration file was empty before adding the code "public DbSet<CoverType> CoverTypes { get; set; }" into ApplicationDbContext like Category.

AND

SECOND MIGRATION FILE NAME WITH THE MIGRATION TIMESTAMP IS *****20221124033521_AddCoverTypeIntoDB.cs*****
- After adding "public DbSet<CoverType> CoverTypes { get; set; }" this code, I run this 20221124033521_AddCoverTypeIntoDB.cs migration and avoid duplicate errors.

Then I update-database and check the CoverType table into SQL SOE where I have this table..

and I commit the code and push it to the GitHub..

Sleep..

2022-11-24
3:00 PM

Get back from work and started

PART 3.1 - REPOSITORY
-------------------------------------------------------------------

3:43 PM
Follow the instructions and make CoverTypeRepository.cs class into Repository and ICoverTypeRepository.cs interface into IRepository folders and made neccessary changes like did for CategoryRepository.cs and ICategoryRepository.cs for the respective folders.
Added Using statements according to the needs and one error that I got before adding Update method in CoverTypeRepository.cs file is -
"'CoverTypeRepository' does not implement interface member 'ICoverTypeRepository.Update(CoverType)'".
Update into the Readme and push changes into GitHub..

Add code into IUnitOfWork.cs "ICoverTypeRepository CoverType { get; }"
and in UnitOfWork.cs for construction and DI for repository..
Commit changes and push to the GitHub.


PART 3.1 - COVERTYPE CRUD
-------------------------------------------------------------------

4:30 PM

Add CoverType folder into the Area Admin folder and added CoverTypeController.cs controller file. 
made neccessary changes like CategoryController.cs file and make Index view under the Views folder named CoverType (give same name as CoverTypeController) like Category.

CoverType link moved to the Content Managenent Dropdown in _Layout.cshtml file

Run the application and got the result successfully as shown in Assignment part 2 ppt for Category..

Commit the changes and push it to the GitHub..

5:00 PM

Review the last changes and add CoverType section to the Index.cshtml file for edit and delete icons.
Again after reviewing this changes Delete these lines and add it to the covertype.js javascript file based in wwwroot/js folder along with the category.js file.

Now in Index.cshtml file, add the @section call to the covertype.js script file and run the application.
Then activate the Edit and Delete buttons and create the new CoverType into the Upsert action

Add the IAction result to the controller and added a Upsert view just like Index one and copy and paste the code just like in the Category's Upsert view and make neccessary changes for CoverType and its object.
In this I don't need to create _CreateAndBackToListButton.cshtml and _EditAndBackToListButton.cshtml files for buttons as those are same for this.

Add the asp-action to the Index.cshtml page and now when I navigate the new CoverType.

Update Title variable and name for Edit CoverType then add the @section call to Scripts to validate input on CLient-side test.
Now I created Upsert POST action to the CoverTypeController.cs and now it allows to be added and deleted and edited.

Remove _db.SaveChanges(); method from the CoverTypeRepository.cs and move _unitOfWork.Save(); method with the return RedirectToAction method.

Now Added API call into the CoverTypeController.cs just like in the CategoryController.cs file. and for this Delet API call, I added delete functionality to the covertype.js file with the onclick event and for popup functionality added code below like in category.js file for new item adding.

For got to Commit in GitHub file so commit changes on it..

PART 3.2 - PRODUCT CRUD
-------------------------------------------------------------------

8:30PM

Now for the third Product action, I added new class called Product.cs in .Models folder just like Category.cs and CoverType.cs
then added required code in that class to build the blue print of it and added public identifier in it for class.
I, after repeat that same steps just like other before classes::
- Add reference to the new Product piece to the database in the ApplicationDbContext.cs file in .DataAccess project
- Then I added migration for Product in PM Console by adding code add-migration AddProductToDb by choosing default project type for .DataAccess

WHERE THE FIRST MIGRATION FILE NAME WITH THE MIGRATION TIMESTAMP IS *****20221125004306_addProductToDb.cs*****
- This "20221125004306_addProductToDb.cs" migration file was empty before adding the code "public DbSet<Product> Products { get; set; }" into ApplicationDbContext like Category.
Then I update-database and check the Product table into SQL SOE where I have this table along with the fields and datatypes that I added..

add migration addValidateProductToDb.cs  *****20221125163826_addValidateProductToDb.cs*****
update the database and commit all

- After this I make class file named ProductRepository.cs and interface IProductRepository.cs in to Repository and IRepository folder, respectively.
- Updated and modify the code into the ProductRepository.cs file according to the fields.

Then updated Product to the UnitOfWork.cs and IUnitOfWork.cs which would help to create the migration in the database..
Mo errors are seen and ready to move to the next part..

Took break..

PART 3.2 - PRODUCT CRUD (2)
-------------------------------------------------------------------

9:30 PM
Now its time to add ProductCOntroller to the Areas/Admin to perform the CRUD operations.
for this I added IWebHostEnvironment call and error resolved by adding using statement "using Microsoft.AspNetCore.Hosting" in public controller method.

Then after I created ViewModel in the Models project to hold the Product object and Select list for Category and CoverType.
- Created ProductVM.cs class to the ViewModels folder and install Microsoft.AspNetCore.Mvc.ViewFeatures latest 2.2.0 version package for that as well.
- Modify the ProductController.cs for IActionResult Upsert calls to the ProductVM view model along with the required using statement and install Microsoft.AspNetCore.Mvc.Rendering package from PM colsole.

For temporary, commented out the Upsert post method and modify the API call to include Category and CoverType properties..
Next after scafollding Index.cshtml view for the Product, Copied Category's index file and paste it to the Product's Index file and added fields for it..
Just after creating the product.js file and did changes to it pasted from category.js file.

- Added Link for the Product in the dropdown menu in _Layout.cshtml file and review the changes which are successfully run and got exeption as mentioned..


PART 3.2 - PRODUCT CRUD (3)
-------------------------------------------------------------------

11:00 PM

Then loaded Product Upsert view text from the given Assignment 2 files and changed where the links or Id's for Category and Covertype files added to the Product file in the browser..
- After as per the instructions, first I made an account in "tiny.cloud" website and pick API key that has been provided for sript src.

- I, later modify the Upsert.cshtml code by adding rich textarea inside the product with "tiny.cloud" and initialize that API key and add a function to validate input and also create and disply sweet alert if it is empty..

Appliction run successfully as shown without any errors..

So happy.. :))

Last but not least,

Add new image s folder with the subfolder products inside and configure the Product Upsert Post Action Method to the ProductController.cs
Uncomment the commented Upsert code as given in ProductController.cs file.. and test the application by adding new product item..

Application Run successfully till given part 3..
Commited Code to GitHub and push..

Sleeping time..

*********************************

2022-12-05
1:30AM
Old project was gone so made new one and copied old readme and pasted it in new repository NidhisBookStore_ and commit all the things..

Started new PART 1 of the assignment
and going further and commiting the things along with the changes into files and folders just like old one..
Project is running successfully without errors and going continue as like before..

Its time to add all three new projects..
1) NidhisBooks.DataAccess
2) NidhisBooks.Models
3) NidhisBooks.Utility

Added Data folder and delete old one and new nuget packages and change namespace for reflection of .DataAccess and deleted all three class1 files from this.. UPDATED README..
Move Models folder to NidhisBooks.Models project and make neccessary changes into ErrorViewModel.cs file and give reference and change Models folder name to ViewModels ... and added project references as well..UPDATED README file..
Added assembly reference to HomeCOntroller.cs and Startup.cs file as well...
Application run successfully..
Made SD.cs file ang give reference to the .Utility project from the main NidhisBookStore project.. UPDATE README

Move HomeController folder to the new Cistomer area that is being made into Areas folder in general main project and modify Startup.cs file with {area=Customer} and Edit code into the moved HomeContoller.cs.. UPDATED README..
Make new Admin area like Customer and Added new Files into View folder and deleted Data and View folder like Customer.UPDATE README..

3:00 AM
Started new PART 2 of the assignment
and going further and commiting the things along with the changes into files and folders just like old one..
Project is running successfully without errors and going continue as like before..

Now I am going to create database..
Change database name..

******20221205081355_AddDefaultIdentityMigration****** - add migration for Default Identity

******20221205084805_AddCategoryToDb****** add migration for Category table.. UPDATE DATABASE AND README.. and making sure that got category table into SQL SOE and deleted old database..

Added Repository and IRepository folder and added neccesary files and modify them accordingly like before in to NidhisBooks.DataAccess project:
- Repository.cs for classes
	- CategoryRepository.cs
	- Repository.cs

- IRepository.cs for interfaces 
	- ICategoryRepository.cs
	- IRepository.cs

Added another files for classes and interfaces and modify them:
- Repository.cs for classes
	- CategoryRepository.cs
	- Repository.cs
	- SP_Call.cs
	- UnitOfWork.cs

- IRepository.cs for interfaces 
	- ICategoryRepository.cs
	- IRepository.cs
	- ISP_Call.cs
	- IUnitOfWork.cs

There are no errors and build successfully project..