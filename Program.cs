using System;
using System.Threading.Tasks;

namespace DesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      //parallel call to PrintDetails method
      Parallel.Invoke(
        () => PrintStudentDetails(),
        () => PrintTeacherDetails()
        );


    }

    private static void PrintTeacherDetails()
    {
      //Singleton teacher = new Singleton();
      Singleton teacher = Singleton.GetInstance;
      teacher.PrintDetails("This is the teacher message");
    }

    private static void PrintStudentDetails()
    {
      //Singleton student = new Singleton();
      Singleton student = Singleton.GetInstance;
      student.PrintDetails("This is the student message");
    }
  }
}
