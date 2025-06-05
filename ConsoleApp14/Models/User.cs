using System;

namespace UserNamespace;

public class User
{
    private int id;
    private int age;
    private string email;
    private string password;
    public int Id
    {
        get { return id; }
        set
        {
            if (value > 0 && value.ToString().Length == 6)
            {
                id = value;
            }
            else
            {
                throw new ArgumentException("Id is not true..");
            }
        }
    }
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 16)
            {
                throw new ArgumentException("Age must be over 15");

            }
            else
            {
                age = value;
            }

        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (value.EndsWith("@gmail.com"))
            {
                email = value;
            }
            else
            {
                throw new ArgumentException("Email is not true,it must end with @gmail.com");
            }
        }
    }
    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length > 7)
            {
                password = value;
            }
            else
            {
                throw new ArgumentException("Password is too short to use..");
            }

        }
    }

    public User(int id, string name, string surname, int age, string email, string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Email = email;
        Password = password;
    }
}