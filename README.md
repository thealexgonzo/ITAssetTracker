# ITAssetTracker

## Project Overview
A comprehensive system designed to manage and track IT assets and support tickets within an organisation.

## Architecture

## Tech Stack
- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Clean Architecture
  
## How to run locally
- Clone repository
- Run database migrations
- Start application
  
## Current features
- Asset Management
    - View all assets with details such as type, manufacturer, model, status, and location
    - Add, edit, and delete assets
    - Assign assets to employees and departments
    - Track software licenses and assignments
- Ticketing System
    - Create and manage support tickets for asset-related issues
    - Assign tickets to IT staff
    - Update ticket status, priority, and resolution
    - Add notes to tickets
- Reporting
    - Generate reports on asset distribution, value, and status
    - Analyze software license usage and compliance
    - Track ticket resolution times and common issues
- User Management
    - Implement ASP.NET Identity with role-based access control
    - Manage user accounts and permissions
- API for External Systems
    - Create a RESTful API for integration with other systems (e.g., procurement, finance)
    - Implement authentication and authorization for API access
