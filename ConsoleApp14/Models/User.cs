using System;

namespace UserNamespace;

public class User
{
    public int Id { get; set; }

    private int age;
    private string email;
    private string password;

    public string Name { get; set; }
    public string Surname { get; set; }
    public List<PostNamespace.Post> Posts { get; set; } = new List<PostNamespace.Post>();

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

    public void ViewAllPosts()
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

  public bool Likepost(int postId)
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

    public bool Viewpost(int postId)
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


    public override string ToString() => @$"
Fullname: {Name} {Surname}, 
Age: {Age}, 
Email: {Email}";



}
