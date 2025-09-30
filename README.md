# FileWebAPI

## Overview
CRUD Web API with .NET 9, heavily focused on Dependency Injection.
Uses PostgreSQL as a database and is containerized with Docker for deployment to Azure.

## Project Structure
- Controllers/ - API endpoints
- Models/ - Data models (MyFile, IFile)
- Repositories/ - Data access layer
- Services/ - Business logic layer
- Program.cs - DI configuration and middleware
- Dockerfile - Docker build for API
- docker-compose.yml - Runs API + PostgreSQL
- README.md - Project documentation

## Getting Started