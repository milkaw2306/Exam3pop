using System;
namespace Common
{
    public class News
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public DateTime Date { get; set; }
        public string Src { get; set; }

        public News (string name, string tag, DateTime date, string src)
        {
           this.Name = name;
           this.Tag = tag;
           this.Date = date;
           this.Src = src;
        }   
    }
}
