using Blazored.LocalStorage;
using BlazorTest.Models;

namespace BlazorTest.Services;

public class PostRepository : IPostRepository
{
    private readonly ISyncLocalStorageService _localStorage;
    private readonly List<Post> _posts;
    
    public PostRepository(ISyncLocalStorageService localStorage)
    {
        _localStorage = localStorage;
        if (_localStorage.ContainKey("posts"))
        {
            _posts = _localStorage.GetItem<List<Post>>("posts");
        }
        else
        {
            _posts = new List<Post>();
            _localStorage.SetItem("posts", _posts);
        }
    }

    public List<Post> GetAll()
    {
        return _posts;
    }
    
    public Post? GetPost(String id)
    {
        return _posts.FirstOrDefault(p => p.Id == id);
    }
    
    public void AddPost(Post post)
    {
        _posts.Add(post);
        _localStorage.SetItem("posts", _posts);
    }
    
    public void UpdatePost(Post post)
    {
        var index = _posts.FindIndex(p => p.Id == post.Id);
        post.UpdatedAt = DateTime.Now;
        _posts[index] = post;
        _localStorage.SetItem("posts", _posts);
    }
    
    public void DeletePost(String id)
    {
        var index = _posts.FindIndex(p => p.Id == id);
        _posts.RemoveAt(index);
        _localStorage.SetItem("posts", _posts);
    }
}