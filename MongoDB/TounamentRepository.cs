using MongoDB.Driver;
using Entities;

namespace MongoDB
{
    internal class TounamentRepository
    {
        private const string? tournamentCollection = "TournamentList";
        private const string? matchCollection = "MatchList";
        private const string ConnectionString = "mongodb://localhost:27017";

        private MongoClient mongoClient; 
        private IMongoDatabase? database;
        
        public TounamentRepository()
        {
            mongoClient = new MongoClient(ConnectionString);
            database = mongoClient.GetDatabase("CricketRecords");
        }
         
        public void CreateNewTournament(Tournament newTournament)
        {
            IMongoCollection<Tournament>? collection = database?.GetCollection<Tournament>(tournamentCollection);

            collection?.InsertOne(newTournament);
        }
    }
}
