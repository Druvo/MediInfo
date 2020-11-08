using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MediInfo.Service.Appointments
{
    public class AppointmentService : IAppointmentService
    {
        private readonly DBcontext _dbContext;
        public AppointmentService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Appointment> GetAllAppointments()
        { 
            var allappointment = from c in _dbContext.Appointment select c;
            return allappointment;
        }

        public void Insert(Appointment appointment)
        {
            _dbContext.Appointment.Add(appointment);
            _dbContext.SaveChanges();
        }

        public void Update(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}