using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NASK.Web.Models
{
    public class PageViewModel
    {
        public IEnumerable<object> list;
        public int currentPage;
        public int pageCount;
    }
}
