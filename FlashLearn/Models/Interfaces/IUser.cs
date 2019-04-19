using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models.Interfaces
{
    public interface IUser
    {
        Task AddUser(User user);

        Task<User> GetUserByID(int id);

        void EditUser(int id, User user);

        void RemoveUser(int id);
    }
}
