using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp_CakeTable
{
    internal class CakeManager
    {
        private DocDatabase DBDoc = new DocDatabase();

        public CakeManager()
        {

        }

        public Cake GetSingleCake(Cake cake)
        {
            return DBDoc.GetSingleCake(cake);
        }

        public void InsertCake(Cake cake)
        {
            if (cake.Id is null)
            {
                DBDoc.InsertCake(cake);
            }
            else
            {
                DBDoc.UpsertCake(cake);
            }
        }

        public void RemoveCake(Cake cake)
        {
            DBDoc.DeleteCake(cake);
        }

        public List<Cake> GetAllCakes(string[] sortSearch)
        {
            bool sort = sortSearch[0].Equals("Sub30");
            bool search = !string.IsNullOrWhiteSpace(sortSearch[1]);

            if (!search && !sort)
                return DBDoc.GetCakes();
            else if (search && sort)
            {
                return DBDoc.GetCakes(search, sort, sortSearch[1], 30);
            }
            else if (search)
            {
                return DBDoc.GetCakes(search, name: sortSearch[1]);
            }
            else //if (sort)
            {
                return DBDoc.GetCakes(timeSort: sort, minutes: 30);
            }
        }

        public void CreateInsertCakes()
        {
            Cake[] cakes = new Cake[]
            {
                new Cake("Brunsviger", 30, "En blød gærdej med en topping af brun farin og smør.", new string[] { "Gær", "Mel", "Farin", "Smør" }),
                new Cake("Hindbærsnitter", 20, "To lag mørdej med hindbærsyltetøj i midten og glasur ovenpå.", new string[] { "Gær", "Mel", "Hindbær", "Sukker" }),
                new Cake("Kiksekage", 40, "En kold kage lavet af smør, chokolade og knuste kiks.", new string[] { "Chokolade", "Smør", "Kiks" }),
                new Cake("Gåsebryst", 15, "En flødeskumskage med mørk chokoladeovertræk.", new string[] { "Mælk", "Smør", "Chokolade" }),
                new Cake("Fedtebrød", 45, "En småkage med sukker og mandler ovenpå.", new string[] { "Sukker", "Smør", "Mel", "Mandler" }),
                new Cake("Krydderkage", 35, "En småkage med sukker og mandler ovenpå.", new string[] { "Mel", "Smør", "Rosiner", "Mandler" }),
                new Cake("Napoleonskage", 45, "En lagkage bestående af flaky dej, flødeskum, syltetøj og glasur.", new string[] { "Mel", "Smør", "Flødeskum", "Syltetøj", "Sukker" }),
                new Cake("Kanelstang", 30, "Gærdej fyldt med remonce og kanelsukker, toppet med glasur.", new string[] { "Smør", "Gær", "Kanel", "Sukker", "Flormelis" }),
                new Cake("Sandkage", 20, "En simpel, men lækker kage lavet med masser af smør.", new string[] { "Smør", "Gær", "Sukker" }),
                new Cake("Mazarinkage", 20, "En tæt kage lavet med mandelessens og ofte overtrukket med chokolade.", new string[] { "Smør", "Gær", "Sukker", "Chokolade", "Mandler" }),
            };

            DBDoc.InsertCakes(cakes);
        }

        public void ClearCakeTable()
        {
            DBDoc.ClearCakeTable();
        }


    }
}
