namespace _001_Logging_Middleware.Data
{
    public static class DataRepository
    {
        static string _path = "Logger.csv";

        public static void Log(string log)
        {
            string containingText = "";
            using (StreamReader reader = new StreamReader(_path))
            {
                containingText = reader.ReadToEnd();
            }

            using StreamWriter writer = new StreamWriter(_path);
            writer.WriteLine(containingText + '\n' + log);
        }

        public static void RestartLogging(string log)
        {
            using StreamWriter writer = new StreamWriter(_path);
            writer.WriteLine(log);
        }

        public static void DeleteLogs()
        {
            RestartLogging("");
        }
    }
}
