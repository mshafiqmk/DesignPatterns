using System;

namespace Adapter
{
    public class ExcelReport : IExport
    {
        void IExport.Export()
        {
            throw new NotImplementedException("excel export not implemented yet");
        }
    }
}
