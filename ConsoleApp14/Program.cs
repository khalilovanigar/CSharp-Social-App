using System.Runtime.ConstrainedExecution;
using System;
using AdminNamespace;
using PostNamespace;
using NotificationNamespace;
using UserNamespace;
using System.Collections.Generic;

    List<User> users = new List<User>()
    {
        new User(1, "Ayla", "Esgerova", 25, "aylaesgerova@gmail.com", "ayla1234"),
        new User(2, "Orxan", "Aliyev", 30, "orxanaliyev@gmail.com", "orxan1234"),
        new User(3, "Sara", "Agayeva", 22, "saragayeva@gmail.com", "sara1234"),
        new User(4, "Vaqif", "Suleymanli", 30, "vaqifsuleymanli@gmail.com", "vaqif1234"),
        new User(5, "Nergiz", "Ehmedova", 30, "nergizehmedova@gmail.com", "nergiz1234"),
    };

List<PostNamespace.Post> posts = new List<PostNamespace.Post>()
{
    new PostNamespace.Post(11, "This is my first post", DateTime.Now,0,0),
    new PostNamespace.Post(12, "This is my second post", DateTime.Now,0,0),
    new PostNamespace.Post(13, "This is my third post", DateTime.Now,0,0),
    new PostNamespace.Post(14, "This is my fourth post", DateTime.Now,0,0),
    new PostNamespace.Post(15, "This is my fifth post", DateTime.Now,0,0),
};

var admin = new Admin(1, "admin", "admin@gmail.com", "admin1234", posts, new List<NotificationNamespace.Notification>());


while (true)
{
    Console.WriteLine(@"Enter choice: 
1. Admin page
2. User page
3. Exit");
System.Console.WriteLine();
    bool isParsed = int.TryParse(Console.ReadLine(), out int choice);
    if (!isParsed)
    {
        Console.WriteLine("Invalid input,enter number");
        continue;
    }

    if (choice == 1)
    {
        System.Console.WriteLine("Enter mail: ");
        string email = Console.ReadLine()!;
        System.Console.WriteLine("Enter password: ");
        string password = Console.ReadLine()!;

        if (admin.SignIn(email, password))
        {
            System.Console.WriteLine("Welcome,Admin");

            while (true)
            {
                System.Console.WriteLine($@"Choose an operation:
1.Show all posts
2.Add like to post
3.Add view to post
4.Exit from admin page");
System.Console.WriteLine();
                bool isParsed2 = int.TryParse(Console.ReadLine(), out int adminChoice);
                if (!isParsed2)
                {
                    Console.WriteLine("Wrong input, you must enter a number");
                    continue;
                }
                if (adminChoice == 1)
                {
                    admin.ShowAllPosts();
                }

                else if (adminChoice == 2)
                {


                    System.Console.WriteLine("Enter post id which you want to like: ");

                    if (int.TryParse(Console.ReadLine(), out int LikeId))
                    {
                        if (admin.AddLikeToPost(LikeId))
                        {
                            Console.WriteLine("Like added successfully.");
                        }

                        else
                        {
                            Console.WriteLine("Post not found.");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Wrong id for post");
                    }
                }

                else if (adminChoice == 3)
                {
                    Console.WriteLine("Enter post id ehich you want to view:");
                    if (int.TryParse(Console.ReadLine(), out int ViewId))
                    {
                        if (admin.AddViewToPost(ViewId))
                            Console.WriteLine("View count increased");
                        else
                            Console.WriteLine("Post not found..");
                    }
                    else
                    {
                        Console.WriteLine("Wrong post id..");
                    }
                }

                else if (adminChoice == 4)
                {
                    System.Console.WriteLine("Logging out from admin page");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Wrong input..");
                }
            }
            
        }
        else
        {
            System.Console.WriteLine("This admin does not exist,try again..");
        }
    }

    else if (choice == 2)
    {
        System.Console.WriteLine("Enter yoyr mai: ");
        string email = Console.ReadLine()!;
        System.Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine()!;

        User FindUser = null!;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Email == email && users[i].Password == password)
            {
                FindUser = users[i];
                break;
            }
        }

        if (FindUser != null)
        {
            System.Console.WriteLine($"Welcome {FindUser.Name} {FindUser.Surname}");

            while (true)
            {
                System.Console.WriteLine($@"Choose an operatin:
1.View all posts
2.Add like to post
3.Addview to post
4Exit from user page");
                System.Console.WriteLine();
                bool isParsed3 = int.TryParse(Console.ReadLine(), out int userChoice);
                if (!isParsed3)
                {
                    System.Console.WriteLine("Wrong input,enter number");
                    continue;
                }

                if (userChoice == 1)
                {
                    FindUser.Posts = posts;
                    FindUser.ViewAllPosts();
                }

                else if (userChoice == 2)
                {
                    
                }

            }
        }
        else
        {
            System.Console.WriteLine("This user not found,try again..");
        }


    }
    else if (choice == 3)
    {
        System.Console.WriteLine("exit from page");
        break;
    }
    else
    {
        System.Console.WriteLine("This choice does not exist..");
    }
}﻿
