using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SalesOrderDetails
    {
        private int _salesOrderId;

        public int salesOrderId
        {
            get { return _salesOrderId; }
            set { _salesOrderId = value; }
        }

        private int _productId;

        public int productId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        private string _productName;

        public string productName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private int _qty;

        public int qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
    }
}
