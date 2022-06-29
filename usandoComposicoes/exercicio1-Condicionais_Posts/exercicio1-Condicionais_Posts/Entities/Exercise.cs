using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_Condicionais_Posts.Entities
{
    internal class Exercise
    {


        public List<Post> posts = new List<Post>();
        public List<Comment> allComments = new List<Comment>();


        public void DoPost()
        {
            Console.Write("How many posts do you want to do? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Moment for post #{i}: ");
                DateTime d = DateTime.Parse(Console.ReadLine());
                Console.Write($"Title for post #{i}: ");
                string title = Console.ReadLine();
                Console.Write($"Content for post #{i}: ");
                string content = Console.ReadLine();
                Console.Write($"Likes for post #{i}: ");
                int likes = int.Parse(Console.ReadLine());

                Post post = new Post(d, title, content, likes);
                posts.Add(post);    
            }

            foreach(Post post in posts)
            {
                Console.WriteLine($"TITLE: {post.Title}" + Environment.NewLine +
                    $"MOMENT: {post.Moment}" + Environment.NewLine +
                    $"CONTENT: {post.Content}" + Environment.NewLine +
                    $"LIKES: {post.Likes}");
            }

        }

        public void DoComment()
        {
            Console.WriteLine("Choose below the post you want to comment: ");
            foreach(Post postagem in posts)
            {
                Console.WriteLine($"{postagem.Title} - {postagem.Content}");
            }
            Console.Write("Write the title: ");
            string titleWrited = Console.ReadLine();
            foreach (Post postagem in posts)
            {
                if(postagem.Title == titleWrited)
                {
                    Console.Write($"How many comments do you want to do?: ");
                    int n = int.Parse(Console.ReadLine());
                    for(int i = 1; i<=n; i++)
                    {
                        Console.Write($"Content of the #{i} comment: ");
                        string comment = Console.ReadLine();
                        Comment texts = new Comment(comment);
                        allComments.Add(texts);
                    }

                    Console.WriteLine(Environment.NewLine + $"TITLE: {postagem.Title}" + Environment.NewLine +
                    $"MOMENT: {postagem.Moment}" + Environment.NewLine +
                    $"CONTENT: {postagem.Content}" + Environment.NewLine +
                    $"LIKES: {postagem.Likes}" + Environment.NewLine +
                    $"COMMENTS: "); ;
                    foreach(Comment comment in allComments)
                    {
                        Console.Write($"{comment.Texts} " + Environment.NewLine);
                    }
                }

            }
        }
    }
}
