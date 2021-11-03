// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;
  using (StreamWriter file = new StreamWriter("data/employees.csv"))
namespace CatWorx.BadgeMaker
{ 
  
  class Util
  {
   
    public static void PrintEmployees(List<Employee> employees) 
    
   
{
  file.WriteLine("ID,Name,PhotoUrl");

  // Loop over employees
  for (int i = 0; i < employees.Count; i++)
  {
    // Write each employee to the file
    string template = "{0},{1},{2}";
    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
  }
}
    public static void MakeCSV(List<Employee> employees)
    {
        if ( !Directory.Exists("data"))
        {
            Directory.CreateDirectory("data");
        }
    }
  }
}