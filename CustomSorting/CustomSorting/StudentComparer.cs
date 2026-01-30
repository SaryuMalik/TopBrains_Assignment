using System.Collection.Generic ; 
class StudentComparer : IsComparer<Student>
{
  public int Compare(Student s1 , Student s2)
  {
    int marksCompare = s2.Marks.CompareTo(s1.Marks) ;
    if (marksCompare == 0)
    {
      return s1.Age.CompareTo(s1.Age) ; 
    } 
    return MarksCompare ; 
  }
}