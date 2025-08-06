using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public string _time;
    public List<Comment> _comments;
    public int CountComments(List<Comment> comments)
    {
        int n = 0;
        foreach (Comment c in comments)
        {
            n = n + 1;
        }
        return n;

    }
}

