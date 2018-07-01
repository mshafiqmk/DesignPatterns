using System;

namespace Adapter
{
    public class WorReport : IExport
    {
        void IExport.Export()
        {
            throw new NotImplementedException("word export not implement yet");
        }
    }
}
