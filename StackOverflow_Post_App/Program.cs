using System;

namespace Post_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a post
            var postTitle = "How I got a job as a Software Engineer.";
            var description = "Look, anyone can do it. All you need is a little bit of...";

            var firstPost = new Post(postTitle, description);
            firstPost.CreatePost();
            firstPost.upVote();
            firstPost.upVote();
            firstPost.upVote();
            firstPost.downVote();
            firstPost.readSummary();
        }
    }
}
