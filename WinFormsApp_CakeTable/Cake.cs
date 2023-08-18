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
        public int Time { get; private set; }
        public string Description { get; private set; }
        public string[] Ingredients { get; private set; }
        public Cake(string name, int minutes, string description, string[] ingredients)
        {
            this.Name = name;
            this.Time = minutes;
            this.Description = description;
            this.Ingredients = ingredients;
        }

        public void UpdateCake (string name, int minutes, string description, string[] ingredients)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }

            if (!minutes.Equals(null))
            {
                Time = minutes;
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }

            if (ingredients.Any())
            {
                Ingredients = ingredients;
            }
        }

    }
}
