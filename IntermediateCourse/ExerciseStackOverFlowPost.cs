using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class ExerciseStackOverFlowPost
    {
        public void run()
        {
            Console.WriteLine("Exercise StackOverFlow Post\n");

            var post = new StackOverFlowPost("A title for post on stackoverflow");
            post.Description = "A description for the post.";
            Console.WriteLine("Post title : " + post.Title);
            Console.WriteLine("Post description : " + post.Description);
            Console.WriteLine("Post created : " + post.Created);
            Console.WriteLine("Vote count : " + post.GetVoteCount());
            post.Upvote();
            Console.WriteLine("Vote count : " + post.GetVoteCount());
            post.Upvote();
            Console.WriteLine("Vote count : " + post.GetVoteCount());
            post.Downvote();
            Console.WriteLine("Vote count : " + post.GetVoteCount());
            post.Downvote();
            Console.WriteLine("Vote count : " + post.GetVoteCount());

        }
    }

    public class StackOverFlowPost
    {
        public string Title { get; private set; }
        public string Description { get; set; }
        public readonly DateTime Created;

        private int voteCount = 0;

        public StackOverFlowPost(string title)
        {
            Title = title;
            Created = DateTime.Now;
        }

        public void Upvote()
        {
            voteCount++;
        }

        public void Downvote()
        {
            voteCount--;
        }

        public int GetVoteCount()
        {
            return voteCount;
        }
    }
}
