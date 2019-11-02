using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhucWeblog.Collections
{
    public class Document
    {
        private string _id;
        private string id;
        private string documentId;
        private string doctypeId;

        public string Id { get => id; set => id = value; }
        public string DocumentId { get => documentId; set => documentId = value; }
        public string DoctypeId { get => doctypeId; set => doctypeId = value; }
    }
}
