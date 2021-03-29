using dependencyInjectionExample.entity;
using dependencyInjectionExample.interfaces;
using dependencyInjectionExample.repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample.provider
{
    public class UserProvider: IUserProvider
    {
        private readonly IUserRepository _repositoryUser;

        public UserProvider(IUserRepository repositoryUser)
        {
            this._repositoryUser = repositoryUser;
        }
        public void addUser(User user)
        {
            _repositoryUser.insert(user);
        }
        public void delete(string id)
        {
            _repositoryUser.Delete(id);
        }
    }
}
