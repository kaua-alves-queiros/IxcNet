using IcNet.ViewModels;
using IxcNet.Interfaces;
using IxcNet.ViewModels.Sistema.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IxcNet.Services
{
    partial class IxcNetService
    {
        public async Task<List<T>?> Listar<T>(QueryBuilder query) where T : INamedModel, new()
        {
            try
            {
                query.ModelName = new T().ModelName;

                var response = await _http.PostAsync(query.ModelName, query.GetContent());
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IxcResponseViewModel<T>>(content)!.registros!;
            }
            catch
            {
                return null;
            }
        }
    }
}
