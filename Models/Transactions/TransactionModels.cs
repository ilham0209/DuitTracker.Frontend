namespace DuitTracker.Frontend.Models.Transactions;

public class TransactionResponse
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryIcon { get; set; } = string.Empty;
    public string CategoryColor { get; set; } = string.Empty;
    public string CategoryType { get; set; } = string.Empty;
    public Guid PaymentMethodId { get; set; }
    public string PaymentMethodName { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime TransactionDate { get; set; }
    public string ReferenceNo { get; set; } = string.Empty;
    public string AttachmentUrl { get; set; } = string.Empty;
}

public class CreateTransactionRequest
{
    public Guid CategoryId { get; set; }
    public Guid PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    public string ReferenceNo { get; set; } = string.Empty;
    public string AttachmentUrl { get; set; } = string.Empty;
}

public class EditTransactionRequest
{
    public Guid CategoryId { get; set; }
    public Guid PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime TransactionDate { get; set; }
    public string ReferenceNo { get; set; } = string.Empty;
    public string AttachmentUrl { get; set; } = string.Empty;
}