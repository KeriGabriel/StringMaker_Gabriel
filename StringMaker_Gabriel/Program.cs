using System;

// Keri Gabriel
// IT113
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: none

namespace StringMaker_Gabriel
{
    class Program
    {
        static void Main(string[] args)
        {

            StringManager S = new StringManager();
          
            reverseAstring();
            callToString();        
            reverseAstring2();
            equalityCheck();
            symmetricCheck();         

            void callToString()
            {
                Console.WriteLine("Call ToString to output the string equivalent of all ASCII summed values ");
                Console.WriteLine("");
                S.Reverse("Sunbeam Tiger");
                Console.WriteLine(S);
                Console.WriteLine("");
                //string newString = "Dan";
                //newString = S.getValue("Dan").ToString();
            }
            void reverseAstring()
            {
                Console.WriteLine("");
                Console.WriteLine("Reverse a string Sunbeam Tiger ");
                Console.WriteLine("");                
                Console.WriteLine(S.Reverse("Sunbeam Tiger"));
                Console.WriteLine("");
            }  
            void reverseAstring2()
            {
                //Reverse a string "Sunbeam Tiger" preserving casing location in the string
                Console.WriteLine("Reverse a string Sunbeam Tiger preserving casing location in the string");
                Console.WriteLine("");
                string ReverseAstring2 = S.Reverse("Sunbeam Tiger", true);
                string ReverseAstring3 = S.Reverse("Sunbeam tiGer", true);
                string ReverseAstring4 = S.Reverse("SunBEAM tiGer", true);
                Console.WriteLine("Original string Sunbeam Tiger: " + ReverseAstring2);
                Console.WriteLine("Original string Sunbeam tiGer: " + ReverseAstring3);
                Console.WriteLine("Original string  SunBEAM tiGer: " + ReverseAstring4);
                Console.WriteLine("");
            }
            void equalityCheck() 
            {
                S.Reverse("Sunbeam Tiger");
                //Equality Check call for "Sunbeam Tiger" ***needs work***
                Console.WriteLine("Equality Check call for Sunbeam Tiger");
                Console.WriteLine("");
                Console.WriteLine(" Equals " + S.Equals("Sunbeam Tiger"));               
                Console.WriteLine("");
            }        
            void symmetricCheck() 
            {
                Console.WriteLine("Symmetric check");
                Console.WriteLine("");
                //true
                bool check1 = S.Symmetric("ABBA");
                Console.WriteLine("Symmetric check for ABBA: " + check1);
                //true
                bool check2 = S.Symmetric("ABA");
                Console.WriteLine("Symmetric check for ABA: " + check2);
                //false
                bool check3 = S.Symmetric("ABba");
                Console.WriteLine("Symmetric check for ABba: " + check3);
                //false
                bool check4 = S.Symmetric("jhyu");
                Console.WriteLine("Symmetric check for jhyu: " + check4);
                Console.WriteLine("");
            }
  
        }
    }
}
