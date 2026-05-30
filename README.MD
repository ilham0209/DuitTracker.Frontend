# DuitTracker Frontend

A personal finance tracker frontend built with Blazor WebAssembly (.NET 10) and MudBlazor.

## Tech Stack

| Technology | Purpose |
|---|---|
| .NET 10 | Framework |
| Blazor WebAssembly | SPA Frontend |
| MudBlazor | UI Component Library |
| Blazored.LocalStorage | Local Storage |
| System.IdentityModel.Tokens.Jwt | JWT Parsing |

## Project Structure

```
DuitTracker.Frontend/
│
├── Constants/
│   ├── ApiRoutes.cs
│   ├── AppConstants.cs
│   └── LocalStorageKeys.cs
│
├── Layout/
│   ├── MainLayout.razor
│   ├── AuthLayout.razor
│   ├── NavMenu.razor
│   └── Theme/
│       └── AppTheme.cs
│
├── Models/
│   ├── Auth/
│   │   └── AuthModels.cs
│   ├── Budgets/
│   │   └── BudgetModels.cs
│   ├── Categories/
│   │   └── CategoryModels.cs
│   ├── Common/
│   │   └── CommonModels.cs
│   ├── Dashboard/
│   │   └── DashboardModels.cs
│   ├── PaymentMethods/
│   │   └── PaymentMethodModels.cs
│   └── Transactions/
│       └── TransactionModels.cs
│
├── Pages/
│   ├── Auth/
│   │   ├── Login.razor
│   │   ├── Register.razor
│   │   ├── ForgotPassword.razor
│   │   └── ResetPassword.razor
│   ├── Budgets/
│   │   └── Budgets.razor
│   ├── Categories/
│   │   └── Categories.razor
│   ├── Dashboard/
│   │   └── Index.razor
│   ├── PaymentMethods/
│   │   └── PaymentMethods.razor
│   ├── Profile/
│   │   └── Profile.razor
│   ├── Settings/
│   │   └── Settings.razor
│   └── Transactions/
│       └── Transactions.razor
│
├── Services/
│   ├── Api/
│   │   ├── BaseApiService.cs
│   │   ├── AuthService.cs
│   │   ├── BudgetService.cs
│   │   ├── CategoryService.cs
│   │   ├── DashboardService.cs
│   │   ├── PaymentMethodService.cs
│   │   └── TransactionService.cs
│   ├── Authentication/
│   │   └── CustomAuthStateProvider.cs
│   ├── Navigation/
│   │   ├── MenuItem.cs
│   │   ├── MenuSection.cs
│   │   └── MenuService.cs
│   └── Storage/
│       └── LocalStorageService.cs
│
└── Shared/
    └── Components/
        ├── Auth/
        │   └── ChangePasswordDialog.razor
        ├── Budgets/
        │   ├── CreateBudgetDialog.razor
        │   └── EditBudgetDialog.razor
        ├── Categories/
        │   ├── CreateCategoryDialog.razor
        │   └── EditCategoryDialog.razor
        ├── Common/
        │   └── ConfirmDialog.razor
        ├── PaymentMethods/
        │   ├── CreatePaymentMethodDialog.razor
        │   └── EditPaymentMethodDialog.razor
        └── Transactions/
            ├── CreateTransactionDialog.razor
            └── EditTransactionDialog.razor
```

## Prerequisites

- .NET 10 SDK
- DuitTracker API running on `http://localhost:5158`

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/DuitTracker.Frontend.git
cd DuitTracker.Frontend
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Configure API URL

Open `Constants/AppConstants.cs` and make sure the API URL matches your backend:

```csharp
public const string ApiBaseUrl = "http://localhost:5158/";
```

### 4. Run the project

```bash
dotnet run
```

Frontend will be available at `http://localhost:5076`.

## Running with the API

Make sure the API is running first before starting the frontend.

```bash
# Terminal 1 — Start API
cd DuitTracker.Api
dotnet run

# Terminal 2 — Start Frontend
cd DuitTracker.Frontend
dotnet run
```

## Pages

| Page | URL | Description |
|---|---|---|
| Login | `/login` | Sign in to your account |
| Register | `/register` | Create a new account |
| Forgot Password | `/forgot-password` | Request password reset email |
| Reset Password | `/reset-password` | Reset password via token |
| Dashboard | `/dashboard` | Overview of finances |
| Transactions | `/transactions` | Manage income and expenses |
| Categories | `/categories` | Manage transaction categories |
| Budgets | `/budgets` | Set and track monthly budgets |
| Payment Methods | `/payment-methods` | Manage payment methods |
| Profile | `/profile` | View profile and change password |
| Settings | `/settings` | App preferences |

## Features

- JWT authentication with local storage
- Dark mode support (default: dark)
- Responsive layout with collapsible sidebar
- CRUD operations for all entities via dialogs
- Dashboard with income/expense chart and budget progress
- Form validation on all inputs
- Global error handling via snackbar notifications

## UI Style

- Dark mode first design
- MudBlazor component library
- Plus Jakarta Sans font
- Green primary color (`#4CAF50`)
- Card-based layout
- Dialog-based CRUD operations

## Related

- [DuitTracker API](https://github.com/yourusername/DuitTracker.Api) — ASP.NET Core Web API backend