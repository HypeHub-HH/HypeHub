using Azure.Core;
using HypeHubDAL.Exeptions;

namespace HypeHubDAL.Models;

public class PagedList<T>
{
    public List<T> Entities { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;
    public PagedList(List<T> entities, int count, int pageNumber, int pageSize)
    {
        if (pageNumber <= 0 || pageSize <= 0 || count <= 0) throw new ArgumentException("Page and PageSize parameters must be greater than zero.");
        TotalCount = count;
        PageSize = pageSize;
        CurrentPage = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        Entities = entities;
    }

    public static PagedList<T> ToPagedList(List<T> source, int pageNumber, int pageSize)
    {
        var count = source.Count;
        var entities = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        return new PagedList<T>(entities, count, pageNumber, pageSize);
    }
}