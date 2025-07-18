using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversionConvert();
        }

        static void ConversionIntToFloat()
        {
            // int
            int a = 100;

            // float
            float b;

            // int to float
            b = (float)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void ConversionStriingToInt()
        {
            // string
            string a = "100";

            // int
            int b;

            // string to int
            b = int.Parse(a);

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
        }

        static void ConversionTryParse()
        {
            // string -> int
            // syntax: bool variable = DestinationType.TryParse(SourceValue, out DestinationVariable)

            // read input value from keyboard
            string s;
            Console.WriteLine("Enter a number: ");
            s = Console.ReadLine();

            // TryParse
            bool b = int.TryParse(s, out int n);
            if (b == true)
            {
                Console.WriteLine("Conversion is successful");
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

        }

        static void ConversionConvert()
        {
            // Syntax: type destinationVariable = Convert.ConversionMethod(SourceValue)
            
            // int
            int a = 1000;

            // string
            string b = string.Empty;

            // int --> string
            string str = Convert.ToString(a);

            Console.WriteLine(str);

            // sbyte   -   Convert.ToSByte( value)
            // byte    -   Convert.ToByte( value)
            // short   -   Convert.ToInt16( value)
            // ushort  -   Convert.ToUInt16( value)
            // int     -   Convert.ToInt32( value)
            // uint    -   Convert.ToUInt32( value)
            // long    -   Convert.ToInt64( value)
            // ulong   -   Convert.ToUInt64( value)
            // float   -   Convert.ToSingle( value)
            // double  -   Convert.ToDouble( value)
            // decimal -   Convert.ToDecimal( value)
            // char    -   Convert.ToChar( value)
            // string  -   Convert.ToString( value)
            // bool    -   Convert.ToBoolean( value)
        }
    }
}
