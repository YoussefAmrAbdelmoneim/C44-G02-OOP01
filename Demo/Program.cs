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
        }
    }
}
