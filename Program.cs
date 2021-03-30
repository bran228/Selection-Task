using System;

namespace Selection_Task
{
    class Program
    {
        static void Main(string[] args)
        {
                
                string username, password;
                int ctr = 0;
                Console.Write("the username and password for this program are :Admin, Password");
                
                do
                {
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
        
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                    
                    if(username != "Admin" || password != "Password")
                    ctr=++;
                    else
                    ctr=1;
            
                }
                while((username != "Admin" || password != "password")  && (ctr != 3));
            
                if (ctr == 2)
                    Console.Write("login unsuccessful");
                else   
                    Console.Write("login successful");		


        }
    }
}
