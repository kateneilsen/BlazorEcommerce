namespace BlazorEcommerce.Shared;

public class Category
{
    public Category()
    {
    }

    public Category(int id, string name, string url)
    {
        Id = id;
        Name = name;
        Url = url;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}