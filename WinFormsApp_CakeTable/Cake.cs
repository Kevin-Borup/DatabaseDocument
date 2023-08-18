using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CakeTable
{
    public class Cake
    {
        public BsonObjectId Id { get; set; }
        public string Name { get; private set; }
        public TimeSpan Time { get; private set; }
        public string Description { get; private set; }
        public string[] Ingredients { get; private set; }
        public Cake(string name, int minutes, string description, string[] ingredients)
        {
            this.Name = name;
            this.Time = TimeSpan.FromMinutes(minutes);
            this.Description = description;
            this.Ingredients = ingredients;
        }

        public void UpdateDescription (string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }
        }

    }
}
