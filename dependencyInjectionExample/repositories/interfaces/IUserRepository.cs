using dependencyInjectionExample.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample.repositories.interfaces
{
    public interface IUserRepository
    {
        void insert(User user);
        void Delete(string id);
    }
}
