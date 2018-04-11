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
        public Table<Language> langs;
        public Table<Category> categories;
        public Table<readers> readers_;
        public Table<Users> users;
    }
    [Table(Name = "users")]
    public class Users
    {
        [Column(Name = "uID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int userID;
        [Column(Name = "login", CanBeNull = false)]
        public string login;
        [Column(Name = "password", CanBeNull = false)]
        public string password;
    }
    [Table(Name = "book")]
    public class Book
    {
        [Column(Name = "bID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true, DbType = "int")]
        public int bID;
        [Column(Name = "ISBN13", DbType = "char(14)")]
        public string ISBN13;
        [Column(Name = "ISBN10", DbType = "char(11)")]
        public string ISBN10;
        [Column(Name = "name", DbType = "nvarchar(60)")]
        public string name;
        [Column(Name = "cover", DbType = "varbinary(max)")]
        public byte[] cover;
        [Column(Name = "coverType", DbType = "char(10)")]
        public string coverType;
        [Column(Name = "pubDate", DbType = "char(4)")]
        public string pubDate;
        [Column(Name = "publish", DbType = "nvarchar(40)")]
        public string publish;
        [Column(Name = "pubCountry", DbType = "char(25)")]
        public string pubCountry;
        [Column(Name = "department", DbType = "char(25)")]
        public string department;
        [Column(Name = "language", DbType = "char(3)")]
        public string language;
        [Column(Name = "genre", DbType = "nvarchar(50)")]
        public string genre;
        [Column(Name = "description", DbType = "nvarchar(max)")]
        public string description;
        [Column(Name = "restriction", DbType = "varchar(30)")]
        public string restriction;
        [Column(Name = "status", DbType = "float")]
        public float status;
        [Column(Name = "state", CanBeNull = false, DbType = "int")]
        public int state;
    }

    [Table(Name = "author")]
    public class Author
    {
        [Column(Name = "aID", CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int authorID;
        [Column(Name = "name")]
        public string name;
        [Column(Name = "bID")]
        public int bID;
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
