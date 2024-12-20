---------------------------------------------------------------------
CREATE TABLE Users (
  UserID INT IDENTITY(1,1) PRIMARY KEY,

  UserName NVARCHAR(10),
  Password NVARCHAR(64),
  IsActive BIT
);

---------------------------------------------------------------------
CREATE TABLE ContactInfo (
	ContactInfoID INT IDENTITY(1,1) PRIMARY KEY,

	Email NVARCHAR(50) NULL,
	Phone NVARCHAR(15) NULL,
	Website NVARCHAR(255) NULL
);

---------------------------------------------------------------------
CREATE TABLE Authors (
	AuthorID INT IDENTITY(1,1) PRIMARY KEY,
	ContactInfoID INT NOT NULL,

	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),

  FOREIGN KEY (ContactInfoID) REFERENCES ContactInfo(ContactInfoID)
);

---------------------------------------------------------------------
CREATE TABLE Publishers (
	PublisherID INT IDENTITY(1,1) PRIMARY KEY,
	ContactInfoID INT NOT NULL, 

	Name NVARCHAR(100),

	FOREIGN KEY (ContactInfoID) REFERENCES ContactInfo(ContactInfoID)
);

---------------------------------------------------------------------
CREATE TABLE Topics (
  TopicID INT IDENTITY(1,1) PRIMARY KEY,

  TopicName NVARCHAR(50) NOT NULL UNIQUE
);

---------------------------------------------------------------------
CREATE TABLE Tags (
  TagID INT IDENTITY(1,1) PRIMARY KEY,

  TagName NVARCHAR(50) NOT NULL UNIQUE
);

---------------------------------------------------------------------
CREATE TABLE Books (
	BookID INT IDENTITY(1,1) PRIMARY KEY,
	publisherID INT NOT NULL, 
	AuthorID INT NOT NULL, 

	Title NVARCHAR(255) NOT NULL,
	ISBN NVARCHAR (13),
	Edition TINYINT,
	PublicationDate DATE,
	Language NVARCHAR(20),
	Cover NVARCHAR(255),
	Pages INT,
	Description NVARCHAR(MAX) NULL,
	Series NVARCHAR(255) NULL,
	AddedDate DATE NOT NULL DEFAULT GETDATE(),

	FOREIGN KEY (PublisherID) REFERENCES Publishers(PublisherID),
	FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

---------------------------------------------------------------------
CREATE TABLE BookTags (
  BookTagID INT IDENTITY(1,1) PRIMARY KEY,
  BookID INT NOT NULL,
  TagID INT NOT NULL,

  FOREIGN KEY (BookID) REFERENCES Books(BookID),
  FOREIGN KEY (TagID) REFERENCES Tags(TagID)
);

---------------------------------------------------------------------
CREATE TABLE BookTopics (
  BookTopicID INT IDENTITY(1,1) PRIMARY KEY,
  BookID INT NOT NULL,
  TopicID INT NOT NULL,

  FOREIGN KEY (BookID) REFERENCES Books(BookID),
  FOREIGN KEY (TopicID) REFERENCES Topics(TopicID)
);

---------------------------------------------------------------------
CREATE TABLE UsersRecords (
	UserRecordID INT IDENTITY(1,1) PRIMARY KEY,
	BookID INT NOT NULL,
	UserID INT NOT NULL,

	AddedDate DATE NOT NULL default GETDATE(),
	State TINYINT NULL, -- 1 waiting, 2 reading, 3 finished, 4 dropped
	Difficulty TINYINT NULL, -- 1 easy, 2 medium, 3 hard
	Rating TINYINT NULL, -- from 00 to 05
	ReadingDuration INT NULL, -- in days
	FinishDate DATE NULL,
	Comments NVARCHAR(MAX) NULL,

	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

---------------------------------------------------------------------
CREATE TABLE BookAuthors (
	BookAuthors INT IDENTITY(1,1) PRIMARY KEY,
	BookID INT,
	AuthorID INT,

	FOREIGN KEY (BookID) REFERENCES Books(BookID),
	FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

---------------------------------------------------------------------

