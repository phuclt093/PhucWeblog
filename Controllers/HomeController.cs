using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhucWeblog.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using PhucWeblog.Collections;

namespace PhucWeblog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var client = new MongoClient(
            //    "mongodb+srv://phuclt093:Admin093@cluster0-ufugp.gcp.mongodb.net/test?retryWrites=true&w=majority"
            //);
            //var database = client.GetDatabase("phuclt093_data");
            //var documents = database.GetCollection<Document>("documents");
            //var result = database.GetCollection<Document>("documents").Find(FilterDefinition<Document>.Empty).ToList();


            var client = new MongoClient("mongodb+srv://phuclt093:Admin093@cluster0-ufugp.gcp.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("phuclt093_data");
            var documents = database.GetCollection<BsonDocument>("documents").Find(Builders<BsonDocument>.Filter.Empty).ToList();
            var testStr = "";
            foreach (var doc in documents)
            {
                testStr += doc.ToJson();
            }
            ViewData["docs"] = testStr;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
