using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0
{
    class SalesmanDTO
    {
        private int salesmanid;
        private string salesmanname, salesmanpassword, salesmanaddress;

        public SalesmanDTO(int salesmanid, string salesmanname, string salesmanpassword, string salesmanaddress)
        {
            this.salesmanid = salesmanid;
            this.salesmanname = salesmanname;
            this.salesmanpassword = salesmanpassword;
            this.salesmanaddress = salesmanaddress;
        }

        public int SalesmanID
        {
            get { return salesmanid; }
            set { salesmanid = value; }
        }

        public string SalesmanNAME
        {
            get { return salesmanname; }
            set { salesmanname = value; }
        }

        public string SalesmanPASSWORD
        {
            get { return salesmanpassword; }
            set { salesmanpassword = value; }
        }

        public string SalesmanADDRESS
        {
            get { return salesmanaddress; }
            set { salesmanaddress = value; }
        }


    }
}
