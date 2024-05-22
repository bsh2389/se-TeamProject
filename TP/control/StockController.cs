using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP
{
    public class StockController
    {
        private StockEntity stockEntity;

        public StockController()
        {
            stockEntity = new StockEntity();
        }

        public DataTable GetStocks()
        {
            return stockEntity.GetStocks();
        }
    }
}
