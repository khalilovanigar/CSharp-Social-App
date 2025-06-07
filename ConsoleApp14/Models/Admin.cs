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
        Posts = posts;
        Notifications = notifications;
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

    public void AddNotification(NotificationNamespace.Notification notification)
    {
        Notifications.Add(notification);
    }

    public void AddPost(PostNamespace.Post post)
    {
        Posts.Add(post);
    }

    public void ShowAllPosts()
    {
        if (Posts == null || Posts.Count == 0)
        {
            System.Console.WriteLine("No posts available..");
            return;
        }

        foreach (var post in Posts)
        {
            System.Console.WriteLine($"Post ID: {post.Id}");
            System.Console.WriteLine($"Post content:{post.Content}");
            System.Console.WriteLine($"Post creation date: {post.Creationdate}");
            System.Console.WriteLine($"Post Like count: {post.LikeCount}");
            System.Console.WriteLine($"Post View count: {post.ViewCount}");


            System.Console.WriteLine("---------------------------");
        }
    }

    public bool AddLikeToPost(int postId)
    {
        if (Posts != null)
        {
            foreach (var post in Posts)
            {
                if (post.Id == postId)
                {
                    post.AddLike();
                    return true;
                }
            }
        }
        return false;
    }

    public bool AddViewToPost(int postId)
    {
        if (Posts != null)
        {
            foreach (var post in Posts)
            {
                if (post.Id == postId)
                {
                    post.AddView();
                    return true;
                }
            }
        }
        return false;
    }

}
