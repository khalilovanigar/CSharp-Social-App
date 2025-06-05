using System;

namespace PostNamespace;

public class Post
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Creationdate { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }

    public Post(string id, string content, DateTime creationdate, int likecount, int viewcount)
    {
       // Id = id;
        Content = content;
        Creationdate = creationdate;
        LikeCount = 0;
        ViewCount = 0;
    }

    public void AddLike()
    {
        LikeCount++;
    }
    public void AddView()
    {
        ViewCount++;
    }

    public void AddContent(string newContent)
    {
        Content = newContent;
    }

    public override string ToString() => $@"
Content: {Content}
Creation date: {Creationdate}
Like count: {LikeCount}
View Count: {ViewCount}";


}

