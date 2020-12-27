using System;

namespace DesignPattern
{
  //sealed restricts inheritance and also nested class will not be able to create a instance of the parent class
  public sealed class Singleton
  {
    //LAZY LOADING SET SIGNLETON OBJECT TO NULL
    //private static Singleton instance = null;
    //EAGER LOADING SET SIGNLETON OBJECT TO NEW INSTANCE OF SIGNLETON
    //private static readonly Singleton instance = new Singleton();
    //converting EAGER LOADING TO LAZY LOADING
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
    public static readonly object obj = new object();
    //returns only one instance of the class
    public static Singleton GetInstance
    {
      get
      {
        //lazy initialization works fine in single threaded environment 
        // if (instance == null)
        //   instance = new Singleton();



        //lock ensures in multithreaded envionment only one enters below code and create instance while other waits until the first one completes its operations
        // if (instance == null)
        // {
        //   //double check locking
        //   lock (obj)
        //   {
        //     if (instance == null)
        //       instance = new Singleton();
        //   }
        // }
        //return instance;
        return instance.Value;
      }
    }
    private static int count = 0;
    //object is not instantiated  from outside the class
    private Singleton()
    {
      count++;
      Console.WriteLine($"counter is {count}");
    }
    public void PrintDetails(string msg)
    {
      System.Console.WriteLine(msg);
    }
  }
}