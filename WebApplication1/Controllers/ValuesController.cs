using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Serialization;
using WebApplication1.Models;

namespace ContactProjUsingReact.Controllers
{
    public class ValuesController : ApiController
    {

        [Route("ParseFile")]
        [HttpPost]
        public IHttpActionResult ParseFile()
        {
            String line;
            List<Orders> order = new List<Orders>();

            string filePath1 = "C:\\Users\\jadha\\source\\repos\\FileRead\\WebApplication1\\OrderFiles\\Order1.txt";
            string filePath2 = "C:\\Users\\jadha\\source\\repos\\FileRead\\WebApplication1\\OrderFiles\\Order2.txt";
            string filePath3 = "C:\\Users\\jadha\\source\\repos\\FileRead\\WebApplication1\\OrderFiles\\Order3.txt";

            StreamReader sr = new StreamReader(filePath1);
            line = sr.ReadLine();
         
            while (line != null)
                {
                line = sr.ReadLine();
                if (line != null)
                {

                    string[] row = line.Split('|');
                    order.Add(new Orders
                    {
                        OrderNumber = Int32.Parse(row[1]),
                        OrderLineNumber = Int32.Parse(row[2]),
                        ProductNumber = row[3],
                        Quantity = Int32.Parse(row[4]),
                        Name = row[5],
                        Description = row[6],
                        Price = double.Parse(row[7]),
                        ProductGroup = row[8],
                        OrderDate = Convert.ToDateTime(row[9]),
                        CustomerName = row[10],
                        CustomerNumber = Int32.Parse(row[11])

                    });
                }
            }

            sr = new StreamReader(filePath2);
            line = sr.ReadLine();
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {

                    string[] row = line.Split('|');
                    order.Add(new Orders
                    {
                        OrderNumber = Int32.Parse(row[1]),
                        OrderLineNumber = Int32.Parse(row[2]),
                        ProductNumber = row[3],
                        Quantity = Int32.Parse(row[4]),
                        Name = row[5],
                        Description = row[6],
                        Price = double.Parse(row[7]),
                        ProductGroup = row[8],
                        OrderDate = Convert.ToDateTime(row[9]),
                        CustomerName = row[10],
                        CustomerNumber = Int32.Parse(row[11])

                    });
                }
            }

            sr = new StreamReader(filePath3);
            line = sr.ReadLine();
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {

                    string[] row = line.Split('|');
                    order.Add(new Orders
                    {
                        OrderNumber = Int32.Parse(row[1]),
                        OrderLineNumber = Int32.Parse(row[2]),
                        ProductNumber = row[3],
                        Quantity = Int32.Parse(row[4]),
                        Name = row[5],
                        Description = row[6],
                        Price = double.Parse(row[7]),
                        ProductGroup = row[8],
                        OrderDate = Convert.ToDateTime(row[9]),
                        CustomerName = row[10],
                        CustomerNumber = Int32.Parse(row[11])

                    });
                }
            }

            sr.Close();


            string xmlPath= "C:\\Users\\jadha\\source\\repos\\FileRead\\WebApplication1\\OrderFiles\\AllOrderdetails.xml";
            XmlSerializer serial = new XmlSerializer(order.GetType());
            StreamWriter sw = new StreamWriter(xmlPath);
            serial.Serialize(sw, order);
            sw.Close();

            return Ok();

        }


    }
}
