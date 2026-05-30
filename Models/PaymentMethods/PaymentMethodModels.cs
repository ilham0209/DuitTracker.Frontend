namespace DuitTracker.Frontend.Models.PaymentMethods;

public class PaymentMethodResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class CreatePaymentMethodRequest
{
    public string Name { get; set; } = string.Empty;
}

public class EditPaymentMethodRequest
{
    public string Name { get; set; } = string.Empty;
}