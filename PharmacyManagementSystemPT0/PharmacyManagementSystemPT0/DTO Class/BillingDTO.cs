using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0.DTO_Class
{
    class BillingDTO
    {
        private int billid, prescriptionid, salesmanid;
        private float totalamount,amount,amount1,amount2;
        private string customername, date;
        private string medicinename,medicinename1,medicinename2;
        private int quantity,quantity1,quantity2;
        private float price,price1,price2;


        public BillingDTO( int billid, int prescriptionid, int salesmanid, float totalamount, string customername, string date, string medicinename, int quantity, float price, float amount, string medicinename1, int quantity1, float price1, float amount1, string medicinename2, int quantity2, float price2, float amount2)
        {

            this.billid = billid;
            this.prescriptionid = prescriptionid;
            this.salesmanid = salesmanid;
            this.totalamount = totalamount;
            this.customername = customername;
            this.date = date;
            this.medicinename = medicinename;
            this.quantity = quantity;
            this.price = price;
            this.amount = amount;
            this.medicinename1 = medicinename1;
            this.quantity1 = quantity1;
            this.price1 = price1;
            this.amount1 = amount1;
            this.medicinename2 = medicinename2;
            this.quantity2 = quantity2;
            this.price2 = price2;
            this.amount2 = amount2;
        }


        public int BILLID
        {
            get { return billid; }
            set { billid = value; }
        }

        public int PRESCRIPTIONID
        {
            get { return prescriptionid; }
            set { prescriptionid = value; }
        }


        public int SALESMANID
        {
            get { return salesmanid; }
            set { salesmanid = value; }
        }

        public float TOTALAMOUNT
        {
            get { return totalamount; }
            set { totalamount = value; }
        }

        public string CUSTOMERNAME
        {
            get { return customername;}
            set { customername = value; }
        }

        public string DATE
        {
            get { return date; }
            set { date = value; }
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
    }

}
