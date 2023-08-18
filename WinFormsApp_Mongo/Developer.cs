using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace WinFormsApp_Mongo
{
    internal class Developer : Entity
    {
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public string Language { get; set; }
        public string CodeLanguage { get; set; }

        public int Age { get; set; }

        public Developer(string name, string language, string codelang, int age)
        {
            this.Name = name;
            this.Language = language;
            this.CodeLanguage = codelang;
            this.Age = age;

            HiringDate = DateTime.Now;
        }
    }
}
