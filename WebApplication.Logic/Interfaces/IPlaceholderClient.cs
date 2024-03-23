using Miha.Models;

namespace WebApplication.Logic.Interfaces
{
    public interface IPlaceholderClient
    {
        Task<List<User>> GetUser(string name);
        Task<List<Todos>> GetTodos(int? userId);
    }
}
