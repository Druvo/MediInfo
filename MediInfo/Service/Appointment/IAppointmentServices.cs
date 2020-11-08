using MediInfo.Models;
using System.Collections.Generic;
using System.Linq;

namespace MediInfo.Service.Appointments
{
    public partial interface IAppointmentService
    {
        void Insert(Appointment Categories);
        void Delete(int Id);
        void Update(Appointment Categories);
        IQueryable<Appointment> GetAllAppointments();
    }
}