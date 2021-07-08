using System;

class Employee           //create class employee
{
   public string emp_name;       //properties of this class
   public int emp_number;
}
class ProductionWorker:Employee   //inherit employee class
{
public int shift;                   //properties of this class
public int hourly_per_rate;
}
sealed class TeamLeader:ProductionWorker   //inherit productionworker class
{
public int monthly_bonus, min_training_hrs, number_training_hrs;   //properties of this class

public TeamLeader()   //constructor
   {
       monthly_bonus=0;   //member initialization
   }
   public TeamLeader(int hrs)       //overloaded constructor
   {
       min_training_hrs=hrs;
       number_training_hrs=0;
   }
}


public class Program //driver class
{
   public static void Main()   //main method
      
   {
      
       ProductionWorker p1 = new ProductionWorker();       //create object of ProductionWorker class
       Console.WriteLine("Please enter Employee name");   //access properties of employee class by object of ProductionWorker class
       p1.emp_name = Console.ReadLine();                   //prompt for employee name
       Console.WriteLine("Please enter Employee number");
       p1.emp_number = Convert.ToInt32(Console.ReadLine());   //prompt for employee number
       Console.WriteLine("Please enter Shift");
       p1.shift = Convert.ToInt32(Console.ReadLine());       //prompt for employee shift
       Console.WriteLine("Please enter Hourly per Rate");
       p1.hourly_per_rate = Convert.ToInt32(Console.ReadLine());   //prompt for employee rate
      
       //display all information
       Console.WriteLine("Employee Name="+p1.emp_name);
       Console.WriteLine("Employee Number="+p1.emp_number);
       Console.WriteLine("Employee Shift="+p1.shift);
       Console.WriteLine("Employee Hourly Rate=$"+p1.hourly_per_rate);
         
       //prompt for TeamLeader class properties
       Console.WriteLine("Please enter the details of TeamLeader");
       TeamLeader t1 = new TeamLeader();   //create object of this class

TeamLeader t2 = new TeamLeader(15); //calling constructor
// Console.WriteLine("Please enter the required minimum hours of training per year ");
//t1.min_training_hrs = Convert.ToInt32(Console.ReadLine()); //access properties
       Console.WriteLine("Please enter the Fixed Bonus Amount for TeamLeader");
       t1.monthly_bonus = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Please enter Number of Training Hrs that He attended");
       t1.number_training_hrs = Convert.ToInt32(Console.ReadLine());
       //display information of TeamLeader
       Console.WriteLine("Minimum Training HRS Required: "+t2.min_training_hrs+"hrs");
       Console.WriteLine("TeamLeader fixed Monthly Bonus Amount is: $"+t1.monthly_bonus);
       Console.WriteLine("Number of Training Hours that He attended: "+t1.number_training_hrs+"hrs");
       Console.ReadLine();
  
   }
}