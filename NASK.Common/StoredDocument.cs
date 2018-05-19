using System;
using System.Collections.Generic;
using System.Text;

namespace NASK.Common
{
    public class StoredDocument
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public byte[] FileData { get; set; }
        public string MimeType { get; set; }
    }
}
