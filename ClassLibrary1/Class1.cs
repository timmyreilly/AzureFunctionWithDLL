using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void CallEbay()
        {
            var client = (eBayServiceReference1.ProductServicePortTypeClient)null;  
            try
            {
                Console.Write("in call ebay"); 
                client = new eBayServiceReference1.ProductServicePortTypeClient();
                var productRequest = new eBayServiceReference1.AddProductsRequest();

                client.addProducts(productRequest);
            }
            finally
            {
                client?.Close(); 
            }
        }
    }
}
