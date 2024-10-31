namespace StudentRegisterApplication.Helpers
{
    internal class PrintObject
    {
        public static void Print<T>(List<T> param)
        {
            foreach (var p in param)
            {
                Console.WriteLine(p);
            }
        }

        public static void Print<T>(T param)
        {
            Console.WriteLine(param);
        }        
    }
}
