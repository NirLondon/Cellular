using Invoices.Common.Models;

namespace Invoices.BL
{
    interface IInvoiceFileProducer
    {
        byte[] ProduceFile(SingeLineInvoice[] lineInvoices);
    }
}