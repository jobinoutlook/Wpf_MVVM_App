using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo.Models
{
    public class UserManager
    {
        private static ObservableCollection<User> _DatabaseUser = new ObservableCollection<User>() { new User() { Name = "Jobin", Email = "jobin@gmail.com" },
        new User(){ Name="Jose",Email="Jose@gmail.com"},
        new User(){ Name="Samuel", Email="Samuel@gmail.com"}

        };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUser;
        }
        
        public static void AddUser(User user)
        {
            _DatabaseUser.Add(user);
        }

    }
}
