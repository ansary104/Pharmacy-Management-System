using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0.DTO_Class
{
    class StockDTO
    {
        private int medicineid, quantity;
        private float price;
        private string medicinename, medicinetype;



        public StockDTO(int medicineid, string medicinename, float price, int quantity, string medicinetype)
        {
            this.medicineid = medicineid;
            this.medicinename = medicinename;
            this.price = price;
            this.quantity = quantity;
            this.medicinetype = medicinetype;
        }

        public int MedicineID
        {
            get { return medicineid; }
            set { medicineid = value; }
        }

        public string MedicineNAME
        {
            get { return medicinename; }
            set { medicinename = value; }
        }

        public float PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public int QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string MedicineTYPE
        {
            get { return medicinetype; }
            set { medicinetype = value; }
        }

    }
}
