using System;
using System.Text;

namespace Static_and_Objects
{
    public class Book
    {
        private int pageCount;
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = (value >= 0) ? value : 0; }
        }
        private string bookFormat;
        public string BookFormat
        {
            get { 
                    bookFormat = bookFormat[0].ToString().ToUpper();
                    return bookFormat; 
                
                }
            set {
                string tmp = value.ToLower(); 
                if(tmp == "hardcover" || tmp == "paperback" || tmp == "ebook")
                    bookFormat = value;
                else
                    bookFormat = "n/a";
             }
        }
        
        private int year;
        public int Year
        {
            get { return year; }
            set { 
                    if(value >= 1455)
                    year = value;
                    else
                    year = DateTime.Now.Year; 
                }
        }
        
        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = (value.Length > 0) ? value : "N/A"; }
        }
        
        private string author;
        public string Author
        {
            get { return author; }
            set { author = (value.Length > 0) ? value : "N/A"; }
        }
        
        private string title;
        public string Title
        {
            get { return title; }
            set { title = (value.Length > 0) ? value : "N/A"; }
        }
        
        private int chapters;
        public int Chapters
        {
            get { return chapters; }
            set { 
                    if(value >= 0 && value < pageCount)
                        chapters = value; 
                    else
                        chapters = 0;
                }
        }
        
        public Book(int pageCount, string bookFormat, string author, int year, string title, string genre, int chapters)
        {
            this.PageCount = pageCount;
            this.BookFormat = bookFormat;
            this.Author = author;
            this.Year = year;
            this.Title = title;
            this.Genre = genre;
            this.Chapters = chapters;
        }
    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Year: {Year}\n");
            sb.Append($"Title: {Title}\n");
            sb.Append($"Author: {Author}\n");
            sb.Append($"Page Count: {PageCount}\n");
            sb.Append($"Chapters: {Chapters}\n");
            sb.Append($"Genre: {Genre}\n");
            sb.Append($"Book Format: {BookFormat}\n");

            return sb.ToString();
        }
    }
}