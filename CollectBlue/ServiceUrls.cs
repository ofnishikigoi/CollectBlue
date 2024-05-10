namespace CollectBlue
{
  internal static class ServiceUrls
  {
    public static Uri CreateSettion { get { return new Uri("https://bsky.social/xrpc/com.atproto.server.createSession"); } }

    public static Uri GetProfile { get { return new Uri("https://bsky.social/xrpc/app.bsky.actor.getProfile"); } }

    public static Uri GetAuthorFeed { get { return new Uri("https://public.api.bsky.app/xrpc/app.bsky.feed.getAuthorFeed"); } }
    
    public static Uri SearchPosts { get { return new Uri("https://bsky.social/xrpc/app.bsky.feed.searchPosts"); } }
  }


}
