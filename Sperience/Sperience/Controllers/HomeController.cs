using Sperience;
using SperienceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SperienceWeb.Controllers
{
    public class HomeController : Controller
    {
        SperienceEntities db = new SperienceEntities();
        HomeModel viewModel = new HomeModel();
        
        // GET: Home
        public ActionResult Index()
        {
            List<HomeModel> result = new List<HomeModel>();
            IEnumerable<Stage> queryStages = db.Database.SqlQuery<Stage>("SELECT * FROM crm.Stage");
            List<Stage> stageResult = queryStages.ToList();
            foreach (var stage in stageResult)
            {
                IEnumerable<SubjectHeader> subjectResult = db.Database.SqlQuery<SubjectHeader>("SELECT * FROM crm.SubjectHeader WHERE StageId = " + stage.Id + "");
                result.Add(new HomeModel() { StagesModel = stage, SubjectsModel = subjectResult.ToList() });
            }
            ViewBag.result = result.ToList();
            return View();
        }
    }
}