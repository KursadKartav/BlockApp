using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogrepository;
        private ICategoryRepository _categoryrepository;
        public BlogController(IBlogRepository blogRepo,ICategoryRepository categoryRepo)
        {
            _blogrepository = blogRepo;
            _categoryrepository = categoryRepo;
        }
        public IActionResult Details(int id)
        {
            return View(_blogrepository.GetById(id));
        }
        public IActionResult Index(int? id,string q)
        {
            var query = _blogrepository.GetAll().Where(i => i.IsApproved); /*.OrderByDescending(i => i.Date);*/
            if (id != null)
            {
                query = query.Where(i => i.CategoryId == id); /*.OrderByDescending(i => i.Date);*/
            }

            if (!string.IsNullOrEmpty(q))
            {
                //query = query.Where(i => i.Title.Contains(q) || i.Description.Contains(q) || i.Body.Contains(q));
                query = query.Where(i =>EF.Functions.Like(i.Title, "%"+q+"%") || EF.Functions.Like(i.Description, "%" + q + "%") || EF.Functions.Like(i.Body, "%" + q + "%"));
            }

            return View(query.OrderByDescending(i => i.Date));
        }
        public IActionResult List()
        {
            return View(_blogrepository.GetAll());
        }
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");

        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Blog entity)
        //{
        //    entity.Date = DateTime.Now;
        //    if(ModelState.IsValid)
        //    {
        //        _blogrepository.AddBlog(entity);
        //        return RedirectToAction("List");
        //    }
        //    //Create işlemi
        //    ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");
        //    return View(_blogrepository.GetById(id));
        //}
        //[HttpPost]
        //public IActionResult Edit(Blog entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _blogrepository.UpdateBlog(entity);
        //        TempData["message"] = $"{entity.Title} güncellendi";
        //        return RedirectToAction("List");
        //    }
        //    ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");
        //    return View(entity);
        //}
        [HttpGet]
        public ActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");
            if (id==null)
            {
                //yeni bir kayıt
                return View(new Blog());
            }
            else
            {
                //güncelleme
                return View(_blogrepository.GetById((int)id));
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogrepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} kayıt edildi.";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryrepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_blogrepository.GetById(id));
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int BlogId)
        {
            _blogrepository.DeleteBlog(BlogId);
            TempData["message"] = $"{BlogId} numaralı kayıt silindi.";
            return RedirectToAction("List");
        }
    }
}