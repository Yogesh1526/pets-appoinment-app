# HealingPaws Application

This guide provides step-by-step instructions to set up and run the HealingPaws application. The application consists of a backend API and a frontend Angular project.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- *SQL Server* or any other compatible database server
- *.NET SDK* (for running the API project)
- *Node.js* and *npm* (for running the Angular project)

## Steps to Set Up and Run the Application

### 1. Execute `healingpaws.sql`

First, you need to set up the database for the application.

1. Open your SQL Server Management Studio (SSMS) or any SQL client of your choice.
2. Connect to your SQL Server instance.
3. Open the `healingpaws.sql` file.
4. Execute the script to create the database and necessary tables.

### 2. Update Connection String in the API Project

Next, configure the API project to connect to the newly created database.

1. Navigate to the API project directory.
2. Open the `appsettings.json` file.
3. Locate the connection string section and update it with your SQL Server details. It should look something like this:

    json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server_name;Database=HealingPawsDB;User Id=your_username;Password=your_password;"
    }
    

### 3. Update API URL in the Angular Project

Now, configure the Angular project to point to the correct API URL.

1. Navigate to the Angular project directory.
2. Open the `environment.ts` file located in the `src/environments` folder.
3. Update the `apiUrl` variable with the correct URL of your API. It should look something like this:

    typescript
    export const environment = {
      production: false,
      apiUrl: 'http://localhost:7159/api'
    };
    

### 4. Run the API Project and Angular Project

After configuring the connection strings and API URL, you can now run both the API and Angular projects.

#### Running the API Project

1. Open a terminal or command prompt.
2. Navigate to the API project directory.
3. Run the following command to start the API project:

    bash
    dotnet run
    

   Ensure that the API is running and accessible at the URL you configured in the Angular project.

#### Running the Angular Project

1. Open a terminal or command prompt.
2. Navigate to the Angular project directory.
3. Run the following commands to install dependencies and start the Angular project:

    bash
    npm install
    ng serve
    

   The Angular application should now be running and accessible at `http://localhost:4200`.

### 5. Follow the Steps in the "Appointments" Section

With both the API and Angular projects running, you can now use the application. Follow the steps shown in the "Appointments" section of the application to manage appointments.

## Conclusion

You have successfully set up and run the HealingPaws application. If you encounter any issues or need further assistance, please refer to the project's documentation or reach out to the support team.
