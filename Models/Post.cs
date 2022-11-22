namespace BlazorTest.Models;
using System.ComponentModel.DataAnnotations;

public class Post
{
    private string _id;
    private string _title;
    private string _content;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    
    public Post()
    {
        _id = Guid.NewGuid().ToString();
        _createdAt = DateTime.Now;
        _updatedAt = DateTime.Now;
    }
    public string Id { get => _id; set => _id = value; }
    
    [Required]
    public string Title { get => _title; set => _title = value; }
    
    [Required]
    public string Content { get => _content; set => _content = value; }
    
    public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
    
    public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Content: {Content}, CreatedAt: {CreatedAt}, UpdatedAt: {UpdatedAt}";
    }
}