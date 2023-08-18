using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WinFormsApp_CakeTable
{
    internal class DocDatabase
    {
        MongoClient client = new MongoClient(Properties.Resources.ResourceManager.GetString("ConnectionString"));
        IMongoCollection<Cake> cakesTable;

        public DocDatabase()
        {
            cakesTable = client.GetDatabase("CakeTableDB").GetCollection<Cake>("Cakes");
        }

        public  void InsertCakes(Cake[] cakes)
        {
            cakesTable.InsertMany(cakes);
        }

        public void InsertCake(Cake cake)
        {
            cakesTable.InsertOne(cake);
        }

        public Cake[] GetAllCakes()
        {
            return cakesTable.Find(Builders<Cake>.Filter.Empty).ToList().ToArray();
        }

        public  void DeleteCake(Cake cake)
        {
            var deleteFilter = Builders<Cake>.Filter.Eq(cake.Id.ToString(), cake.Id);

            cakesTable.DeleteOne(deleteFilter);
        }

        public void ClearCakeTable()
        {
            cakesTable.DeleteMany(Builders<Cake>.Filter.Empty);
        }
    }
}
