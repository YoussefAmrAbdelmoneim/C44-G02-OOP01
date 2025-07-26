namespace Assignmet_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //bool isParsed;
            //Season season;
            //do
            //{
            //Console.Write("Please enter season name : ");
            //isParsed = Enum.TryParse(Console.ReadLine(), true,out season);       }
            //while (!isParsed );

            //if (season == Season.Spring)
            //{
            //    Console.WriteLine("March");
            //    Console.WriteLine("April");
            //    Console.WriteLine("May");
            //}
            //else if (season == Season.Summer)
            //{
            //    Console.WriteLine("June");
            //    Console.WriteLine("July");
            //    Console.WriteLine("August");
            //}
            //else if (season == Season.Autumn)
            //{
            //    Console.WriteLine("September");
            //    Console.WriteLine("October");
            //    Console.WriteLine("November");
            //}
            //else if (season == Season.Winter) 
            //{
            //     Console.WriteLine("December");
            //     Console.WriteLine("January");
            //     Console.WriteLine("February");
            //}
            #endregion
            #region Q3
            //Permissions permission = Permissions.Read;
            //permission |= Permissions.Write;
            //Console.WriteLine(permission);
            //if ((permission & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("User has Write permission.");
            //}
            //permission ^= Permissions.Write;
            //Console.WriteLine(permission);
            //if ((permission & Permissions.Write) != Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is removed.");
            //}
            //permission |= Permissions.Execute;
            //Console.WriteLine(permission);
            #endregion
            #region Q4
            //Colors color;
            //bool isParsed;
            //do
            //{
            //    Console.Write("Enter color name: ");
            //   isParsed = Enum.TryParse(Console.ReadLine(),true,out color );
            //}
            //while (!isParsed);
            //if (color == Colors.Red || color == Colors.Blue)
            //{
            //    Console.WriteLine($"{color} is a primary color");
            //}
            //else if (color == Colors.Green)
            //{
            //    Console.WriteLine($"{color} is not a primary color");
            //}
            #endregion
        }
    }
}
