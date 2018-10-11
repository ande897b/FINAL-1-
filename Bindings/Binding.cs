using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;
using CalculatorLibrary;

namespace Bindings
{
    public class Binding
    {

        public void callID(string v)
        {
            double[] talArray = new double[10];
            int counter = 0;
            // Checker hvilken metoder der skal kaldes
            if (v == "DoThis") 
            {
                Console.WriteLine(Functions.DoThis());
            } else if(v == "DoThat")
            {
                Console.WriteLine(Functions.DoThat());
            } else if (v == "DoSomething")
            {
                Console.Write("Enter: ");
                string line = Console.ReadLine();
                Console.WriteLine(Functions.DoSomething(line));
            } else if(v == "GetTheAnswerToLifeTheUniverseAndEverything")
            {
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
            else if (v=="Add")
            {
                Console.WriteLine("Input første tal");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Clear();
                
                Console.WriteLine("Input andet tal");
                double.TryParse(Console.ReadLine(), out double tal2);
                Console.Clear();
                Console.WriteLine("første tal indtastet: " + tal1);
                Console.WriteLine("andet tal indtastet: " + tal2);
                Console.WriteLine(tal1 + "+"+ tal2 +"="+Calculator.Add(tal1, tal2));
            }
            else if (v == "Subtract")
            {
                Console.WriteLine("Input første tal");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Clear();
                
                Console.WriteLine("Input andet tal");
                double.TryParse(Console.ReadLine(), out double tal2);
                Console.Clear();
                Console.WriteLine("første tal indtastet: " + tal1);
                Console.WriteLine("andet tal indtastet: " + tal2);
                Console.WriteLine(tal1 + "-" + tal2 + "=" + Calculator.Subtract(tal1, tal2));
            }
            else if (v == "Multiply")
            {
                Console.WriteLine("Input første tal");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Clear();
                
                Console.WriteLine("Input andet tal");
                double.TryParse(Console.ReadLine(), out double tal2);
                Console.Clear();
                Console.WriteLine("første tal indtastet: " + tal1);
                Console.WriteLine("andet tal indtastet: " + tal2);
                Console.WriteLine(tal1 + "*" + tal2 + "=" + Calculator.Multiply(tal1, tal2));
            }
            else if (v == "Divide")
            {
                Console.WriteLine("Input første tal");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Clear();                
                Console.WriteLine("Input andet tal");
                double.TryParse(Console.ReadLine(), out double tal2);
                Console.Clear();
                Console.WriteLine("første tal indtastet: " + tal1);
                Console.WriteLine("andet tal indtastet: " + tal2);
                Console.WriteLine(tal1 + "/" + tal2 + "=" + Calculator.Divide(tal1, tal2));
            }
            else if (v == "Sum")
            {
                Console.WriteLine("Input talserie og afslut med enter, Max 10 tal");
                string tal = Console.ReadLine();
                while (tal != "")
                {
                    double parsedTal = double.Parse(tal);
                    talArray[counter] = parsedTal;
                    counter++;                    
                    tal = Console.ReadLine();
                }
                Console.Clear();
                Array.Resize(ref talArray, counter);
                for (int i = 0; i < talArray.Length; i++)
                {
                    Console.Write(talArray[i] + ", ");
                }
                Console.WriteLine();
                
                Console.WriteLine("Summen er: " + Calculator.Sum(talArray));
            }
            else if (v == "Minimum")
            {
                Console.WriteLine("Input talserie og afslut med enter, Max 10 tal");
                string tal = Console.ReadLine();
                while (tal != "")
                {
                    double parsedTal = double.Parse(tal);
                    talArray[counter] = parsedTal;
                    counter++;
                    tal = Console.ReadLine();
                }
                Console.Clear();
                Array.Resize(ref talArray, counter);
                for (int i = 0; i < talArray.Length; i++)
                {
                    Console.Write(talArray[i] + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Minimum er: " + Calculator.Minimum(talArray));
            }
            else if (v == "Maximum")
            {
                Console.WriteLine("Input talserie og afslut med enter, Max 10 tal");
                string tal = Console.ReadLine();
                while (tal != "")
                {
                    double parsedTal = double.Parse(tal);
                    talArray[counter] = parsedTal;
                    counter++;
                    tal = Console.ReadLine();
                }
                Console.Clear();
                Array.Resize(ref talArray, counter);
                for (int i = 0; i < talArray.Length; i++)
                {
                    Console.Write(talArray[i] + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Maximum er: " + Calculator.Maximum(talArray));
            }
            else if (v == "Average")
            {
                Console.WriteLine("Input talserie og afslut med enter, Max 10 tal");
                string tal = Console.ReadLine();
                while (tal != "")
                {
                    double parsedTal = double.Parse(tal);
                    talArray[counter] = parsedTal;
                    counter++;
                    tal = Console.ReadLine();
                }
                Console.Clear();
                Array.Resize(ref talArray, counter);
                for (int i = 0; i < talArray.Length; i++)
                {
                    Console.Write(talArray[i] + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Average er: " + Calculator.Average(talArray));
            }
            else if (v == "Squared")
            {
                Console.WriteLine("Input tal");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Squared result er: "+Calculator.Squared(tal1));
            }
            else if (v == "xiy")
            {
                Console.WriteLine("Input x");
                double x = double.Parse(Console.ReadLine());
                Console.Clear();
                
                Console.WriteLine("Input y");
                double y = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("første tal indtastet: " + x);
                Console.WriteLine("andet tal indtastet: " + y);
                
                Console.WriteLine(x + "^" + y + "=" + Calculator.XiY(x,y));
            }
        }
    }
}
