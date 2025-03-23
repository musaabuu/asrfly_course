using Microsoft.Identity.Client.Kerberos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Core {
    public class Outcome {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public DateTime OutcomeDate { get; set; }
        public string ReceiveNumber { get; set; }
        public Double Amount { get; set; }
        public string Details { get; set; }

        // Navigation 

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public int SupplierId { get; set; }
        public Suppliers Suppliers { get; set; }
        public int ProjectId { get; set; }
        public Projects Projects { get; set; }
    }
}
