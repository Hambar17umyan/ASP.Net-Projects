namespace _002_CRUD_Implementation_With_Domains.Helpers
{
    public class IdHelper
    {
        public static int Generate(int start, int end, HashSet<int> hs)
        {
            var rand = new Random();
            var res = rand.Next(start, end);
            while (hs.Contains(res))
            {
                res = rand.Next(start, end);
            }
            hs.Add(res);
            return res;
        }
    }
}
