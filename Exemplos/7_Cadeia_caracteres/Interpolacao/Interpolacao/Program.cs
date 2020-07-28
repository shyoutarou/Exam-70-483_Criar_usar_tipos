using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Hello, Mark! Today is Sunday, it's 12:20 now.

            double a = 3;
            double b = 4;
            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

            double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

            var data = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {data:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");

            const int NameAlignment = -9;
            const int ValueAlignment = 7;

            Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|"); //| Arithmetic | 3,500 |
            Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|"); // | Geometric | 3,464 |
            Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|"); //  | Harmonic | 3,429 |

            Console.WriteLine($"|{"Left",-7}|{"Right",7}|"); //| Left | Right |

            const int FieldWidthRightAligned = 20;
            //    3,14159265358979 - default formatting of the pi number
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
            //               3,142 - display only three decimal digits of the pi number
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");

            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);

            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
            }

            var cultures = new System.Globalization.CultureInfo[]
            {
    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
    System.Globalization.CultureInfo.InvariantCulture
            };

            var data2 = DateTime.Now;
            var number = 31_415_926.536;
            FormattableString message = $"{data2,20}{number,20:N3}";
            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
            }

            string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
            Console.WriteLine(messageInInvariantCulture);

            string nome = "Horace";
            int age = 34;
            Console.WriteLine($"He asked, \"Is your name {nome}?\", but didn't wait for a reply :-{{");
            Console.WriteLine($"{nome} is {age} year{(age == 1 ? "" : "s")} old.");
            //He asked, "Is your name Horace?", but didn't wait for a reply :-{
            //Horace is 34 years old.

            Console.ReadKey();
        }
    }
}
