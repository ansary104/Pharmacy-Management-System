using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0.DTO_Class
{
    class BillDTO
    {
        private int billid;
        private string medicinename, medicinename1, medicinename2;
        private int quantity, quantity1, quantity2;
        private float price, price1, price2;
        private float totalamount, amount, amount1, amount2;


        public int BILLID
        {
            get { return billid; }
            set { billid = value; }
        }

        public string MEDICINENAME
        {
            get { return medicinename; }
            set { medicinename = value; }
        }

        public int QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public float AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }

        public string MEDICINENAME1
        {
            get { return medicinename1; }
            set { medicinename1 = value; }
        }

        public int QUANTITY1
        {
            get { return quantity1; }
            set { quantity1 = value; }
        }

        public float AMOUNT1
        {
            get { return amount1; }
            set { amount1 = value; }
        }

        public float PRICE1
        {
            get { return price1; }
            set { price1 = value; }
        }


        public string MEDICINENAME2
        {
            get { return medicinename2; }
            set { medicinename2 = value; }
        }

        public int QUANTITY2
        {
            get { return quantity2; }
            set { quantity2 = value; }
        }

        public float PRICE2
        {
            get { return price2; }
            set { price2 = value; }
        }

        public float AMOUNT2
        {
            get { return amount2; }
            set { amount2 = value; }
        }

        public float TOTALAMOUNT
        {
            get { return totalamount; }
            set { totalamount = value; }
        }

    }
}
