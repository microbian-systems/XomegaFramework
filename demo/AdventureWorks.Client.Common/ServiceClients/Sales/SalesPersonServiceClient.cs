//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "REST Service Clients" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xomega.Framework.Services;

namespace AdventureWorks.Services
{
    ///<summary>
    /// Sales representative current information.
    ///</summary>
    public class SalesPersonServiceClient : HttpServiceClient, ISalesPersonService
    {
        protected readonly JsonSerializerOptions SerializerOptions;

        public SalesPersonServiceClient(HttpClient httpClient, IOptionsMonitor<JsonSerializerOptions> options)
            : base(httpClient)
        {
            SerializerOptions = options.CurrentValue;
        }

        /// <inheritdoc/>
        public virtual async Task<Output<ICollection<SalesPerson_ReadListOutput>>> ReadListAsync()
        {
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, $"sales-person");
            using (var resp = await Http.SendAsync(msg, HttpCompletionOption.ResponseHeadersRead))
            {
                var content = await resp.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Output<ICollection<SalesPerson_ReadListOutput>>>(content, SerializerOptions);
            }
        }
    }
}