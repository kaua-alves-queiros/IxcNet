using IcNet.ViewModels;
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
        public async Task<List<ClienteViewModel>?> ClienteListlAsync(QueryBuilder? query = null)
        {
            try
            {
                query ??= QueryBuilder.List();

                var route = "cliente";
                query.ModelName = route;

                var response = await _http.PostAsync(route, query.GetContent());
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IxcResponseViewModel<ClienteViewModel>>(content)!.registros!;
            }
            catch
            {
                return null;
            }

        }
    }
}
