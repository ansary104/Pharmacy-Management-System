using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystemPT0.DTO_Class
{
    class TransactionDTO
    {
        private float revenue, expense, profit;
        private string date;

        public TransactionDTO(string date, float revenue, float expense, float profit)
        {
            this.revenue = revenue;
            this.expense = expense;
            this.profit = profit;
            this.date = date;
        }

        public float REVENUE
        {
            get { return revenue; }
            set { revenue = value; }
        }


        public float EXPENSE
        {
            get { return expense; }
            set { expense = value; }
        }


        public float PROFIT
        {
            get { return profit; }
            set { profit = value; }
        }


        public string DATE
        {
            get { return date; }
            set { date = value; }
        }
    }
}
