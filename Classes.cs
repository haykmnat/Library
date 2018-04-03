using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Library
{
    
    
    public class LibContext : DataContext
    {
        public LibContext(string connString) : base (connString)
        {
        }
        public Table<Book> books;
        public Table<Author> authors;
        public Table<Book_Author> book_Authors;
        public Table<Language> langs;
        public Table<Category> categories;
    }

    [Table(Name = "book")]
    public class Book
    {
        [Column(Name = "bID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int bookID;
        [Column(Name = "ISBN13")]
        public string ISBN13;
        [Column(Name = "ISBN10")]
        public string ISBN10;
        [Column(Name = "name")]
        public string name;
        [Column(Name = "cover")]
        public byte[] cover;
        [Column(Name = "coverType")]
        public string coverType;
        [Column(Name = "pubDate")]
        public string pubDate;
        [Column(Name = "publish")]
        public string publish;
        [Column(Name = "pubCountry")]
        public string pubCountry;
        [Column(Name = "department")]
        public string department;
        [Column(Name = "language")]
        public string language;
        [Column(Name = "genre")]
        public string genre;
        [Column(Name = "description")]
        public string description;
        [Column(Name = "restriction")]
        public string restriction;
        [Column(Name = "status")]
        public float status;
        [Column(Name = "state", CanBeNull = false)]
        public float state;
    }

    [Table(Name = "author")]
    public class Author
    {
        [Column(Name = "aID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int authorID;
        [Column(Name = "name")]
        public string name;
        [Column(Name = "surname")]
        public string surname;
        [Column(Name = "middleName")]
        public string middleName;
        [Column(Name = "country")]
        public string country;
        [Column(Name = "country2")]
        public string country2;
        [Column(Name = "country3")]
        public string country3;
        [Column(Name = "language")]
        public string language;
        [Column(Name = "language2")]
        public string language2;
        [Column(Name = "language3")]
        public string language3;
    }

    [Table(Name = "book_author")]
    public class Book_Author
    {
        [Column(Name = "ID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID;
        [Column(Name = "bID", CanBeNull = false)]
        public int bookID;
        [Column(Name = "aID", CanBeNull = false)]
        public int authorID;
    }

    [Table(Name = "language")]
    public class Language
    {
        [Column(Name = "code", CanBeNull = false, IsPrimaryKey = true)]
        public string code;
        [Column(Name = "name", CanBeNull = false)]
        public string name;
    }

    [Table(Name = "category")]
    public class Category
    {
        [Column(Name = "code", CanBeNull = false, IsPrimaryKey = true)]
        public string code;
        [Column(Name = "name", CanBeNull = false)]
        public string name;
    }
}
