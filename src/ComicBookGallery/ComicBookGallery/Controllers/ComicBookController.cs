using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int ?id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicbook = _comicBookRepository.GetComicBook(id.Value);//because this is a nullabe integer type
            return View(comicbook);
    }
    }
}
