
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MyAppointments.Models
{
    public class Appointment
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("DateTime")]
        [Required]
        public string DateTime { get; set; }

        [BsonElement("AppointmentWith")]
        [Required]
        public string AppointmentWith { get; set; }

        [BsonElement("Email")]
        [Required]
        public int Email { get; set; }
    }
    
}
