namespace FilteringLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sample For Distict By

            var products = new[]
               {
                new { Id = 1, Name = "Product A", Category = "Electronics" },
                new { Id = 2, Name = "Product B", Category = "Electronics" },
                new { Id = 3, Name = "Product C", Category = "Clothing" }
            };
            #endregion


            var numbers = new[] { 1, 2, 3, 9, 1, 5, 3, 7, 3 };

            var result = products.DistinctBy(c => c.Category);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

}
