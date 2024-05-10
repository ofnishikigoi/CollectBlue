namespace CollectBlue.Types.Convertors
{
  public class SortPatternConvertor
  {
    private readonly SortPattern _sortPattern;

    public SortPatternConvertor(SortPattern sortPattern)
    {
      _sortPattern = sortPattern;
    }

    public string ConvertTo()
    {
      switch (_sortPattern)
      {
        case SortPattern.Top:
          return "top";
        case SortPattern.Latest:
          return "latest";
        default:
          throw new NotImplementedException();
      }
    }
  }

}
