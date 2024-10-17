using _001_Product_Calls_CRUD_.Models.DTOs;

namespace _001_Product_Calls_CRUD_.Models.Domain_Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        private int _startingID = 100000;
        private int _endingID = 1000000 - 1;
        public Product(string name, string description, Category category)
        {
            Id = IdGenerator.Generate(_startingID, _endingID, _ids);
            _ids.Add(Id);
            Name = name;
            Description = description;
            Category = category;
        }

        private static HashSet<int> _ids = new HashSet<int>();

        private static class IdGenerator
        {
            public static int Generate(int start, int end, HashSet<int> hs)
            {
                var rand = new Random();
                var res = rand.Next(start, end);
                while (hs.Contains(res))
                {
                    res = rand.Next(start, end);
                }
                return res;
            }
        }
    }
}
