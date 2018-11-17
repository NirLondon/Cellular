using Invoices.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.BL
{
    class InvoicesDocumeter
    {
        IInvoiceFileProducer fileProducer;

        public void StoreInvoice(SingeLineInvoice[] lineInvoices)
        {
            byte[] data = fileProducer.ProduceFile(lineInvoices);

            //TODO: store on a directory
        }

        public void PostToCRM()
        {

        }
    }
}
