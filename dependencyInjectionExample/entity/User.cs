using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample.entity
{
	public class User
	{
		public Guid ID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public void NewUser(string email, string password, string firstName, string lastName)
		{
			this.ID = Guid.NewGuid();
			this.Email = email;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.CreatedAt = DateTime.Now;

			isEmailValid();

			string pwd = generatePassword(password);

			if (string.IsNullOrEmpty(pwd))
			{
				throw new Exception("Enter the password");
			}
			this.Password = pwd;

			Validade();

		}
		private string generatePassword(string password)
		{
			var bytes = new UTF8Encoding().GetBytes(password);
			var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);

			return Convert.ToBase64String(hashBytes);
		}
		private void Validade()
		{
			if (string.IsNullOrEmpty(this.Email)
				|| string.IsNullOrEmpty(this.FirstName)
				|| string.IsNullOrEmpty(this.LastName)
				|| string.IsNullOrEmpty(this.Password))
			{
				throw new Exception("Invalid");
			}
		}
		private void isEmailValid()
		{
			if (!this.Email.Contains("@"))
				throw new Exception("incorrect email format");
		}
	}
}
