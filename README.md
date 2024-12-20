# Hávira Todo API Project
This project is an implementation of a [test](https://git.egl.eng.br/havira-publico/prova-havira-backend) for backend develop

## Run the Project
Steps to run the project

### Required dependencies
- .NET 8 SDK
- PostgresSQL

### How to run
```bash
-- clone the project 
git clone https://github.com/guilhermeotsu/havira-todo-api.git && cd havira-todo-api

-- edit the ConnectionString in appsettings
nano ./src/Havira.Todo.API/appsettings.json

-- apply the migrations on database
dotnet ef database update --project src/Havira.Todo.API/Havira.Todo.API.csproj

-- restore and run the project
dotnet restore ./Havira.Todo.sln && dotnet run --project src/Havira.Todo.API/Havira.Todo.API.csproj

-- open browser
firefox http://localhost:5096/swagger/index.html
```

## Overview
This section provides a high-level overview of the project. In this project it's designed to put skill and competition, including but not limited:
- Proficiency with C# and .NET 8.0
- Project Layer separation, applying some concepts of DDD
- Skill with ORM (Entity Framework) and Database (PostgreSQL)
- Implementation of Design Patter (Mediator Pattern)
- Familiarity with object mapping lib (AutoMapper)
- Version control (Git)
- Code organization
- Error Handling
- Code quality
- Documentation

## Stack
The stack is set of modern Web Frameworks and Tools, selected based on my proficiency and prerequisites by the test.

Backend:
- Git
- .NET 8.0
- C#

Database:
- PostgreSQL

## Frameworks
The Framework used in this project:
- AutoMapper
- MediatR
- JwtToken
- EntityFramework
- FluentValidation

## API Structure
This section includes a basic overview about the APIs implementated 

### Auth API
This API provides a funcionality to authenticate an User.

#### POST /auth/login
- Description: Authenticate a user
- Request Body:
  ```json
  {
    "username": "string",
    "password": "string"
  }
  ```
- Response: 
  ```json
  {
    "token": "string"
  }
  ```

### User API
This API provides a funcionality to interact with User entity.

#### GET /user/{userId}
- Description: Retrieve a user by their Id.
- Query Parameters:
    - userId(required): Id User who was created previous
- Response:
```json
  {
    "id": "guid",
    "email": "string",
    "password": "string"
  }
```

#### POST /user
- Description: Add a new User
- Request Body:
```json
  {
    "email": "string",
    "password": "string",
  }
```
- Response Body:
```json
  {
    "success": "bool",
    "message": "string",
    "data": {
        "id": "guid",
        "email": "string",
        "password": "string"
    }
  }
```

### Todo API
This API provides a CRUD to Todo entity.

#### GET /todo
- Description: List all Todo's created by the User
Respose body:
```json
{
    "success": "bool",
    "data": [{
        "title": "string",
        "description": "string",
        "createAt": "date",
        "completedAt": "date"
    }]
}
```
#### GET /todo/{id}
- Description: Retrieved a Todo by the Todo identifier
Respose body:
```json
{
    "success": "bool",
    "data": {
        "title": "string",
        "description": "string",
        "createAt": "date",
        "completedAt": "date"
    }
}
```

#### POST /todo
- Description: Create a new Todo
- Request body:
```json
{
    "title": "string",
    "description": "string"
}
```
- Response body:
```json
{
    "success": "bool",
    "data": {
        "id": "guid",
        "title": "string",
        "description": "string",
        "userId": "guid",
        "createdAt": "date",
        "completedAt": "date"
    }
}
```
#### DELETE /todo/{id}
- Description: Delete a Todo
- Query Parameters:
    - id: Id of a Todo
- Response body:
```json
{
    "success": "bool"
}
```

#### PATCH /todo
- Description: Update a Todo
- Request body:
```json
{
    {
        "id": "guid",
        "title": "string",
        "description": "string",
        "userId": "guid",
        "completedAt": "date"
    }
}
```
- Response body:
```json
{
    {
        "id": "guid",
        "title": "string",
        "description": "string",
        "userId": "guid",
        "completedAt": "date"
    }
}
```

## Project Structure
The project is structured as follows:
```
root
├── src/
├── tests/
└── README.md
```

## TODO
- Write unit and integrate Code
- Add Logs
- Add docker and docker-compose
- Improve Documentation
