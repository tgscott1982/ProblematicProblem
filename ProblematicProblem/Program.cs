using System; //using
using System.Collections.Generic; //semicolon
using System.Threading;

namespace ProblematicProblem  //namespace
{
  class Program
  { //class and program swapped
        static void Main(string[] args)
        {
            Random rng = new Random(); // add new random
        
            bool cont = true; //remove static
        
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" }; //semicolon and remove static
        
    
            Console.Write("Hello, welcome to the random activity generator! \n\nWould you like to generate a random activity? yes/no: "); //semicolon
            cont =Console.ReadLine().ToLower() == "yes" ? true : false; //no redeclare cont - adjust for user input yes/no
            
            Console.WriteLine();
            
            Console.Write("We are going to need your information first! What is your name? ");
            
            string userName = Console.ReadLine();
            
            Console.WriteLine();
            
            Console.Write("What is your age? ");
            
            int userAge = int.Parse(Console.ReadLine()); //int to string - added int.parse
            
            Console.WriteLine();
            
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            
            bool seeList = Console.ReadLine().ToLower() == "sure" ? true : false; //adjust for user input
            
            if (seeList)
            {   
                Console.WriteLine();
                foreach (string activity in activities)
                {
                    
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                
                Console.Write("\nWould you like to add any activities before we generate one? yes/no: ");
                
                bool addToList = Console.ReadLine().ToLower() == "yes" ? true : false; //adjust for user input
                
                Console.WriteLine();
                
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    
                    string userAddition = Console.ReadLine();
                    
                    activities.Add(userAddition);
                    
                    foreach (string activity in activities) //added 'in'
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(200);
                    }
                    Console.WriteLine();
                    
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    
                    addToList = Console.ReadLine().ToLower() == "yes" ? true : false; //adjust for user input
                }
            }

            while (cont)
            {
                Console.Write("Connecting to the database");
                
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(200);
                }
                
                Console.WriteLine(); //semicolon
                
                Console.Write("\nChoosing your random activity");
                
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(200);
                }
                
                Console.WriteLine(); //semicolon
                
                int randomNumber = rng.Next(activities.Count);
                
                string randomActivity = activities[randomNumber]; //semicolon
                
                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    
                    Console.WriteLine("Pick something else!");
                    
                    activities.Remove(randomActivity);
                    
                    randomNumber = rng.Next(activities.Count);
                    
                    randomActivity = activities[randomNumber];
                }
                Console.Write($"\nAh got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");  //semicolon and swapped username with randomactivity
                
                Console.WriteLine(); //dot between cww
                
                cont = Console.ReadLine().ToLower() == "keep" ? true : false; //adjust for user input
            }
        
        }              //MULTIPLE CURLY BRACE ISSUES!!! OMG!!!
  }
}