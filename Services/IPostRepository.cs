using BlazorTest.Models;

namespace BlazorTest.Services;

public interface IPostRepository
{
    Post? GetPost(String id);
    List<Post> GetAll();
    void AddPost(Post post);
    void UpdatePost(Post post);
    void DeletePost(String id);
}