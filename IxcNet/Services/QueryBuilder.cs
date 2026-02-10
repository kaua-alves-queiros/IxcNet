namespace IxcNet.Services
{
    public class QueryBuilder
    {
        public string? ModelName { get; set; }
        public string? FieldName { get; set; }
        public string? Query { get; set; }
        public string? Oper { get; set; }
        public string MaxResults { get; set; } = "999";

        public object GetContent()
        {
            return new
            {
                qtype = $"{ModelName}.{FieldName}",
                query = Query,
                oper = Oper,
                page = "1",
                rp = MaxResults,
            };
        }

        public static QueryBuilder List()
        {
            return Where("id", ">=", "1");
        }

        public void SetMaxResults()
        {
            MaxResults = "999999";
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
