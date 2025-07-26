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
        }
    }
}
