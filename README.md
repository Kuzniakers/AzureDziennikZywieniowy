# Nutrition Journal

## Created by
- Konrad Kuźniak

## Project Description
The Nutrition Journal is a web application that allows users to monitor calorie intake, manage their meals, and track physical activity. The project was designed for users who want better control over their diet and health. Users can add new products, meals, and track their calorie deficit based on their physical activity data.
At this moment procjet is on hold in fact that I spend all credits form "Azure for students" subscritpion but it will back soon !

The application is divided into two main components:
1. **Frontend** – User interface providing clarity and ease of use.
2. **Backend (API)** – Data processing, database communication, and application logic.

The application has been deployed to Microsoft Azure cloud for scalability and easier maintenance.

---

## Features

### 1. Frontend
The frontend was built using ASP.NET Core MVC. Main features include:
- Displaying user data in tables (products, meals, activities).
- Filtering data in tables (e.g., by product name or date).
- Forms for adding new products, meals, and activities.

### 2. Backend (API)
The backend is a RESTful API built with ASP.NET Core. Main features include:
- CRUD endpoints (create, read, update, delete) for products, meals, and activities.
- Support for GET, POST, PUT, and DELETE requests.
- API documentation available via **Swagger UI**.

### 3. Database
- The database is hosted on Azure SQL Database.
- Secure and efficient storage of products, meals, and activities data.

### 4. Deployment on Azure
- The application is deployed as Docker containers in Azure App Service.
- **Azure Container Registry (ACR)** stores Docker images.

### 5. Key Functions
- Data display with filtering options.
- Adding new products, meals, and activities.
- API documentation through **Swagger UI**.

---

## Technologies and Tools

### Technologies
- **ASP.NET Core MVC** – For both frontend and backend.
- **Entity Framework Core** – Database handling.
- **Docker** – Application containerization.
- **Microsoft Azure** – Cloud hosting for the application.

### Tools
- **Visual Studio 2022** – IDE used for development.
- **Swagger UI** – API testing.
- **Azure App Service** – Container hosting.
- **Azure Container Registry (ACR)** – Docker image storage.

---

## Development Process
1. **Planning** – Defining functionalities and designing application architecture.
2. **API Development** – Implementing CRUD operations and configuring Swagger UI.
3. **Frontend Development** – Creating views and forms.
4. **Integration** – Connecting the frontend to the backend.
5. **Deployment** – Containerizing the application and deploying to Azure.
6. **Testing** – Unit and integration tests.

---

## System Architecture
- **Frontend:** MVC application hosted in an Azure container.
- **Backend (API):** RESTful API hosted in Azure.
- **Database:** Azure SQL Database integrated with the backend.

---

## Links

- **Backend API:** [Swagger UI](https://dziennikzywieniowybackendapi-fvf8bnepbfghabfk.polandcentral-01.azurewebsites.net/swagger/index.html)  
- **Application:** [Nutrition Journal](https://dziennikzywieniowy-hhcng7h9g8f3gebq.polandcentral-01.azurewebsites.net/)  

---

## Summary
The Nutrition Journal is a comprehensive application for managing diet and physical activity. By utilizing technologies such as ASP.NET Core, Docker, and Microsoft Azure, the application is scalable, easy to maintain, and provides valuable features to users.

Future development plans include implementing user authentication, advanced reporting, and integration with external fitness APIs.
