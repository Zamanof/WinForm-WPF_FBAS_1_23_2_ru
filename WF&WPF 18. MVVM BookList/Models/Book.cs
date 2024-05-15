using System;

namespace WF_WPF_18._MVVM_BookList.Models;
internal sealed class Book
{
    private readonly string? name;
    public string? Name => name;

	private readonly string? author;
	public string? Author => author;

    private readonly DateTime? publishDate;
    public DateTime? PublishDate => publishDate;

    public Book(string? name, string? author, DateTime? publishDate)
    {
        this.name = name;
        this.author = author;
        this.publishDate = publishDate;
    }
    public override string ToString()
    {
        return $"\"{name}\" by {author} ({publishDate: d MMM yyyy})";
    }
}
