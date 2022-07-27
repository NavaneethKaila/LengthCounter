using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthCounter1
{
    public class LengthHelper
    { 
        public int findLength(string str)
        {
            return str.Length;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string text = Console.ReadLine();
            LengthHelper helper = new LengthHelper();
            int length = helper.findLength(text);
            Console.WriteLine("The length of the string is " + length);
        }
    }
}
