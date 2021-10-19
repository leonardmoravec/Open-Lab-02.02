using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            int i = 0;
            string[] To_Be_Outputed = new string[numbers.Length];
            foreach (double item in numbers)
        
        {
            double rounded = Math.Round(item, 2);
            string Converted_To_String = rounded.ToString();
            string Replaced_Comma = Converted_To_String.Replace(',', '.');
            To_Be_Outputed[i] = Replaced_Comma;
                   i = i + 1;
        }
    Console.Write(string.Join("", To_Be_Outputed)); 
    }
}
