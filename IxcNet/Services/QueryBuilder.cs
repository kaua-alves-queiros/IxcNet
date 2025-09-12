using System.Xml.Linq;

namespace IxcNet.Services
{
    public class QueryBuilder
    {
        public string? ModelName { get; set; }
        public string? FieldName { get; set; }
        public string? Query { get; set; }
        public string? Oper {  get; set; }
        public string MaxResults { get; set; } = "9999999999999999999999";

        public MultipartFormDataContent GetContent()
        {
            return new MultipartFormDataContent
            {
                { new StringContent($"{ModelName}.{FieldName}"), "qtype" },
                { new StringContent($"{Query}"), "query" },
                { new StringContent($"{Oper}"), "oper" },
                { new StringContent("1"), "page" },
                { new StringContent(MaxResults), "rp" }
            };
        }

        public static QueryBuilder List()
        {
            return Where("id", ">", "0");
        }

        public static QueryBuilder Where(string field, string oper, string query)
        {
            return new QueryBuilder
            {
                FieldName = field,
                Oper = oper,
                Query = query
            };
        }
    }
}
