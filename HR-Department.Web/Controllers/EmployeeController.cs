using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using OG_MFTG.DataLayer.Repositories;
using PagedList;

namespace HR_Department.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository;

        // GET: Employee
        public async Task<ActionResult> Index(string searchString, string currentFilter, int? page)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            _employeeRepository = new EmployeeRepository();
            var employeeLst = await _employeeRepository.SelectAll();

            if (!string.IsNullOrEmpty(searchString))
            {
                employeeLst =
                    employeeLst.ToList()
                        .Where(
                            s =>
                                s.LastName.ToLower().Contains(searchString.ToLower()) ||
                                s.FirstName.ToLower().Contains(searchString.ToLower()));
            }
            const int pageSize = 10;
            var pagenumber = (page ?? 1);

            return View(employeeLst.ToPagedList(pagenumber, pageSize));
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
