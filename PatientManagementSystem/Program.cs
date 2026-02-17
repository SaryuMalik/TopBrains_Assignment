using System ;
using System.Collections.Generic ; 
using System.Linq ; 
class Patient
{
   public int Id {get; set;} 
   public string Name {get; set ; } 
   public int Age {get ; set ; } 
   public string Condition {get; set;} 

}

public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();
    
    // Add a new patient to the system
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        // TODO: Create patient and add to dictionary
        Patient patient = new Patient() ; 
        patient.Id = id ; 
        patient.Name = name ; 
        patient.Age = age ; 
        patient.Condition = condition ; 

        _patients[id] = patient ; 
         


    }
    
    // Add patient to appointment queue
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
        if (_patients.ContainsKey(patientId))
      {
           _appointmentQueue.Enqueue(_patients[patientId]) ; 
      }
      else
    {
      Console.WriteLine("Invalid Id") ; 
    }
    }
    
    // Process next appointment (remove from queue)
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
        if (_appointmentQueue.Count > 0){
        var patient = _appointmentQueue.Dequeue() ;
        return patient ; 
        }
        return null ; 
    }
    
    // Find patients with specific condition using LINQ
    public List<Patient> FindPatientsByCondition(string condition)
    {
        // TODO: Use LINQ to filter patients
        return _patients.Values.Where(n=> n.Condition == condition).ToList() ; 
    }
}


class Program
{
  static void Main()
  {
    HospitalManager manager = new HospitalManager();
    manager.RegisterPatient(1, "John Doe", 45, "Hypertension");
    manager.RegisterPatient(2, "Jane Smith", 32, "Diabetes");
    manager.ScheduleAppointment(1);
    manager.ScheduleAppointment(2);

    var nextPatient = manager.ProcessNextAppointment();
    Console.WriteLine(nextPatient.Name); // Should output: John Doe

    var diabeticPatients = manager.FindPatientsByCondition("Diabetes");
    Console.WriteLine(diabeticPatients.Count);

  }
}