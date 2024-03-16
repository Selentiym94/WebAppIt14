using Miha.Models;

namespace WebApplication.Logic.Interfaces
{
    public interface IPlaceholderClient
    {
        public User GetUser(string name);
    }
}
