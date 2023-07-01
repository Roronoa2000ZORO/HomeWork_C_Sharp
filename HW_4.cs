using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    struct Article
    {
        public int ProductCode;
        public string ProductName;
        public decimal ProductPrice;
    }

    struct Client
    {
        public int ClientCode;
        public string FullName;
        public string Address;
        public string Phone;
        public int OrderCount;
        public decimal TotalOrderAmount;
    }

    struct RequestItem
    {
        public Article Product;
        public int Quantity;
    }

    struct Request
    {
        public int OrderCode;
        public Client Client;
        public DateTime OrderDate;
        public RequestItem[] OrderedItems;

        public decimal TotalOrderAmount
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var item in OrderedItems)
                {
                    totalAmount += item.Product.ProductPrice * item.Quantity;
                }
                return totalAmount;
            }
        }
    }
    class HW_4
    {
    }
}
