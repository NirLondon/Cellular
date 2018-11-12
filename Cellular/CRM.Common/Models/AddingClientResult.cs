using Cellular.Common.DTOs;
using Cellular.CRM.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.CRM.Common.Models
{
    public class AddingClientResult
    {
        public Client AddedClient { get; }
        public bool IsSuccessfull { get; }
        public AddingClientFailureReason? FailureResult { get; }

        public AddingClientResult(Client AddedClient)
        {
            this.AddedClient = AddedClient;
            IsSuccessfull = true;
        }

        public AddingClientResult(AddingClientFailureReason FailureResult)
        {
            IsSuccessfull = false;
            this.FailureResult = FailureResult;
        }
    }
}
