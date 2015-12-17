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
        
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<AccountsModel> accounts = db.Database.SqlQuery<AccountsModel>("SELECT SubjectHeader.Id, Customer.CustomerName, SubjectHeader.RevenueEstimate, SubjectHeader.BudgetaryAllocationId FROM crm.SubjectHeader JOIN dbo.Customer ON SubjectHeader.AccountId = Customer.Id");

            List<StageModel> result = new List<StageModel>();
            IEnumerable<Stage> queryStages = db.Database.SqlQuery<Stage>("SELECT * FROM crm.Stage");
            List<Stage> stageResult = queryStages.ToList();
            foreach (var stage in stageResult)
            {
                IEnumerable<SubjectHeader> subjectResult = db.Database.SqlQuery<SubjectHeader>("SELECT * FROM crm.SubjectHeader WHERE StageId = " + stage.Id + "");
                result.Add(new StageModel() { StagesModel = stage, SubjectsModel = subjectResult.ToList() });
            }
            ViewBag.result = result.ToList();
            ViewBag.accounts = accounts.ToList();
            return View();
        }
    }
}