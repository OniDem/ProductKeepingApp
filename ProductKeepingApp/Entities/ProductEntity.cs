using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductKeepingApp.Entities
{
    internal class ProductEntity
    {
        public int OrganizationID { get; set; }

        public string ProductBarcode { get; set; }

        public string ProductName { get; set; }

        public DateTime ProductExpirationDate { get; set; }

        public DateTime ProductManufactureDate { get; set; }
    }
}
