using Sperience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SperienceWeb.Models
{
    public class StageModel
    {
        public Stage StagesModel { get; set; }
        public List<SubjectHeader> SubjectsModel { get; set; }
    }
    public class AccountsModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public Decimal RevenueEstimate { get; set; }
        public int BudgetaryAllocationId { get; set; }
    }
}