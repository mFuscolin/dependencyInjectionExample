using dependencyInjectionExample.entity;
using dependencyInjectionExample.repositories.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace dependencyInjectionExample.repositories
{
    public class UserRepository : IUserRepository
    {
        public void Delete(string id)
        {
            File.Delete($@"Arquivo\{id}.txt");
        }

        public void insert(User user)
        {
            string fileName = user.ID.ToString() + ".txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive", fileName);

            StringBuilder sb = new StringBuilder();

            sb.Append($"ID: {user.ID} \n\r");
            sb.Append($"Nome: {user.FirstName} \n\r");
            sb.Append($"Sobrenome: {user.LastName} \n\r");
            sb.Append($"Email: {user.Email} \n\r");
            sb.Append($"Data: {user.CreatedAt.ToString("dd/MM/yyyy")}");

            File.WriteAllText(path, sb.ToString());
        }
    }
}
