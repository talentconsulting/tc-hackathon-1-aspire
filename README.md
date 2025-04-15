# tc-hackathon-1-aspire
This repository contains a learning project built using Project Aspire, created from the standard Visual Studio Aspire template. It serves as a foundational starting point for future proofs of concept (POCs) and experimentation.

## ✨ Overview

The solution in this repo contains a number of projects (detailed in projects section) which when run will launch the Aspire dashboard. From here a user can monitor apps and navigate to the weather UI app

Everything is configured to run locally via Visual Studio, with integrated support for service discovery and observability.

## 🧱 Projects

| Project   	                | Description                                                   |
|-------------------------------|---------------------------------------------------------------|
| TalenPoc.ApiService           | Minimal ASP.NET Core Web API with dummy data.                 |
| TalenPoc.Web	                | Blazor WebAssembly frontend.                                  |
| TalenPoc.AppHost	            | Aspire orchestration project to run and monitor the app.      |
| TalenPoc.ServiceDefaults  	| A centralized configuration component (serviceDefaults) that applies consistent settings across all registered services (e.g., environment variables, diagnostics, timeouts). |

## 🚀 Running the Solution

1. Open the solution in Visual Studio 2022 (17.9+) with the Aspire workload installed.
2. Set the TalenPoc.AppHost as the startup project.
3. Press F5 to run.

The Aspire dashboard will launch automatically and provide a UI to inspect services, logs, and dependencies.

## 🛠️ Next Steps
- Add authentication and authorisation via Microsoft Entra ID
- Deploy to Azure App Services with GitHub Actions
- Replace PostgreSQL with Azure Cosmos DB for scalability
- Invite more teams to try Aspire in similar one-day sprints