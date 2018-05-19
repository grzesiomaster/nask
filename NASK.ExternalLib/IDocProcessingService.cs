using NASK.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NASK.ExternalLib
{
    public interface IDocProcessingService
    {
        object GetDocByApacheLucene(StoredDocument doc);
        object GetDocByTikaondotner(StoredDocument doc);
    }
}
