﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 3/14/2010 11:06:10 PM
namespace BookCat
{
    
    /// <summary>
    /// There are no comments for CatDbEntities in the schema.
    /// </summary>
    public partial class CatDbEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new CatDbEntities object using the connection string found in the 'CatDbEntities' section of the application configuration file.
        /// </summary>
        public CatDbEntities() : 
                base("name=CatDbEntities", "CatDbEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CatDbEntities object.
        /// </summary>
        public CatDbEntities(string connectionString) : 
                base(connectionString, "CatDbEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CatDbEntities object.
        /// </summary>
        public CatDbEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "CatDbEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Book in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Book> Book
        {
            get
            {
                if ((this._Book == null))
                {
                    this._Book = base.CreateQuery<Book>("[Book]");
                }
                return this._Book;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Book> _Book;
        /// <summary>
        /// There are no comments for Genre in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Genre> Genre
        {
            get
            {
                if ((this._Genre == null))
                {
                    this._Genre = base.CreateQuery<Genre>("[Genre]");
                }
                return this._Genre;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Genre> _Genre;
        /// <summary>
        /// There are no comments for Book in the schema.
        /// </summary>
        public void AddToBook(Book book)
        {
            base.AddObject("Book", book);
        }
        /// <summary>
        /// There are no comments for Genre in the schema.
        /// </summary>
        public void AddToGenre(Genre genre)
        {
            base.AddObject("Genre", genre);
        }
    }
    /// <summary>
    /// There are no comments for CatDbModel.Book in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Book_guid
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CatDbModel", Name="Book")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Book : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="book_guid">Initial value of Book_guid.</param>
        /// <param name="crc">Initial value of Crc.</param>
        public static Book CreateBook(global::System.Guid book_guid, float crc)
        {
            Book book = new Book();
            book.Book_guid = book_guid;
            book.Crc = crc;
            return book;
        }
        /// <summary>
        /// There are no comments for Property Book_guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Book_guid
        {
            get
            {
                return this._Book_guid;
            }
            set
            {
                this.OnBook_guidChanging(value);
                this.ReportPropertyChanging("Book_guid");
                this._Book_guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Book_guid");
                this.OnBook_guidChanged();
            }
        }
        private global::System.Guid _Book_guid;
        partial void OnBook_guidChanging(global::System.Guid value);
        partial void OnBook_guidChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Year in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Year
        {
            get
            {
                return this._Year;
            }
            set
            {
                this.OnYearChanging(value);
                this.ReportPropertyChanging("Year");
                this._Year = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Year");
                this.OnYearChanged();
            }
        }
        private string _Year;
        partial void OnYearChanging(string value);
        partial void OnYearChanged();
        /// <summary>
        /// There are no comments for Property Author_id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Author_id
        {
            get
            {
                return this._Author_id;
            }
            set
            {
                this.OnAuthor_idChanging(value);
                this.ReportPropertyChanging("Author_id");
                this._Author_id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Author_id");
                this.OnAuthor_idChanged();
            }
        }
        private string _Author_id;
        partial void OnAuthor_idChanging(string value);
        partial void OnAuthor_idChanged();
        /// <summary>
        /// There are no comments for Property CoAuthor in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string CoAuthor
        {
            get
            {
                return this._CoAuthor;
            }
            set
            {
                this.OnCoAuthorChanging(value);
                this.ReportPropertyChanging("CoAuthor");
                this._CoAuthor = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("CoAuthor");
                this.OnCoAuthorChanged();
            }
        }
        private string _CoAuthor;
        partial void OnCoAuthorChanging(string value);
        partial void OnCoAuthorChanged();
        /// <summary>
        /// There are no comments for Property File_path in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string File_path
        {
            get
            {
                return this._File_path;
            }
            set
            {
                this.OnFile_pathChanging(value);
                this.ReportPropertyChanging("File_path");
                this._File_path = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("File_path");
                this.OnFile_pathChanged();
            }
        }
        private string _File_path;
        partial void OnFile_pathChanging(string value);
        partial void OnFile_pathChanged();
        /// <summary>
        /// There are no comments for Property File_name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string File_name
        {
            get
            {
                return this._File_name;
            }
            set
            {
                this.OnFile_nameChanging(value);
                this.ReportPropertyChanging("File_name");
                this._File_name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("File_name");
                this.OnFile_nameChanged();
            }
        }
        private string _File_name;
        partial void OnFile_nameChanging(string value);
        partial void OnFile_nameChanged();
        /// <summary>
        /// There are no comments for Property Dt_added in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Dt_added
        {
            get
            {
                return this._Dt_added;
            }
            set
            {
                this.OnDt_addedChanging(value);
                this.ReportPropertyChanging("Dt_added");
                this._Dt_added = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Dt_added");
                this.OnDt_addedChanged();
            }
        }
        private string _Dt_added;
        partial void OnDt_addedChanging(string value);
        partial void OnDt_addedChanged();
        /// <summary>
        /// There are no comments for Property ISBN in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN
        {
            get
            {
                return this._ISBN;
            }
            set
            {
                this.OnISBNChanging(value);
                this.ReportPropertyChanging("ISBN");
                this._ISBN = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ISBN");
                this.OnISBNChanged();
            }
        }
        private string _ISBN;
        partial void OnISBNChanging(string value);
        partial void OnISBNChanged();
        /// <summary>
        /// There are no comments for Property Announce in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Announce
        {
            get
            {
                return this._Announce;
            }
            set
            {
                this.OnAnnounceChanging(value);
                this.ReportPropertyChanging("Announce");
                this._Announce = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Announce");
                this.OnAnnounceChanged();
            }
        }
        private string _Announce;
        partial void OnAnnounceChanging(string value);
        partial void OnAnnounceChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this.ReportPropertyChanging("Comments");
                this._Comments = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Comments");
                this.OnCommentsChanged();
            }
        }
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property Cover_path in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Cover_path
        {
            get
            {
                return this._Cover_path;
            }
            set
            {
                this.OnCover_pathChanging(value);
                this.ReportPropertyChanging("Cover_path");
                this._Cover_path = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Cover_path");
                this.OnCover_pathChanged();
            }
        }
        private string _Cover_path;
        partial void OnCover_pathChanging(string value);
        partial void OnCover_pathChanged();
        /// <summary>
        /// There are no comments for Property Publisher in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Publisher
        {
            get
            {
                return this._Publisher;
            }
            set
            {
                this.OnPublisherChanging(value);
                this.ReportPropertyChanging("Publisher");
                this._Publisher = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Publisher");
                this.OnPublisherChanged();
            }
        }
        private string _Publisher;
        partial void OnPublisherChanging(string value);
        partial void OnPublisherChanged();
        /// <summary>
        /// There are no comments for Property PageCount in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PageCount
        {
            get
            {
                return this._PageCount;
            }
            set
            {
                this.OnPageCountChanging(value);
                this.ReportPropertyChanging("PageCount");
                this._PageCount = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("PageCount");
                this.OnPageCountChanged();
            }
        }
        private string _PageCount;
        partial void OnPageCountChanging(string value);
        partial void OnPageCountChanged();
        /// <summary>
        /// There are no comments for Property Tiraj in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Tiraj
        {
            get
            {
                return this._Tiraj;
            }
            set
            {
                this.OnTirajChanging(value);
                this.ReportPropertyChanging("Tiraj");
                this._Tiraj = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Tiraj");
                this.OnTirajChanged();
            }
        }
        private string _Tiraj;
        partial void OnTirajChanging(string value);
        partial void OnTirajChanged();
        /// <summary>
        /// There are no comments for Property Crc in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public float Crc
        {
            get
            {
                return this._Crc;
            }
            set
            {
                this.OnCrcChanging(value);
                this.ReportPropertyChanging("Crc");
                this._Crc = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Crc");
                this.OnCrcChanged();
            }
        }
        private float _Crc;
        partial void OnCrcChanging(float value);
        partial void OnCrcChanged();
        /// <summary>
        /// There are no comments for Property Subtitle in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Subtitle
        {
            get
            {
                return this._Subtitle;
            }
            set
            {
                this.OnSubtitleChanging(value);
                this.ReportPropertyChanging("Subtitle");
                this._Subtitle = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Subtitle");
                this.OnSubtitleChanged();
            }
        }
        private string _Subtitle;
        partial void OnSubtitleChanging(string value);
        partial void OnSubtitleChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Genre_Guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.Guid> Genre_Guid
        {
            get
            {
                return this._Genre_Guid;
            }
            set
            {
                this.OnGenre_GuidChanging(value);
                this.ReportPropertyChanging("Genre_Guid");
                this._Genre_Guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Genre_Guid");
                this.OnGenre_GuidChanged();
            }
        }
        private global::System.Nullable<global::System.Guid> _Genre_Guid;
        partial void OnGenre_GuidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnGenre_GuidChanged();
    }
    /// <summary>
    /// There are no comments for CatDbModel.Genre in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Genre_guid
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CatDbModel", Name="Genre")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Genre : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Genre object.
        /// </summary>
        /// <param name="genre_guid">Initial value of Genre_guid.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="about">Initial value of About.</param>
        /// <param name="top_guid">Initial value of Top_guid.</param>
        public static Genre CreateGenre(global::System.Guid genre_guid, string name, string about, global::System.Guid top_guid)
        {
            Genre genre = new Genre();
            genre.Genre_guid = genre_guid;
            genre.Name = name;
            genre.About = about;
            genre.Top_guid = top_guid;
            return genre;
        }
        /// <summary>
        /// There are no comments for Property Genre_guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Genre_guid
        {
            get
            {
                return this._Genre_guid;
            }
            set
            {
                this.OnGenre_guidChanging(value);
                this.ReportPropertyChanging("Genre_guid");
                this._Genre_guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Genre_guid");
                this.OnGenre_guidChanged();
            }
        }
        private global::System.Guid _Genre_guid;
        partial void OnGenre_guidChanging(global::System.Guid value);
        partial void OnGenre_guidChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property About in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string About
        {
            get
            {
                return this._About;
            }
            set
            {
                this.OnAboutChanging(value);
                this.ReportPropertyChanging("About");
                this._About = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("About");
                this.OnAboutChanged();
            }
        }
        private string _About;
        partial void OnAboutChanging(string value);
        partial void OnAboutChanged();
        /// <summary>
        /// There are no comments for Property Top_guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Top_guid
        {
            get
            {
                return this._Top_guid;
            }
            set
            {
                this.OnTop_guidChanging(value);
                this.ReportPropertyChanging("Top_guid");
                this._Top_guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Top_guid");
                this.OnTop_guidChanged();
            }
        }
        private global::System.Guid _Top_guid;
        partial void OnTop_guidChanging(global::System.Guid value);
        partial void OnTop_guidChanged();
    }
}
