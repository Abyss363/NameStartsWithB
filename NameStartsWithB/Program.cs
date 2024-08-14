namespace NameStartsWithB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (var orderId in orderIds)
            {
                if(orderId.StartsWith("B"))
                {
                    Console.WriteLine(orderId);
                }
            }
        }
    }
}
