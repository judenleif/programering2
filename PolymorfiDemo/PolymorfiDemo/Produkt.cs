using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfiDemo
{
    class Produkt
    {
        private int _productNumber;

        public int ProductNumber
        {
            get { return _productNumber; }
            set { _productNumber = value; }
        }

        private int _stockStatus;

        public int StockStats
        {
            get { return _stockStatus; }
            set { _stockStatus = value; }
        }



    }
}
