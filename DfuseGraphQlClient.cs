using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DfuseGraphQl;
using Newtonsoft.Json;
using UnityEngine;

public partial class DfuseGraphQlClient
{

    private static async Task<SearchTransactionsForward> SearchTransactionsForwardPostAsync(string url, GraphQlQuery query, CancellationToken cancellationToken = default)
    {
        HttpClient httpClient = new HttpClient();

        using (var request = new HttpRequestMessage())
        {
            request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
            request.Method = HttpMethod.Post;
            request.Content = new StringContent(JsonConvert.SerializeObject(query), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

            var status = (int)response.StatusCode;
            if (status == 200)
            {

                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<SearchTransactionsForward>(responseText);
            }

            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new Exception("The HTTP status code of the response was not expected (" + status + ").");
        }
    }

    private static async Task<SearchTransactionsBackward> SearchTransactionsBackwardPostAsync(string url, GraphQlQuery query, CancellationToken cancellationToken = default)
    {
        HttpClient httpClient = new HttpClient();

        using (var request = new HttpRequestMessage())
        {
            request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
            request.Method = HttpMethod.Post;
            request.Content = new StringContent(JsonConvert.SerializeObject(query), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

            var status = (int)response.StatusCode;
            if (status == 200)
            {

                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<SearchTransactionsBackward>(responseText);
            }

            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new Exception("The HTTP status code of the response was not expected (" + status + ").");
        }
    }
}