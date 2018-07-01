using System;
using Adapter;
using AggergateAndIterator;
using System.Collections.Generic;
namespace AggergateAndIterator
{
    public class Customer
    {
        public Customer()
        {
            _addresses = new List<Address>();
        }
        private List<Address> _addresses { get; set; }
        //aggergate through root
        public IEnumerable<Address> GetAddresses()
        {
            return _addresses;
        }

        public void Add(Address add)
        {

            foreach (var address in _addresses)
            {
                if (add.Type == address.Type)
                {
                    throw new Exception("Not allowed");
                }
            }
            _addresses.Add(add);
        }

    }
    public class Address
    {
        public string Type { get; set; }
    }
}
namespace Adapter
{
    public class ThirtPartyPdfReport
    {
        public void Save()
        {

        }
    }
    public interface IExport
    {
        void Export();
    }
    public class WorReport : IExport
    {
        void IExport.Export()
        {
            throw new NotImplementedException("word export not implement yet");
        }
    }
    public class ExcelReport : IExport
    {
        void IExport.Export()
        {
            throw new NotImplementedException("excel export not implemented yet");
        }
    }
    public class AdapterPdf : IExport
    {
        void IExport.Export()
        {
            var rep = new ThirtPartyPdfReport();
            rep.Save();
        }
    }
}
namespace SixDesignPatterns
{
    
    class Program
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
