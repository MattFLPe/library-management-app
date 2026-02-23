using System;

namespace library_management_app.Models;

public class Book
{
    public int BookId { get; set; }
    public string? Title { get; set; }
    public List<Book> Authors { get; set; }
    public int ISBN { get; set; }
    public DateOnly PublishedYear { get; set; }
    public Boolean IsAvailable { get; set; }

}
