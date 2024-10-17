namespace _002_CRUD_Implementation_With_Domains.Data
{
    public static class AppData
    {
        public static string GetAppDocumentation()
        {
            using var reader = new StreamReader("Documentation.txt");
            return reader.ReadToEnd();
        }
    }
}
