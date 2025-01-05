using Savings.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings.Services.Interface
{
    public interface IUserInteface
    {
        Task<bool> Login(User user);
    }
}
