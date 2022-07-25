using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CharpFundamentals.Collections
{
    class LinqToXml
    {
        public void readLinqToXML()
        {
            // Load the XML file from our project directory containing the purchase orders
            var filename = "PurchaseOrder.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var purchaseOrderFilepath = Path.Combine(currentDirectory, filename);

            XElement purchaseOrder = XElement.Load(purchaseOrderFilepath);

            IEnumerable<string> partNos = from item in purchaseOrder.Descendants("Item")
                                          select (string)item.Attribute("PartNumber");
            //Using lambda expression
            IEnumerable<string> partNosLambda = purchaseOrder.Descendants("Item").Select(x => (string)x.Attribute("PartNumber"));

            IEnumerable<string> price = from item in purchaseOrder.Descendants("Item")
                                        where (int)item.Element("Quantity") * (decimal)item.Element("USPrice") > 100
                                        select (string)item.Attribute("PartNumber");
            //Using lambda expression
            IEnumerable<string> pricelambda = purchaseOrder.Descendants("Item").
                                             Where(x1 => ((int)x1.Element("Quantity") * (decimal)x1.Element("USPrice")) > 100).Select(x => (string)x.Attribute("PartNumber"));

            IEnumerable<XElement> fullXML = from item in purchaseOrder.Descendants("Item")
                                            where (int)item.Element("Quantity") * (decimal)item.Element("USPrice") > 10
                                            orderby (string)item.Attribute("PartNumber")
                                            select item;

            //Using lambda expression
            IEnumerable<XElement> fullxmllambda = purchaseOrder.Descendants("Item")
                                                  .Where(x => (int)x.Element("Quantity") * (decimal)x.Element("USPrice") > 10)
                                                  .OrderBy(x1 => (string)x1.Attribute("PartNumber"));
        }
    }
}
