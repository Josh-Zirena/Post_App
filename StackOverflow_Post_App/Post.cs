using System;

namespace Post_App
{
    public class Post
    {
        private DateTime _creationDate;
        private int _totalVotes = 0;
        private string _title;
        private string _description;

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
        }

        public void CreatePost()
        {
            this._creationDate = DateTime.Now;
        }

        public void upVote()
        {
            this._totalVotes++;
        }

        public void downVote()
        {
            this._totalVotes--; 
        }

        public void readSummary()
        {
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Description: " + _description);
            Console.WriteLine("Date created: "  + _creationDate);
            Console.WriteLine("totalVotes: " + _totalVotes);
        }
    }
}
