using Sperience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SperienceWeb.Models
{
    public class HomeModel
    {
        public Stage StagesModel { get; set; }
        public List<SubjectHeader> SubjectsModel { get; set; }
    }
}