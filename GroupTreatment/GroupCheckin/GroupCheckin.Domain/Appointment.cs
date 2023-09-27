using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;

namespace GroupCheckin.Domain;

public class Appointment
{
    public AppointmentId AppointmentId;
    public PatientsInAppointment PatientsInAppointment;
    public NoShowPatients NoShowPatients;
    public PatientsWithCancelledAppointment PatientsWithCancelledAppointment;

    public DateTime CheckinDate

    // some behavior
}
