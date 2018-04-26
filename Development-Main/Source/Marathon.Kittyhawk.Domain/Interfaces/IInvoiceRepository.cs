using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the invoice repository.
    /// </summary>
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Invoice GetByInvoiceHeaderKeyAndInvoiceDetailKey(int invoiceHeaderKey, int? invoiceDetailKey);
    }
}
