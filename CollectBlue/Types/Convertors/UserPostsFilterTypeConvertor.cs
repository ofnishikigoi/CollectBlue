namespace CollectBlue.Types.Convertors
{
  public class UserPostsFilterTypeConvertor
  {
    private readonly UserPostsFilterType _filterType;

    public UserPostsFilterTypeConvertor(UserPostsFilterType filterType)
    {
      _filterType = filterType;
    }

    public string ConvertTo()
    {
      switch (_filterType)
      {
        case UserPostsFilterType.postsWithReplies:
          return "posts_with_replies";
        case UserPostsFilterType.postsNoReplies:
          return "posts_no_replies";
        case UserPostsFilterType.postsWithMedia:
          return "posts_with_media";
        case UserPostsFilterType.postsAndAuthorThreads:
          return "posts_and_author_threads";
        default:
          throw new NotImplementedException();
      }
    }
  }

}
