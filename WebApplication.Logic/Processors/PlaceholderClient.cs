using Miha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Processors
{
    public class PlaceholderClient : IPlaceholderClient
    {
        public User GetUser(string name)
        {
            throw new NotImplementedException();
        }
    }
}
