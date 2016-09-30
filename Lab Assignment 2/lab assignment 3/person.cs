

namespace lab_assignment_2
{
    class person
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public person Spouse;
        public string FullNameAndAge;

        public static double SumOfAllAges;
        public string AverageAge;

        public string GetfullName()
        {

            return this.FirstName + "" + this.LastName;
        }

        public void SpouseInformation()
        {
            System.Console.Write("spouse Name? ");
            Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Spouse Age?   ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            

        }
       


               




        }
    }


        
    


        
        
        
      
        
     
        
        
        

         
            
        
        
          
        
 
        
     
        


      
       
      
    
         
      



        
        
         


