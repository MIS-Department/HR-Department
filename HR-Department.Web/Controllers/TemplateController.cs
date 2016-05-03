using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HR_Department.Models.Tables;
using OG_MFTG.DataLayer.Repositories;

namespace HR_Department.Web.Controllers
{
    public class TemplateController : Controller
    {
        private TemplateRepository _templateRepository;
        // GET: Template
        public async Task<ActionResult> Index()
        {
            _templateRepository = new TemplateRepository();
            var templateList = await _templateRepository.SelectAll();
            return View(templateList.ToList());
        }

        // GET: Template/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Template/Create
        public async Task<ActionResult> Create()
        {
           _templateRepository = new TemplateRepository();
            var templateLIst = await _templateRepository.SelectAll();

            return View();
        }

        // POST: Template/Create
        [HttpPost]
        public async Task<ActionResult> Create(Template model)
        {
            try
            {
                // TODO: Add insert logic here

                _templateRepository = new TemplateRepository();
                var templateList = await _templateRepository.Insert(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Template/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Template/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Template/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Template/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
