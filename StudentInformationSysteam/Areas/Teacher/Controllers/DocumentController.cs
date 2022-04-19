using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSysteam.Business.Utilities;

using StudnetInformationSysteam.Data.DAL;
using System.Threading.Tasks;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.DocumentVMs;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class DocumentController : Controller
    {
        private AppDbContext _context;
        private string _errorMessage;
       
        private IWebHostEnvironment _env { get; }

        public DocumentController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
          
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: DocumentController
        public IActionResult Upload()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload( UploadVM upload,int id,int sbjId)
        {
            if (!ModelState.IsValid) return View();
            if (!CheckFileValid(upload.File))
            {
                ModelState.AddModelError("Files", _errorMessage);
                return View();
            }
            string fileName = await upload.File.SaveFileAysnc(_env.WebRootPath, "assets/document");
            Document document = new Document { 
            FilePath = fileName,
            GroupId = id,   
            SubjectId= sbjId,
            Title=upload.Title, 
            
            };
            await _context.Documents.AddAsync(document);
           await _context.SaveChangesAsync();
            TempData["Success"] = $"{upload.Title} Aded";
            return RedirectToAction("Details","TeacherSubject", new { Id = id,sbjId=sbjId });
         
        }
        [HttpGet]
        public IActionResult DownloadFile(int id)
        {
            // Since this is just and example, I am using a local file located inside wwwroot
            // Afterwards file is converted into a stream
            var userFromSubject = _context.Documents.Where(i => i.Id == id).Select(i => i.FilePath).FirstOrDefault();

            string resultPath = Path.Combine("assets/document", userFromSubject);
            var path = Path.Combine(_env.WebRootPath, resultPath);
            var fs = new FileStream(path, FileMode.Open);

            // Return the file. A byte array can also be used instead of a stream
            return File(fs, "assets/document", userFromSubject);
        }
        private bool CheckFileValid(IFormFile file)
        {
            int size = 300;


                if (!file.CheckFileSize(size))
                {
                    _errorMessage = $"{file.FileName} size must be lest then " + $"{size}kb";
                    return false;
                }

           
            return true;
        }

        // GET: DocumentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DocumentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DocumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Delete/5
        //public IActionResult Delete(int id)
        //{
        //    var userFromSubject = _context.Documents.Where(i => i.Id == id).Select(i => i.FilePath).FirstOrDefault();
        //    var doc = _context.Documents.Where(i => i.Id == id).FirstOrDefault();

        //    string resultPath = Path.Combine("assets/document", userFromSubject);
        //    var path = Path.Combine(_env.WebRootPath, resultPath);
        //    var fs = new FileStream(path, FileMode.Open);


        //    try
        //    {

        //        if (!System.IO.File.Exists(path))
        //        {
        //            return NotFound();
        //        }
        //        System.IO.File.Delete(path);
        //        _context.Documents.Remove(doc);
        //        return View();
        //    }
        //    catch
        //    {
        //        return View();
        //    }

        //}

        // POST: DocumentController/Delete/5
      
    }
}
