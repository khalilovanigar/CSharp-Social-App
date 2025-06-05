using System;

namespace NotificationNamespace;

public class Notification
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreationDatetime { get; set; }
    public string FromUser { get; set; }

    public Notification(string id, string text, string fromuser)
    {
        //Id = id;
        Text = text;
        CreationDatetime = DateTime.Now;
        FromUser = fromuser;
    }

    public Notification()
    {

    }

}
