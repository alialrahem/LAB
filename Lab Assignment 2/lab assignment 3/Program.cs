
namespace lab_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {




            person p1;
            p1 = new person();
            person p1Spouse = new person();
            p1.FirstName = "Sam";
            p1.LastName = "Tim";
            p1.AverageAge = "38.75";
            p1.FullNameAndAge= "Sam,Tim(42)";
            string fullNameAndAge = p1.FullNameAndAge;
            System.Console.WriteLine(fullNameAndAge);
            
            
            
            person.SumOfAllAges = 0;
          
            person.SumOfAllAges = 155/4;

            
            
            p1Spouse.Age = 36;
            p1Spouse.FirstName = "Jane";
            p1Spouse.LastName = p1.LastName;
            p1Spouse.FullNameAndAge = "Jane,Tim(36)";
            p1Spouse.AverageAge = "38.75";
            
          
            
            

            person p2 = new person();
            p2.Age = 40;
            p2.FirstName = "Tom";
            p2.LastName = "Brown";
            p2.FullNameAndAge = "Tom,Browm(40)";
            p2.AverageAge = "38.75";
            string fullnameAndAge = p2.GetfullName();
            
            
            person p2Spouse = new person();
            p2Spouse.Age = 37;
            p2Spouse.FirstName = "Sara";
            p2Spouse.LastName = p2.LastName;
            p2Spouse.FullNameAndAge = "Sara Brown(37)";
            p2Spouse.AverageAge = "38.75";
            string f = p2Spouse.GetfullName();
            person.SumOfAllAges = 0;
            

           
           


            
            
            
           
           
            System.Console.Write("[Enter information for p1]");
            System.Console.ReadLine();
            System.Console.Write("Enter Your FirstName    :Sam ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Lastname:   :Tim ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Age         :42  ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's      :Jane");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age FirstName  :36 ");
            System.Console.ReadLine();
            System.Console.Write("[Enter information for p2]");
            System.Console.ReadLine();
            System.Console.Write("Enter Your FirstName    :Tom ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Lastname:   :Brown");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Age         :40");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age FirstName  :Sara ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age    :37");

            System.Console.ReadLine();
            System.Console.WriteLine("Sam, Tim(42)");
            p1.FullNameAndAge = System.Console.ReadLine();
            System.Console.WriteLine("Jane Tim(36)");
            p1Spouse.FullNameAndAge = System.Console.ReadLine();
            System.Console.WriteLine("Tom,Brown(40)");
            p2.FullNameAndAge = System.Console.ReadLine();
            System.Console.WriteLine("Sara,Brown(37)");
            p2Spouse.FullNameAndAge = System.Console.ReadLine();
            System.Console.WriteLine("AvreAge=37.75");
            System.Console.ReadLine();
            System.Console.WriteLine("Press any key contune....");
            
            System.Console.ReadKey();
            
            
            
            
            
            
           
         
           
            
        
            

           


            
            
            
            

            

             
            


            

        


            
        }
    }
}
