using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Incident : Model
    {
        public enum IncidentPriority
        {
            Low,
            Medium,
            High
        }

        public enum IncidentType
        {
            Service_Request,
            Fault,
            Technical_Incident,
            Assistance_Request
        }

        public enum IncidentStatus
        {
            Resolved,
            Unresolved
        }


        protected override string PrimaryKey => null;

        protected override string CollectionName => "Incidents";

        public override ObjectId Id { get => id; set => id = value; }

        public Incident() { }
        public Incident(ObjectId id) 
        {
            Incident incident = GetByObjectId<Incident>(id);
        }

        public Incident(DateTime createdAt, string subject, IncidentType type, User reportedBy, IncidentPriority priority, DateTime deadline, string description,IncidentStatus status)
        {
            this.createdAt = createdAt;
            this.subject = subject;
            this.type = type;
            this.reportedBy = reportedBy;
            this.priority = priority;
            this.deadline = deadline;
            this.description = description;
        }

        public DateTime createdAt;
        public string subject;
        public IncidentType type;
        public User reportedBy;
        public IncidentPriority priority;
        public DateTime deadline;
        public string description;
        private ObjectId id;
        public IncidentStatus status;

        public static List<Incident> getAll()
        {
            return getAll<Incident>("Incidents");
        }

        public override dynamic deserialize(BsonDocument document)
        {
            return BsonSerializer.Deserialize<Incident>(document);
        }

        public static void GenerateRandom()
        {
            Random rand = new Random(); // we need a random variable to select names randomly

            RandomName nameGen = new RandomName(rand); // create a new instance of the RandomName class

            Array incidentTypes = Enum.GetValues(typeof(IncidentType));
            Array pritorty = Enum.GetValues(typeof(IncidentPriority));

            List<string> names = nameGen.RandomNames(100, 0);
            for (int i = 0; i < 100; i++)
            {
                var createdAt = RandomDay(rand);
                Incident incident = new Incident()
                {
                    subject = "",
                    type = (IncidentType)incidentTypes.GetValue(rand.Next(incidentTypes.Length)),
                    reportedBy = new User(rand.Next(100).ToString()),
                    priority = (IncidentPriority)pritorty.GetValue(rand.Next(pritorty.Length)),
                    createdAt = createdAt,
                    deadline = RandomDay(createdAt, rand),
                    description = "",
                };

                incident.insertIntoCollection();
            }
        }

        private static DateTime RandomDay(Random rand)
        {
            DateTime start = new DateTime(2020, 1, 25);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }

        private static DateTime RandomDay(DateTime start, Random rand)
        {
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }
    }


}
