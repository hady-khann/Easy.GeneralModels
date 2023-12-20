namespace Easy.GeneralModels.Pagination;
public class Paging
{
    public int RowsCount { get; set; } = 30;
    public int PageNumber { get; set; } = 1;
    public int Skip => (PageNumber - 1) * RowsCount;
    public int Take => RowsCount;
}
