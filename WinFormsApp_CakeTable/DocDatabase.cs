using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
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
        FilterDefinitionBuilder<Cake> buildFilter = Builders<Cake>.Filter;

        public DocDatabase()
        {
            cakesTable = client.GetDatabase("CakeTableDB").GetCollection<Cake>("Cakes");
        }

        public Cake GetSingleCake(Cake cake)
        {
            var deleteFilter = buildFilter.Eq(cake.Id.ToString(), cake.Id);
            return cakesTable.Find(deleteFilter).Single();
        }

        public void InsertCakes(Cake[] cakes)
        {
            cakesTable.InsertMany(cakes);
        }

        public void InsertCake(Cake cake)
        {
            cakesTable.InsertOne(cake);
        }

        public void UpsertCake(Cake cake)
        {
            var findFilter = buildFilter.Eq(cake.Id.ToString(), cake.Id);
            cakesTable.ReplaceOne(findFilter, cake);
        }

        public List<Cake> GetCakes(bool nameSearch = false, bool timeSort = false, string name = "", int minutes = 0)
        {
            if (!nameSearch && !timeSort)
                return cakesTable.Find(buildFilter.Empty).ToList();

            var queryExpr = new BsonRegularExpression(new Regex("^" + name + ".*", RegexOptions.IgnoreCase));

            var nameFilter = buildFilter.Regex("Name", queryExpr);
            var timeFilter = buildFilter.Lt("Time", minutes);

            if (nameSearch && timeSort)
                return cakesTable.Find(nameFilter & timeFilter).ToList();
            else if (nameSearch)
                return cakesTable.Find(nameFilter).ToList();
            else //if (timeSort) 
                return cakesTable.Find(timeFilter).ToList();
        }

        public void DeleteCake(Cake cake)
        {
            var idFilter = buildFilter.Eq(cake.Id.ToString(), cake.Id);
            cakesTable.DeleteOne(idFilter);
        }

        public void ClearCakeTable()
        {
            cakesTable.DeleteMany(buildFilter.Empty);
        }
    }
}
