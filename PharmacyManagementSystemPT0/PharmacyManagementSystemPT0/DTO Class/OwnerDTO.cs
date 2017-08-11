using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0
{
    class OwnerDTO
    {
        private int ownerid;
        private string ownername, ownerpassword;

        public OwnerDTO(int ownerid, string ownername, string ownerpassword)
        {
            this.ownerid = ownerid;
            this.ownername = ownername;
            this.ownerpassword = ownerpassword;
        }

        public int OwnerID
        {
            get { return ownerid; }
            set { ownerid = value; }
        }

        public string OwnerNAME
        {
            get { return ownername; }
            set { ownername = value; }
        }

        public string OwnerPASSWORD
        {
            get { return ownerpassword; }
            set { ownerpassword = value; }
        }


    }




}
