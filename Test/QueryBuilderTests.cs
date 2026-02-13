using IxcNet.Services;

namespace Test
{
    /// <summary>
    /// Testa a lógica de construção de queries para garantir que os parâmetros 
    /// sejam formatados de acordo com o padrão esperado pela API do IXCSoft.
    /// </summary>
    public class QueryBuilderTests
    {
        [Fact]
        public void GetContent_DeveFormatarParametrosCorretamente()
        {
            // Arrange
            var query = QueryBuilder.Where("razao", "LIKE", "Teste");
            query.ModelName = "cliente";
            query.MaxResults = "10";

            // Act
            var content = query.GetContent();
            
            // Usando reflexão simples para validar as propriedades do objeto anônimo
            var type = content.GetType();
            var qtype = type.GetProperty("qtype")?.GetValue(content)?.ToString();
            var queryValue = type.GetProperty("query")?.GetValue(content)?.ToString();
            var oper = type.GetProperty("oper")?.GetValue(content)?.ToString();
            var rp = type.GetProperty("rp")?.GetValue(content)?.ToString();

            // Assert
            Assert.Equal("cliente.razao", qtype);
            Assert.Equal("Teste", queryValue);
            Assert.Equal("LIKE", oper);
            Assert.Equal("10", rp);
        }

        [Fact]
        public void List_DeveConfigurarValoresPadraoDeListagem()
        {
            // Act
            var query = QueryBuilder.List();

            // Assert
            Assert.Equal("id", query.FieldName);
            Assert.Equal(">=", query.Oper);
            Assert.Equal("1", query.Query);
            Assert.Equal("999", query.MaxResults);
        }

        [Fact]
        public void SetMaxResults_DeveAlterarLimiteParaValorAlto()
        {
            // Arrange
            var query = new QueryBuilder();

            // Act
            query.SetMaxResults();

            // Assert
            Assert.Equal("999999", query.MaxResults);
        }
    }
}
