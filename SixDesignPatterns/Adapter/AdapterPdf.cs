namespace Adapter
{
    public class AdapterPdf : IExport
    {
        void IExport.Export()
        {
            var rep = new ThirtPartyPdfReport();
            rep.Save();
        }
    }
}
