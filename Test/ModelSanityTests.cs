using IxcNet.Interfaces;
using System.Reflection;

namespace Test
{
    /// <summary>
    /// Testes de sanidade que utilizam Reflexão para validar se todos os modelos 
    /// do projeto seguem as regras de arquitetura necessárias para o funcionamento 
    /// automático do IxcNetService.
    /// </summary>
    public class ModelSanityTests
    {
        [Fact]
        public void TodosOsModelos_DevemImplementarINamedModel_ETerModelNamePreenchido()
        {
            // Busca o Assembly onde os modelos estão definidos (IxcNet)
            var assembly = typeof(INamedModel).Assembly;

            // Filtra todas as classes que implementam INamedModel, ignorando interfaces e classes abstratas
            var tiposDeModelo = assembly.GetTypes()
                .Where(t => typeof(INamedModel).IsAssignableFrom(t) 
                            && !t.IsInterface 
                            && !t.IsAbstract);

            Assert.NotEmpty(tiposDeModelo); // Garante que encontramos algum modelo para testar

            foreach (var tipo in tiposDeModelo)
            {
                // Tenta criar uma instância do modelo usando o construtor padrão
                // O IxcNetService precisa que os modelos tenham construtor sem parâmetros
                var instancia = Activator.CreateInstance(tipo) as INamedModel;

                Assert.NotNull(instancia);
                
                // Valida se o ModelName (que define a rota da API) está preenchido
                Assert.False(string.IsNullOrWhiteSpace(instancia.ModelName), 
                    $"O modelo '{tipo.Name}' não define um ModelName válido. Sem isso, as chamadas de API falharão.");
                
                // Opcional: Validar se o ModelName segue algum padrão (ex: tudo minúsculo no IXC)
                Assert.Equal(instancia.ModelName.ToLower(), instancia.ModelName);
            }
        }
    }
}
