
#nullable enable

namespace Together
{
    public sealed partial class TogetherApi
    {
        /// <inheritdoc cref="TogetherApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Together.EndPointAuthorization}?)"/>
        public TogetherApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations = null) : this(httpClient, baseUri, authorizations)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}