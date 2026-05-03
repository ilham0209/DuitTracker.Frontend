# DuitTracker Frontend

Blazor WebAssembly frontend for DuitTracker personal finance tracker.

## Tech Stack

- .NET 10
- Blazor WebAssembly
- Refit (HTTP client)

## Project Structure

    DuitTracker.Frontend/
    ├── Layout/
    │   ├── MainLayout.razor
    │   └── NavMenu.razor
    ├── Pages/
    │   └── Home.razor
    ├── Properties/
    │   └── launchSettings.json
    ├── wwwroot/
    │   └── index.html
    ├── _Imports.razor
    ├── App.razor
    └── Program.cs

## Getting Started

### Prerequisites

- .NET 10 SDK
- DuitTracker.Api running

### Setup

1. Clone the repository
```bash
   git clone https://github.com/ilham0209/DuitTracker.Frontend.git
   cd DuitTracker.Frontend
```

2. Run the frontend
```bash
   dotnet run
```

## Related Repository

- [DuitTracker.Api](https://github.com/ilham0209/DuitTracker.Api)
