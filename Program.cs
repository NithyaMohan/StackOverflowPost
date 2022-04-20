using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflow("Does my post work?", "Test to see if my post works.");
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Date Created: {post.CreatedOn}");
            Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteDown();
            post.VoteUp();
            post.VoteUp();
            post.VoteUp();
            Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteUp();
            Console.WriteLine($"Post Count: {post.VoteCount}");
        }
    }
}
