using CollectBlue.Models;
using CollectBlue.Parameters;
using CollectBlue.Types;
using CollectBlue.Types.Convertors;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace CollectBlue
{
  public class Token
  {
    private readonly HttpClient _httpClient;
    private readonly CreateSessionResponce _createSessionResponce;

    private Token(HttpClient httpClient, CreateSessionResponce createSessionResponce)
    {
      _httpClient = httpClient;
      _createSessionResponce = createSessionResponce;
      _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
        "Bearer",
        _createSessionResponce.AccessJwt);
    }

    public static async Task<Token> Create(string userName, string password)
    {
      var httpClient = new HttpClient();
      var responce = await httpClient.PostAsync(
        ServiceUrls.CreateSettion,
        new StringContent(
          new CreateSettionParameter(userName, password).ToJson(),
          Encoding.UTF8,
          "application/json"));
      using (var responceStream = await responce.Content.ReadAsStreamAsync())
      {
        CreateSessionResponce createSessionResponce = CreateSessionResponce.Create(responceStream);
        if (!createSessionResponce.Scceeded)
        {
          throw new Exception("TODO");
        }
        return new Token(httpClient, createSessionResponce);
      }
    }

    public async Task<Profile> GetProfile(string actor)
    {
      using (var stream = await GetProfileStream(actor))
      {
        return Profile.CreateFromJson(stream);
      }
    }

    private Task<Stream> GetProfileStream(string actor)
    {
      return _httpClient.GetStreamAsync(
              new UriBuilder(ServiceUrls.GetProfile)
              {
                Query = $"actor={HttpUtility.UrlEncode(actor)}",
              }.Uri);
    }

    public async Task<string> GetProfileRaw(string actor)
    {
      using (var stream = await GetProfileStream(actor))
      using (var reader = new StreamReader(stream))
      {
        return reader.ReadToEnd();
      }
    }

    public async Task<FeedCollection> GetUserFeeds(
      string actor,
      int limit = 25,
      string cursor = "",
      UserPostsFilterType filter = UserPostsFilterType.postsWithReplies)
    {
      return FeedCollection.CreateFromJson(await GetUserFeedsStream(actor, limit, cursor, filter));
    }

    private async Task<Stream> GetUserFeedsStream(
      string actor,
      int limit = 25,
      string cursor = "",
      UserPostsFilterType filter = UserPostsFilterType.postsWithReplies)
    {
      var queryTable = new Dictionary<string, string>
      {
        { "actor", actor },
        { "limit", $"{limit}" },
        { "filter", new UserPostsFilterTypeConvertor(filter).ConvertTo() },
      };
      if (!string.IsNullOrEmpty(cursor))
      {
        queryTable.Add("cursor", HttpUtility.UrlEncode(cursor));
      }
      return await _httpClient.GetStreamAsync(
        new UriBuilder(ServiceUrls.GetAuthorFeed)
        {
          Query = string.Join("&", queryTable.Select(q => $"{q.Key}={q.Value}")),
        }.Uri);
    }

    public async Task<string> GetUserFeedsRaw(
      string actor,
      int limit = 25,
      string cursor = "",
      UserPostsFilterType filter = UserPostsFilterType.postsWithReplies)
    {
      using (var stream = await GetUserFeedsStream(actor, limit, cursor, filter))
      using (var reader = new StreamReader(stream))
      {
        return reader.ReadToEnd();
      }
    }

    public async Task<PostCollection> SearchPosts(
      string q,
      SortPattern sort = SortPattern.Latest,
      DateTime since = default,
      DateTime until = default,
      string mentions = "",
      string author = "",
      string lang = "",
      string domain = "",
      string url = "",
      IEnumerable<string>? tags = null,
      int limit = 25,
      string cursor = "")
    {
      var queryTable = new Dictionary<string, string>
      {
        { "q", HttpUtility.UrlEncode(q) },
        { "limit", $"{limit}" },
        { "sort", new SortPatternConvertor(sort).ConvertTo() },
      };
      if (limit < 1 || 100 < limit)
      {
        throw new Exception("TODO");
      }
      if (since != default)
      {
        queryTable.Add("since", HttpUtility.UrlEncode(since.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"))); // fff？
      }
      if (until != default)
      {
        queryTable.Add("until", HttpUtility.UrlEncode(until.ToString("yyyy-MM-dd HH:mm:ss"))); // fff？
      }
      if (!string.IsNullOrEmpty(mentions))
      {
        queryTable.Add("mentions", HttpUtility.UrlEncode(mentions));
      }
      if (!string.IsNullOrEmpty(author))
      {
        queryTable.Add("author", HttpUtility.UrlEncode(author));
      }
      if (!string.IsNullOrEmpty(lang))
      {
        queryTable.Add("lang", HttpUtility.UrlEncode(lang));
      }
      if (!string.IsNullOrEmpty(domain))
      {
        queryTable.Add("domain", HttpUtility.UrlEncode(domain));
      }
      if (!string.IsNullOrEmpty(url))
      {
        queryTable.Add("url", HttpUtility.UrlEncode(url));
      }
      if (!string.IsNullOrEmpty(cursor))
      {
        queryTable.Add("cursor", HttpUtility.UrlEncode(cursor));
      }
      if (tags != null)
      {
        string tag = HttpUtility.UrlEncode(string.Join(" ", tags));
        if (tag.Length > 640)
        {
          throw new Exception("TODO");
        }
        queryTable.Add("tag", tag);
      }

      var stream = await _httpClient.GetStreamAsync(
        new UriBuilder(ServiceUrls.SearchPosts)
        {
          Query = string.Join("&", queryTable.Select(q => $"{q.Key}={q.Value}")),
        }.Uri);
      return PostCollection.CreateFromJson(stream);

    }
  }


}
