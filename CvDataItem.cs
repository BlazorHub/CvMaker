using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
namespace CvMaker
{
    public class CvDataItem
    {
        public class LifeHistory
        {
            public string Name { get; set; } 
            public DateTime From { get; set; }
            public DateTime To { get; set; }
            public string Description { get; set; }

            public LifeHistory(string inName, DateTime inFrom, DateTime inTo, string inDescription)
            {
                Name = inName;
                From = inFrom;
                To = inTo;
                Description = inDescription;
            }
            public LifeHistory() { }
        }

        public class Education : LifeHistory 
        {
            public string Degree { get; set; }
            public Education(string inName, DateTime inFrom, DateTime inTo, string inDescription, string inDegree) : base(inName,inFrom,inTo,inDescription)
            {
                Degree = inDegree;
            }
            public Education() { Name = ""; From = DateTime.Today; To = DateTime.Today; Description = ""; }
        }

        public class Experience : LifeHistory {
            public Experience(string inName, DateTime inFrom, DateTime inTo, string inDescription) : base(inName, inFrom, inTo, inDescription) {}
            public Experience() { Name = ""; From = DateTime.Today; To = DateTime.Today; Description = ""; }
        }

        public class Skill
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public class Language : Skill { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Language> Languages { get; set; }
    }
}
