using System;
using Adapter;
using AggergateAndIterator;

namespace SixDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region AggergateAndIteratorUse

            var customer = new Customer();
            try
            {
                customer.Add(new Address() { Type = "o" });
                customer.Add(new Address() { Type = "h" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+" "+e.StackTrace);
            }
            foreach (var item in customer.GetAddresses())
            {
                Console.WriteLine(item.Type);
            }
            Console.Read();

            #endregion

            #region AdapterPatternUse
            IExport rep = new WorReport();
            rep.Export();

            rep = new ExcelReport();
            rep.Export();

            rep = new AdapterPdf();
            rep.Export();


            #endregion
        }
    }
}
