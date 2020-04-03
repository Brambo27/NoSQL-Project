using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Incident : Model
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

        public override string primaryKey => null;

        public override string CollectionName => "Incidents";

        public override ObjectId Id { get => id; set => id = value; }

        public Incident() { }
        public Incident(ObjectId id) 
        {
            Incident incident = GetByObjectId<Incident>(id);
        }

        public Incident(DateTime createdAt, string subject, IncidentType type, User reportedBy, IncidentPriority priority, DateTime deadline, string description)
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

        public static List<Incident> getAll()
        {
            return getAll<Incident>("Incidents");
        }

        public override dynamic deserialize(BsonDocument document)
        {
            return BsonSerializer.Deserialize<Incident>(document);
        }
    }


}
