using Miha.Models;

namespace WebApplication.Logic.Interfaces
{
    public interface IPlaceholderClient
    {
        Task<List<User>> GetUser(string name);
        Task<List<Todos>> GetTodos(int? userId);
        Task<List<Photo>> GetPhotos(int? albumId);
        Task<List<Comment>> GetComments(int? postId);
        Task<List<Album>> GetAlbums(int? userId);
        Task<List<Post>> GetPosts(int? userId);

    }
}
