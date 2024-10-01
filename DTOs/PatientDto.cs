namespace DoctorAppointmentWebApi.DTOs;

public class PatientDto
{
    public Guid PatientID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string InsuranceNumber { get; set; }

    public List<Link> Links { get; set; } = new List<Link>();
}
