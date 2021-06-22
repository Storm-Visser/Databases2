using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DatabasesSnelheidTesten.NoSQL
{
    class NoSql
    {
		private MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
		private Stopwatch stopwatch { get; set; } = new Stopwatch();

		public Double testCreate(int amount)
		{
			Random r = new Random();
			int totalAffectedRows = amount;
			CreateDataBaseData();
			stopwatch.Start();
			for (int i = 0; i < amount; i++)
			{
				//create variables
				int genreID = r.Next(1, 31);
				string naam = "film" + i.ToString();
				string locatie = "/films/film" + i.ToString() + ".mp4";
				string omschrijving = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium.";
				TimeSpan tijdsduur = new TimeSpan(r.Next(1, 1000001));
				string resolutie = "UHD";
				//create connection
				var database = dbClient.GetDatabase("Databases2");
				var collection = database.GetCollection<BsonDocument>("Film");
				var Document = new BsonDocument { { "genreID", genreID }, { "naam", naam }, { "filmLocatie", locatie }, { "omschrijving", omschrijving }, { "tijdsDuur", tijdsduur.ToString() }, { "resolutie", resolutie } };
			}
			stopwatch.Stop();
			Console.WriteLine("Amount of affected rows: " + totalAffectedRows);
			double time = stopwatch.ElapsedMilliseconds;
			return time;
		}

		public Double testRead(int amount)
		{
			Random r = new Random();
			int totalRetrievedRows = 0;
			stopwatch.Start();
			for (int i = 0; i < amount; i++)
			{
				
			}
			stopwatch.Stop();
			Console.WriteLine("Amount of retrieved rows: " + totalRetrievedRows);
			double time = stopwatch.ElapsedMilliseconds;
			return time;
		}

		public Double testUpdate(int amount)
		{
			Random r = new Random();
			int totalAffectedRows = 0;
			stopwatch.Start();
			for (int i = 0; i < amount; i++)
			{
				
			}
			stopwatch.Stop();
			Console.WriteLine("Amount of affected rows: " + totalAffectedRows);
			double time = stopwatch.ElapsedMilliseconds;
			return time;
		}

		public Double testDelete(int amount)
		{
			int totalAffectedRows = 0;
			stopwatch.Start();
			for (int i = 0; i < amount; i++)
			{
				
			}
			stopwatch.Stop();
			Console.WriteLine("Amount of affected rows: " + totalAffectedRows);
			double time = stopwatch.ElapsedMilliseconds;
			return time;
		}

		private void CreateDataBaseData()
        {
			string omschrijving = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.";
			string[] genreNames = { "Geen specifiek genre", "Action", "Drama", "Animation | Drama | Fantasy", "Mystery", "Comedy | Mystery", "War film", "Drama | Romance", "Horror movie", "Children | Comedy | Fantasy | Musical", "Action | Adventure | Thriller", "Horror", "Fantasy", "Musical", "Adventure", "Documentary", "Comedy | Romance", "Thriller", "Animation", "Crime", "Sports film", "Detective", "Biographical film", "Psychological thriller", "Crime | Mystery | Thriller", "Action | Comedy | Romance", "Adventure | Comedy | Romance", "Sci - Fi", "Romance", "Drama | Sci - Fi]", "Extra" };
			var database = dbClient.GetDatabase("Databases2");
			var collection = database.GetCollection<BsonDocument>("Genre");
			for (int i = 0; i <= 30; i++)
			{
				var genre = new BsonDocument { { "naam", genreNames[i] }, { "omschrijving", omschrijving } };
				collection.InsertOne(genre);

			}
		}
	}
}
