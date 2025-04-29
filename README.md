# Persistent Storage with Database Integration

This project extends a simple **REST API** built with **ASP.NET Core Web API** to integrate a relational or NoSQL database for persistent storage.

The API supports **CRUD** (Create, Read, Update, Delete) operations on a **User** resource and uses a database (e.g., MySQL, MongoDB) for storing user data persistently.

## ✨ Features:
- Create a new user
- Retrieve all users
- Update an existing user
- Delete a user
- Persistent storage using a database (MySQL/MongoDB)
- Environment-specific configurations using `.env` files
- Connection pooling for efficient database connections
- Input validation (valid email format)
- Proper status codes for responses (400 Bad Request, 404 Not Found, etc.)

## 🚀 Technologies Used:
- ASP.NET Core 8.0 Web API
- C#
- ORM (Entity Framework Core or MongoDB Driver)
- MySQL / MongoDB (depending on the selected database)
- Environment Variables for secure credentials

## 📚 Project Structure:
- `Controllers/UsersController.cs` - API endpoints for user operations
- `Models/User.cs` - User model definition
- `Services/UserService.cs` - Service for interacting with the database
- `appsettings.json` - Database configurations (e.g., connection strings)
- `.env` - Environment-specific settings (database credentials, etc.)

## 🛠️ How to Run:
1. Clone the repository:
   ```bash
   git clone https://github.com/ElgharibAhmed091/TaskApiTwocrud.git
