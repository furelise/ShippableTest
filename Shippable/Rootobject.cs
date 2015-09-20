
using System;

public class Rootobject
{
    public Class1[] Property1 { get; set; }
}

public class Class1
{
    public string url { get; set; }
    public string labels_url { get; set; }
    public string comments_url { get; set; }
    public string events_url { get; set; }
    public string html_url { get; set; }
    public int id { get; set; }
    public int number { get; set; }
    public string title { get; set; }
    public User user { get; set; }
    public object[] labels { get; set; }
    public string state { get; set; }
    public bool locked { get; set; }
    public Assignee assignee { get; set; }
    public object milestone { get; set; }
    public int comments { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public object closed_at { get; set; }
    public string body { get; set; }
    public Pull_Request pull_request { get; set; }
}

public class User
{
    public string login { get; set; }
    public int id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public bool site_admin { get; set; }
}

public class Assignee
{
    public string login { get; set; }
    public int id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public bool site_admin { get; set; }
}

public class Pull_Request
{
    public string url { get; set; }
    public string html_url { get; set; }
    public string diff_url { get; set; }
    public string patch_url { get; set; }
}
