using System.Text;

namespace _001_Logging_Middleware.Serializers
{
    public class HTTPContextSerializer
    {
        public string SerializeCSV(HttpContext context)
        {
            StringBuilder sb = new StringBuilder();
            var req = context.Request;
            return sb.
                AppendLine("Content Length:," + req.ContentLength).
                AppendLine("Content Type:," + req.ContentType).
                AppendLine("Host:," + req.Host.Value).
                AppendLine("Is HTTPS?:," + req.IsHttps).
                AppendLine("Method:," + req.Method).
                AppendLine("Path:," + req.Path.Value).
                AppendLine("Path Base:," + req.PathBase.Value).
                AppendLine("Protocol:," + req.Protocol).
                AppendLine("Scheme:," + req.Scheme).
                AppendLine("Query:," + req.QueryString.Value).
                ToString();
        }
    }
}
