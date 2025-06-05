using System;

namespace AdminNamespace;

public class Admin
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<PostNamespace.Post> Posts { get; set; }
    public List<NotificationNamespace.Notification> Notifications { get; set; }

    public Admin(int id, string username, string email, string password, List<PostNamespace.Post> posts, List<NotificationNamespace.Notification> notifications)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
        posts = posts;
        notifications = notifications;
    }

    public Admin() { }

    public bool SignIn(string email, string password)
    {
        if (email == "admin@gmail.com" && password == "admin1234")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
