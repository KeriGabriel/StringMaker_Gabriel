using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace StringMaker_Gabriel
{
    class StringManager
    {
        private string _value;
        int sum = 0;
        string temp;

        public string Reverse(string s)
        {
            _value = s;
            //var for final reversed string
            string answer = string.Empty;

            // loop through and switch 
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //string IS a Char array
                answer += s[i];
            }
            return answer;
        }
       
        public string Reverse(string s, bool t) 
        {
            _value = s;
            //split words put into array
            string[] arr = s.Split(' ');
            //var for answer
            string answer = string.Empty;
            //foreach 
            foreach (var c in arr)
            {
                //for loop index c length -1 to start
                for (int i = c.Length - 1; i >= 0; i--)
                {
                    // if char is upper i and length -1
                    if (Char.IsUpper(c[c.Length - 1 - i]))
                        // answer = answer+current index to upper
                        answer += c[i].ToString().ToUpper();
                    else
                        //else answer = answer+current index to lower
                        answer += c[i].ToString().ToLower();
                }
                //add spaces
                answer += " ";
            }
            return answer;
        }
           
        public bool Symmetric(string s)
        {
            //index
            int i = 0;
            //length
            int j = s.Length - 1;
            _value = s; 

            //loop           
            while (true)
            {
                //if index is less than length keep going
                if (i > j)
                {
                    return true;
                }
                // assign var to each letter to compare
                char a = s[i];
                char b = s[j];
                //if the do not match return false it's not Symmetric 
                //**Note  if case insensitive (char.ToLower(a) != char.ToLower(b))**
                if (a != b)
                {
                    return false;
                }
                //increase index decrease length
                i++;
                j--;
            }
        }
        public override bool Equals(object obj)
        {
            //only return true if obj is string
            if (obj is string)
            {
                //if obj does not = string value return false, otherwise return true
                if (obj != _value)
                {
                    return false;
                }
                else
                {
                    return true;
                }              
            }
            //everything else return false
            else
            {
                return false;
            }
        }       
    
        public override string ToString()
        {
            //new dictionary
            Dictionary<int, string> Key = new Dictionary<int, string>();
            //temp var for sum 
            string tempSum = string.Empty;
            //var for length
            int length = _value.Length;
            //loop through and add 
            for (int i = 0; i < length; i++)
            {
                sum += _value[i];
            }
            //make a var to convert sum toString
            tempSum = sum.ToString();
            //Key 
            Key.Add(49, "One");
            Key.Add(50, "Two");
            Key.Add(51, "Three");
            Key.Add(52, "Four");
            Key.Add(53, "Five");
            Key.Add(54, "Six");
            Key.Add(55, "Seven");
            Key.Add(56, "Eight");
            Key.Add(57, "Nine");
            Key.Add(48, "Zero");
            Key.Add(45, "Negative One");

            //loop through and switch and add spaces
            for (int i = 0; i < tempSum.Length; i++)
            {
               temp += Key[tempSum[i]]+" ";
            }
           //return temp
            return temp;
        }   
    }
}


