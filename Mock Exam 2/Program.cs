using System;
using System.Text;

namespace Mock_Exam_2
{
    class Program
    {
       public static string[] campsiteNames = new string[0];
       public static DateTime[] campsiteDTs = new DateTime[0];
       public static string[] states = new string[0];
       public static int count = 0;
        static void Main(string[] args)
        {
            Console.Clear(); //clear the screen
            DateTime dt = DateTime.Now;
            Console.WriteLine("MAD4CAMPING Data Collection System");
            Console.WriteLine($"{dt.ToLongDateString()} {dt.ToLongTimeString()}");
            while(true)
            {
                Console.Write(GetMenu());
                if(ProcessRequest(Console.ReadLine()))
                    Environment.Exit(0);
            }
        }

        private static string GetMenu()
        {
            StringBuilder sb = new StringBuilder();  //Use StringBuilder as the best way to append strings (efficient and quick)
            sb.Append("\nOptions\n\n");
            sb.Append("\t1. Enter a campsite");
            sb.Append("\n\t2. Display all campsites");
            sb.Append("\n\t3. Display all campsites for a specific state");
            sb.Append("\n\t4. Display record count");
            sb.Append("\n\t5. Exit");
            sb.Append("\n\n\tEnter your selection: ");

            return sb.ToString();
        }

        private static void EnterCampsite(string campsite, DateTime dateTime, string state)
        {
            Array.Resize(ref campsiteNames, campsiteNames.Length +1);
            Array.Resize(ref campsiteDTs, campsiteDTs.Length +1);
            Array.Resize(ref states, states.Length +1);
            
            //campsiteNames[--campsiteNames.Length] = campsite;
            campsiteNames[count] = campsite;
            campsiteDTs[count] = dateTime;
            states[count] = state;
            count++;
        }
    
        private static string DisplayAllCampsites()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < campsiteNames.Length; i++)
            {
                sb.Append(String.Format("{0:-25} {1:10} {2:15}\n", campsiteNames[i], campsiteDTs[i].ToString(), states[i]));
            }

            return sb.ToString();
        }

        private static string DisplaySpecificCampsites(string state)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            sb.Append(String.Format($"\nRecords shown below for {state}\n\n"));
            for(int i = 0; i < campsiteNames.Length; i++)
            {
                if(states[i].ToString() == state)
                {
                    sb.Append(String.Format("{0:-25} {1:10} {2:15}\n", campsiteNames[i], campsiteDTs[i].ToString(), states[i]));
                    count++;
                }
            }
            sb.Append(String.Format($"\n{count} records displayed out of {states.Length} records total\n"));
            return sb.ToString();
        }

        private static int GetRecordCount()
        {
            return campsiteNames.Length;
        }
        private static bool ProcessRequest(string selection)
        {
            switch(selection)
            {
                case "1": //enter campsite
                        while(true)
                        {
                            Console.Write("Enter name of the campsite: ");
                            String campsiteName = Console.ReadLine();
                            if(campsiteName.Length == 0)
                            {
                                Console.WriteLine("Cannot have empty name.");
                                continue;
                            }
                            //in a while loop
                            Console.Write("Enter date (ex. MM/DD/YYYY): ");
                            string dateValidation = Console.ReadLine();
                            DateTime dateInput;
                            if(string.IsNullOrEmpty(dateValidation))
                            {
                                Console.WriteLine("Cannot enter empty value.");
                                continue;
                            }
                            if(!DateTime.TryParse(dateValidation,out dateInput))
                            {
                                Console.WriteLine("Not a valid input");
                                continue;
                            }
                            //validate date

                            Console.Write("Enter the location: ");
                            string state = Console.ReadLine();
                            //validate location (New York, Texas, Washington)
                            if(!((state == "New York") || (state == "Texas") || (state == "Washington")))
                            {
                                Console.WriteLine("Invalid state.");
                                continue;
                            }
                            EnterCampsite(campsiteName, dateInput, state);
                            break;
                        }
                        break;
                case "2":
                        Console.WriteLine(DisplayAllCampsites());
                        break;
                case "3":
                        Console.Write("Enter the state to display campsites: ");
                        Console.WriteLine(DisplaySpecificCampsites(Console.ReadLine()));
                        break;
                case "4": 
                        Console.WriteLine(GetRecordCount());
                        break;
                case "5":
                        while(true)
                        {
                            Console.Write("Are you sure you wish to quit? (y/n): ");
                            string response = Console.ReadLine().ToUpper();
                            if(response == "Y")
                                return true;
                            else if(response == "N")
                                return false;
                        }

            }

            return false;
        }
    }
}
