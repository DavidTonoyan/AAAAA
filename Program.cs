using System;

namespace AAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string myName,myNewName,myNew;
          
            myName=Console.ReadLine();
            
            for(int i=0;i<=myName.Length-1;i++)
             {
                 
                 myNewName=Microsoft.VisualBasic.Strings.Mid(myName,myName.Length-i,1);
                 myNew = myNewName;
                 Console.Write(myNew);
             }
        
        }
    }
}

        
