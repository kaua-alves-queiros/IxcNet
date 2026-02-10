namespace IxcNet.Services
{
    /// <summary>
    /// Classe responsável por construir consultas para a API do IXCSoft.
    /// Permite definir filtros, operadores e limites de resultados.
    /// </summary>
    public class QueryBuilder
    {
        /// <summary>
        /// Obtém ou define o nome do modelo (tabela) no IXCSoft.
        /// </summary>
        public string? ModelName { get; set; }

        /// <summary>
        /// Obtém ou define o nome do campo pelo qual a consulta será filtrada.
        /// </summary>
        public string? FieldName { get; set; }

        /// <summary>
        /// Obtém ou define o valor da consulta (termo de busca).
        /// </summary>
        public string? Query { get; set; }

        /// <summary>
        /// Obtém ou define o operador lógico da consulta (ex: "=", ">=", "LIKE").
        /// </summary>
        public string? Oper { get; set; }

        /// <summary>
        /// Obtém ou define a quantidade máxima de resultados a serem retornados. O padrão é "999".
        /// </summary>
        public string MaxResults { get; set; } = "999";

        /// <summary>
        /// Gera o objeto de conteúdo formatado para ser enviado no corpo da requisição JSON para a API.
        /// </summary>
        /// <returns>Um objeto anônimo contendo os parâmetros de busca formatados.</returns>
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

        /// <summary>
        /// Cria um <see cref="QueryBuilder"/> configurado para listar todos os registros (id >= 1).
        /// </summary>
        /// <returns>Uma nova instância de <see cref="QueryBuilder"/> configurada para listagem geral.</returns>
        public static QueryBuilder List()
        {
            return Where("id", ">=", "1");
        }

        /// <summary>
        /// Define o limite máximo de resultados para um valor muito alto ("999999").
        /// </summary>
        public void SetMaxResults()
        {
            MaxResults = "999999";
        }

        /// <summary>
        /// Cria uma nova instância de <see cref="QueryBuilder"/> com filtros específicos.
        /// </summary>
        /// <param name="field">O nome do campo a ser filtrado.</param>
        /// <param name="oper">O operador de comparação (ex: "=", "LIKE").</param>
        /// <param name="query">O valor a ser pesquisado.</param>
        /// <returns>Uma nova instância de <see cref="QueryBuilder"/> com os valores fornecidos.</returns>
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
