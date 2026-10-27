# 🎬 FilmIzleme

A Windows Forms application developed with C# to manage a film list and watch film content through embedded web browsing.

## 📌 About the Project

FilmIzleme is a desktop application that allows users to list films stored in a SQL Server database, add new films, and open film links directly within the application.

The project was developed to practice Windows Forms, database operations, and working with external web content in C#.

## ✨ Features

- **Film Listing:** Display films retrieved from a SQL Server database.
- **Add New Films:** Save film titles, categories, and links to the database.
- **Embedded Browser:** Open film links inside the application.
- **User Interface:** Navigate between film listing and film entry screens.
- **Application Controls:** Includes exit and information buttons.

## 🛠️ Technologies Used

- C#
- Windows Forms
- SQL Server
- ADO.NET
- Chromium-based embedded browser (CefSharp)

## 🗄️ Database

The application uses SQL Server to store film information.

The film records are retrieved from the `Tbl_Filmler` table.

The application expects the following information for each film:

- Film name
- Category
- Film URL

**Note:** The database and connection string must be configured for your local SQL Server environment before running the application.

## 🚀 Getting Started

1. Clone or download this repository.
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string for your environment.
4. Ensure the required database and `Tbl_Filmler` table exist.
5. Restore the required NuGet packages.
6. Build and run the application.

## 🎯 Learning Objectives

This project helped me practice:

- C# Windows Forms development
- SQL Server database connectivity
- Retrieving and inserting data using SQL queries
- Using parameterized SQL commands
- Integrating web content into a desktop application

## 🔮 Future Improvements

- Add film search and filtering.
- Implement update and delete operations.
- Improve input validation and error handling.
- Move database configuration to `App.config`.
- Improve the user interface and browser experience.

---

**Developer:** [ugursema](https://github.com/ugursema)
