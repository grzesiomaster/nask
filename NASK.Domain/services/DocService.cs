using NASK.Common;
using NASK.ExternalLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace NASK.Domain
{
    public class DocService : IDocService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IDocProcessingService _docProcesor;

        public DocService(ApplicationDbContext dbcontext, IDocProcessingService docProcessing)
        {
            _docProcesor = docProcessing;
            _dbContext = dbcontext;
        }

        public object GetSepcyfiedDocumentById(int index)
        {
            var doc = GetDocumentById(index);

            if( doc.MimeType == "HTML" )
            {
                return _docProcesor.GetDocByApacheLucene(doc);
            }
            else
            {
                return _docProcesor.GetDocByTikaondotner(doc);
            }
        }

        public int StoreDocument(StoredDocument doc)
        {
            _dbContext.Documents.Add(doc);
            _dbContext.SaveChanges();
            return _dbContext.Documents.Find(doc).Id;
        }

        public StoredDocument GetDocumentById(int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetListDocByApacheLucene(int titleWage, int descriptionWage, int authorWage, int contentWage, int? currentPage, out int pageCount)
        {
            throw new NotImplementedException();
        }

        public object GetSepcyfiedDocument(StoredDocument doc)
        {
            throw new NotImplementedException();
        }


    }
}
