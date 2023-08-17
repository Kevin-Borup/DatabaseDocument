using MongoDB.Driver;
using MongoDB.Bson;

namespace WinFormsApp_Mongo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var collection = client.GetDatabase("devDB").GetCollection<Developer>("Development");

            collection.InsertOne(new Developer("Kevin", "Danish", "C#", 23));

            var filter = Builders<Developer>.Filter.Eq("Name", "Kevin");
            var devs = collection.Find(filter).ToList();

            this.dataGridView1.DataSource = devs;
        }
    }
}