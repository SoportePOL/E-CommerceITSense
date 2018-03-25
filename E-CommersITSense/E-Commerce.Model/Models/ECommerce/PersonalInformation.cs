using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class PersonalInformation
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string person_mothers_name { get; set; }
        public DateTime birthdate { get; set; }
        public string birthplace { get; set; }
        public string taxpayer_number { get; set; }

        public string company_name { get; set; }
        public string company_main_activity { get; set; }
        public string company_type { get; set; }
        public DateTime company_establishment_date { get; set; }
        public CompanyRep company_rep { get; set; }
        public Identification identification { get; set; }
        public Phone phone { get; set; }
        public Address address { get; set; }

    }
}
