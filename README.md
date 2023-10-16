# Taskify

Taskify is a Blazor project that allows you to create and manage your personal or professional tasks. 
It features a dashboard with BlazorMud BarCharts that show the progress and status of your tasks. 
It also uses SQL EXPRESS and APIs to store and retrieve data.

# Installation

To install Taskify, you need to have the following prerequisites:

- [.NET 7.0 SDK]
- [SQL Server Express]
- [Visual Studio 2019] or [Visual Studio Code] with [C# extension]

### Then, follow these steps:

- Clone or download the repository from `https://github.com/Argonses/Taskify`
- Open the solution file Taskify.sln in Visual Studio 2019 or open the folder Taskify in Visual Studio Code.
- Update the connection string in the appsettings.json file to point to your SQL Server Express instance.
- Run the update-database command in the Package Manager Console (Visual Studio 2019) or in the terminal (Visual Studio Code) to create the database and tables.
- Run the project by pressing F5 or clicking the Run button.
  
# Usage

You can create, edit, delete, and complete tasks by using the buttons and forms on the main page. 
You can also view your dashboard by clicking the Dashboard link on the top menu. The dashboard shows you a summary of your tasks and their status using BlazorMud BarCharts.

# License

Taskify is licensed under the MIT License. 
