using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NASK.Common;
using NASK.Domain;
using NASK.Web.Models;

namespace NASK.Web.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IDocService _service;
       
        public DocumentController(IDocService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StoredDocument doc)
        {
            if (ModelState.IsValid)
            {
                int inx = _service.StoreDocument(doc);
                if (inx > 0 )
                {
                    return RedirectToAction("Details", inx);
                }
            }
            return View(doc);
        }

        public ActionResult Details(int? id)
        {
            if( id.HasValue )
            {
                var obj =  _service.GetSepcyfiedDocumentById(id.Value);
                return View(obj); //TODO 
            }
            return RedirectToAction("Index");
        }

        public ActionResult SearchDocuments()
        {
            return View();
        }

        //SOMETHING LIKE THAT:
        /*[HttpPost]
        public ActionResult SearchDocuments([Bind(Include = "someParam x y z")] SearchOptionsViewModel options)
        {
            int pageCount;
            var x = options.x;
            var y = options.y;
            var z = options.z;

                [...]

            PageViewModel page = _service.GetListDocByApacheLucene(x, y, z, 1, id, out pageCount);
        
            return RedirectToAction("Page",1);
        }*/


        public ActionResult Page(int? id)
        {
            int pageCount;
            IEnumerable<object> returnlist = _service.GetListDocByApacheLucene(10, 5, 10, 1, id, out pageCount);
            PageViewModel page = new PageViewModel { list = returnlist, currentPage = id.Value, pageCount = pageCount };
            return View(page);
        }

    }
}