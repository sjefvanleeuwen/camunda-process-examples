using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace discount.Controllers
{
    public class OrderController : IDisposable
    {
        public class Setting
        {
            public Func<string, string> Format { get; set; }
        }
        static Setting uri = new Setting { Format = s => $@".\Rest\order-{s}.json" };

        public bool Exists(string orderId)
        {
            return File.Exists(uri.Format(orderId));
        }

        public double CalculateTotal(string orderId)
        {
            if (Exists(orderId))
            {
                double total = 0;
                JObject order = JObject.Parse(File.ReadAllText(uri.Format(orderId)));
                foreach (var item in order["cart"])
                {
                    total += (double)item["quantity"] * (double)item["unitPrice"];
                }
                return total;
            }
            throw new OrderNotFoundException();
        }

        public double CalculateDiscount(double total, double percentage)
        {
            return total * percentage;
        }

        public void Dispose()
        {
            // nothing to cleanup yet.
        }
    }
}