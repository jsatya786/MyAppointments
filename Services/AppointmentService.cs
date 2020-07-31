using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MyAppointments.Models;

namespace MyAppointments.Services
{
    public class AppointmentService
    {
        private readonly IMongoCollection<Appointment> _Appointment;

        public AppointmentService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("AppointmentsDb"));
            IMongoDatabase database = client.GetDatabase("AppointmentsDb");
            _Appointment = database.GetCollection<Appointment>("Appointment");
        }

        public List<Appointment> Get()
        {
            return _Appointment.Find(app => true).ToList();
        }

        public Appointment Get(string id)
        {
            return _Appointment.Find(app => app.Id == id).FirstOrDefault();
        }

        public Appointment Create(Appointment app)
        {
            _Appointment.InsertOne(app);
            return app;
        }

        public void Update(string id, Appointment app)
        {
            _Appointment.ReplaceOne(app => app.Id == id, app);
        }

        public void Remove(Appointment app)
        {
            _Appointment.DeleteOne(app => app.Id == app.Id);
        }

        public void Remove(string id)
        {
            _Appointment.DeleteOne(app => app.Id == id);
        }
    }
}
