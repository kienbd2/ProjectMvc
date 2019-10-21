using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
   public class TeleCustomer
    {
        public long IdTele { get; set; }

        public string NameTele { get; set; }

        public string AddressTele { get; set; }
        public string PhoneTele { get; set; }
        public string EmailTele { get; set; }
        public bool StatusTele { get; set; }

        public long ObjectId { get; set; }
        public string NameObject { get; set; }
        public string PhoneObject { get; set; }
        public string AddressObject { get; set; }
        public string EmailObject { get; set; }
        public bool StatusObject { get; set; }
        public string Description { get; set; }
    }
}
