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
        public Table<readers> readers_;
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

    [Table(Name = "readers")]
    public class readers
    {

        [Column(Name = "rID", CanBeNull = false, IsPrimaryKey = true)]
        public int rID;

        [Column(Name = "name", CanBeNull = false, IsPrimaryKey = false)]
        public string name;

        [Column(Name = "surname", CanBeNull = false, IsPrimaryKey = false)]
        public string surname;

        [Column(Name = "middleName", CanBeNull = true, IsPrimaryKey = false)]
        public string middleName;

        [Column(Name = "passport", CanBeNull = false, IsPrimaryKey = false)]
        public string passport;

        [Column(Name = "middleName", CanBeNull = false, IsPrimaryKey = false)]
        public DateTime birthDate;

        [Column(Name = "openDate", CanBeNull = false, IsPrimaryKey = false)]
        public DateTime openDate;

        [Column(Name = "closeDate", CanBeNull = true, IsPrimaryKey = false)]
        public DateTime closeDate;

        [Column(Name = "address", CanBeNull = false, IsPrimaryKey = false)]
        public string address;

        [Column(Name = "phone", CanBeNull = false, IsPrimaryKey = false)]
        public string phone;

        /*
        [rID] int primary key clustered not null, 
        [name] nvarchar( 30) not null, 
        surname nvarchar( 30) not null,
        middleName nvarchar( 30) null,
        passport char(10) not null,
        birthDate date not null,
        openDate date not null, --reader card open date
        closeDate date null,		--reader card close date
        [address] nvarchar( 50) not null, 
        phone varchar( 40) not null -- i mean comma seperated phone numbers listr
         */
    }
}
