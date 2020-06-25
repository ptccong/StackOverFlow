using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p = new Post("Sử lý lỗi xamarin ","ạdklasdhasjdhaskjhdjkashdjkashdjkashdjkah",2);
            p.voteUp();
            p.voteDow();
            p.showPost();
        }
    }
    class Post
    {
        private string title { set; get; }
        private string detail { set; get; }
        private DateTime datepost = DateTime.Now;
        private int countVotes = 0;
        public Post() { }
        public Post(string title,string detail,int countVotes)
        {
            this.title = title;
            this.detail = detail;
            this.countVotes = countVotes;
        }
        public void voteUp()
        {
            countVotes+=5;
        }
        public void voteDow()
        {
            countVotes--;
        }
        public void showVote()
        {
            
        }
        public void showPost()
        {
            Console.WriteLine("title: "+title+" \ndetail: "+ detail+"\nDatepost: "+datepost+"\nVote: "+countVotes);
        }
    }
}
