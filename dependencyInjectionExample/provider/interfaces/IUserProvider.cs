using dependencyInjectionExample.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample.interfaces
{
    public interface IUserProvider
    {
        void addUser(User user);
        void delete(string id);
    }
}
