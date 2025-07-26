namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing , unBoxing
            #region Boxing [Value type to reference type] Safe
            //int x = 100;
            //object obj = x;
            //obj = 12.3;
            //obj = 'A';
            //obj = 12.12f;
            //obj = true;
            //obj = (object)'B';
            #endregion
            #region UnBoxing [reference type to value type] unSafe
            //object obj = "Aliaa";
            //obj = 10;
            //obj = new int[] { 1, 2, 3 };
            //int x = (int)obj;
            //Console.WriteLine(x);
            #endregion
            #endregion
            #region Nullable value types
            //int x = 10;
            //x = null; //invalid
            //Nullable<int> Y = 10;
            //Y = null;
            //int? z =100;
            //z = null;
            //int? a = 10;
            //int b;
            //if (a !=null)
            //{
            //    b = (int)a;
            //}
            //else
            //{
            //    b = 0;
            //}
            //if (a.HasValue)
            //{
            //    b = a.Value;
            //}
            //else
            //{
            //    b = 0;
            //}
            //b=a.HasValue ? a.Value : 0;
            //b = a ?? 0;
            //b = a.GetValueOrDefault();
            #endregion
            #region Nullable reference types
            //#nullable disable
            //            string name01 = null;
            //            Console.WriteLine(name01);
            //#nullable enable
            //            string? name02 = null;
            //            Console.WriteLine(name02);
            #endregion
            #region Null propagation
            //int[] numbers = null;
            //int arrayLength =numbers?.Length ?? 0;
            //Console.WriteLine(arrayLength);
            //for (int i = 0; i < numbers?.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //if (numbers is not null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            #region Access Modifiers [Private - Internal - Public]
            //TypeA typeA = new TypeA();
            ////typeA.X = 1;// Invalid  // X is private [assessable within its Scope Only ]
            ////typeA.Y = 1; // Invalid // Y is Internal [assessable within its Scope and in Same Project Only] 
            //typeA.Z = 1; // Valid // Z is Public [assessable within its Scope , in Same Project and outside project]
            #endregion
            #region Enum

            #region Example 01
            //Person person = new Person();
            //person.Id = 10;
            //person.Name = "Amr";
            //person.Gender = Gender.Male;

            //Grades Grd01 = Grades.A;

            ////if (Grd01 == Grades.A)
            ////	Console.WriteLine("Bravo");
            ////else
            ////	Console.WriteLine(":(");

            //Grd01 = (Grades) 4;
            //Console.WriteLine(Grd01); // E


            //Gender Gen01 = new Gender();
            //Console.WriteLine(Gen01); // Male



            //Student student = new Student()
            //{
            //	Id = 1,
            //	Name = "Eman",
            //	Branch = Branch.Dokki, // 10
            //	Gender = Gender.Female, // 1
            //	Grades = Grades.B // 1
            //}; 
            #endregion

            #region Example 02
            /// Take Data Of Student From User 
            /// Then Print Message 

            //Student student = new Student();
            //bool isParsed;
            //Console.WriteLine("Please Enter Student Data :");
            //Console.Write("ID : ");
            //int id;
            //do { isParsed = int.TryParse(Console.ReadLine(), out id); } while (!isParsed);
            //student.Id = id;

            //Console.Write("Name : ");
            //student.Name = Console.ReadLine();

            ////student.Gender = Console.ReadLine(); // Invalid 
            //object stdGender;
            //do
            //{
            //	Console.Write("Gender : ");
            //	isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), out stdGender);
            //} while (!isParsed || stdGender is null);
            //student.Gender = (Gender)stdGender;

            //do
            //{
            //	Console.Write("Branch : ");
            //	isParsed = Enum.TryParse<Branch>(Console.ReadLine(), out Branch stdBranch);
            //	student.Branch = stdBranch;
            //} while (!isParsed);

            //do
            //{
            //	Console.Write("Grade : ");
            //	isParsed = Enum.TryParse(Console.ReadLine(), out Grades stdGrade);
            //	student.Grades = stdGrade;
            //} while (!isParsed);

            //Console.Clear();
            //Console.WriteLine($"Hello {student.Name} Welcome To Route\nYour Branch is {student.Branch} And Your Grade is {student.Grades}");


            #endregion

            #region Example 03 - Permissions

            ////User user01 = new User();
            ////user01.Id = 10; // 4 Bytes 
            ////user01.Permissions[0] = true; // Write 
            ////user01.Permissions[1] = false; // Read 
            ////user01.Permissions[2] = true; // Execute 
            ////user01.Permissions[3] = false; // Delete 
            ////// User Data Stored in 8 Bytes 

            //User user02 = new User();
            //user02.Id = 20;
            //user02.Permissions = Permission.Write; 

            //User user03 = new User();
            //user03.Id = 30;
            //user03.Permissions = (Permission)4; // Read
            //user03.Permissions = (Permission)10; // Execute and Write 

            //user03.Permissions = (Permission)3; // Delete And Execute 
            //Console.WriteLine(user03.Permissions); // Delete ,Execute

            //// Add Permission Read to User 
            //user03.Permissions = user03.Permissions ^ Permission.Read;
            //Console.WriteLine(user03.Permissions); // Delete, Execute, Read


            //// Deny Permission Read to User 
            //user03.Permissions = user03.Permissions ^ Permission.Read;
            //Console.WriteLine(user03.Permissions); // Delete, Execute


            //// Deny All Permissions to User Except Delete
            //user03.Permissions = user03.Permissions & Permission.Delete;
            //Console.WriteLine(user03.Permissions); // Delete


            //// Check is User Has Permission Execute Permission or not 
            //if ( (user03.Permissions & Permission.Execute) == Permission.Execute)
            //	Console.WriteLine("User Has Execute Permission");
            //else
            //	Console.WriteLine("User Hasn't Execute Permission");

            //Console.WriteLine(user03.Permissions); // Delete


            //// Check is User Has Permission Execute Permission or not if not add it to him/her
            //if ((user03.Permissions & Permission.Execute) == Permission.Execute)
            //	Console.WriteLine("User Has Execute Permission");
            //else
            //	user03.Permissions = user03.Permissions ^ Permission.Execute;

            //Console.WriteLine(user03.Permissions); // Delete , Execute

            //// Check is User Has Permission Delete Permission or not if not add it to him/her
            //user03.Permissions = user03.Permissions | Permission.Delete;
            //Console.WriteLine(user03.Permissions); // Delete , Execute

            //// Check is User Has Permission Read Permission or not if not add it to him/her
            //user03.Permissions = user03.Permissions | Permission.Read;
            //Console.WriteLine(user03.Permissions); // Delete ,Execute, Read

            #endregion

            #endregion
        }
    }
}
