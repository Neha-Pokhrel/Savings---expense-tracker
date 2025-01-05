using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savings.Service.Interface;
using Savings.Model;
using Savings.Abstraction;

namespace Savings.Service;

public class Userservice: UserBase, IUserInterface
{
    private List<User> _users;

    public Userservice()
    {
        _users = LoadUsers();

        if(!_users.Any())
        {
            _users.Add(new User { Username = Seeding.Username, Password = Seeding.Password});
            SaveUsers(_users);
        }
    }
    public async Task<bool> Login(User user)
    {
        if (string.IsNullOrEmpty(user.Username)) || string.IsNullOrEmpty(user.Password))
        {
            return false;
        }
        return _users.Any(x:User => x.Username == user.Username && x.Password == user.Password);
    }
}
