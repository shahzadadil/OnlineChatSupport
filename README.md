# OnlineChatSupport
Sample application for listing of agents using Entity, WebAPI and AngularJS framework


Prerequisite
------------
1. Visual Studio 2013 with .NET 4.5.1
2. Visual Studio plugin for running AngularJS test cases. Downloadable from <a href="https://visualstudiogallery.msdn.microsoft.com/f8741f04-bae4-4900-81c7-7c9bfb9ed1fe">Here</a>
3. SQL Server for database access using Entity Framework 
4. SQL Server Compact Framework 4.0 for running unit test cases relating to Data Access

Assumptions
-----------
1. The necessary packages and tools are available
2. Internet connection is available for downloading packages
3. The local instance of SQL Server has Windows Authentication mode enabled and does not require custom username and password

Steps
-----
1. Download the solution
2. Open it in Visual Studio
3. Build the solution, allow the necessary packages to get downloaded and installed
4. Launch the Web project in a browser
5. Click on the <b>Agents</b> menu for list of agents
6. Click on the <b>Admin</b> menu for managing agent status (This page is for demo purposes and the implementation would be different in real world scenario)

Solution Architecture
----------------------
The solution has been divided into multiple projects for separation of concerns and simplicity

1. <strong>Core</strong> - Holds the business logic and all the operations. Holds source code for repositories which are central points of access for the data.
2. <strong>Core.Test</strong> - Contains unit test cases for source code residing in Core project. Uses NUnit framework for unit test case definition and execution. Uses SQL Server Compact Framework for running database operations in test cases.
3. <strong>Domain</strong> - Contains the Data Access Layer. Responsible for connecting to the database using Entity Framework. Also contains ViewModels that would be the structure of the data getting returned from WebAPI.
4. <strong>Web</strong> - The frontend project that makes use of WebAPI and the AngularJS framework.The App and App.Tests contains the AngularJS components and their respective unit test cases. The test cases have been designed using Jasmine Test framework. The project also employs Dependency Injection concept using Castle Windsor Framework.

Design Patterns
---------------
1. <strong>MVVM</strong> - The application uses ViewModels to return the filtered data from WebAPI to the client side framework implemented using AngularJS
2. <strong>Repository</strong> - The application centralises the entire business logic by the use of repositories which would act as a central point for data access


