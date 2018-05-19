using NASK.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NASK.Domain
{
    public interface IDocService
    {
            //return stored index... if fail return 0
        int StoreDocument(StoredDocument doc); 

        StoredDocument GetDocumentById(int index);
        object GetSepcyfiedDocumentById(int index);
        object GetSepcyfiedDocument(StoredDocument doc);
        IEnumerable<object> GetListDocByApacheLucene(int titleWage, int descriptionWage, int authorWage, int contentWage, int? currentPage, out int pageCount);
    }
}
