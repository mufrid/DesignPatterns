namespace GroupPlanning.Domain;

public class Group
{
    public GroupId GroupId;
    public Doctors SpecialistsInvolvedInGroupTherapy;
    public Patients PatientsInGroup;
    public Appointments GroupAppointments;

    // some behavior
}
