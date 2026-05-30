namespace DuitTracker.Frontend.Constants;

public static class ApiRoutes
{
    private const string Base = "api";

    public static class Auth
    {
        private const string Prefix = $"{Base}/auth";
        public const string Register = $"{Prefix}/register";
        public const string Login = $"{Prefix}/login";
        public const string ForgotPassword = $"{Prefix}/forgot-password";
        public const string ResetPassword = $"{Prefix}/reset-password";
        public const string ChangePassword = $"{Prefix}/change-password";
    }

    public static class Categories
    {
        private const string Prefix = $"{Base}/categories";
        public const string GetAll = Prefix;
        public const string Create = Prefix;
        public static string GetById(Guid id) => $"{Prefix}/{id}";
        public static string Edit(Guid id) => $"{Prefix}/{id}";
        public static string Delete(Guid id) => $"{Prefix}/{id}";
    }

    public static class Transactions
    {
        private const string Prefix = $"{Base}/transactions";
        public const string GetAll = Prefix;
        public const string Create = Prefix;
        public static string GetById(Guid id) => $"{Prefix}/{id}";
        public static string Edit(Guid id) => $"{Prefix}/{id}";
        public static string Delete(Guid id) => $"{Prefix}/{id}";
    }

    public static class PaymentMethods
    {
        private const string Prefix = $"{Base}/paymentmethods";
        public const string GetAll = Prefix;
        public const string Create = Prefix;
        public static string GetById(Guid id) => $"{Prefix}/{id}";
        public static string Edit(Guid id) => $"{Prefix}/{id}";
        public static string Delete(Guid id) => $"{Prefix}/{id}";
    }

    public static class Budgets
    {
        private const string Prefix = $"{Base}/budgets";
        public const string GetAll = Prefix;
        public const string Create = Prefix;
        public static string GetById(Guid id) => $"{Prefix}/{id}";
        public static string Edit(Guid id) => $"{Prefix}/{id}";
        public static string Delete(Guid id) => $"{Prefix}/{id}";
    }

    public static class Dashboard
    {
        private const string Prefix = $"{Base}/dashboard";
        public const string GetSummary = Prefix;
        public static string GetSummaryByYear(int year) => $"{Prefix}?year={year}";
    }
}