CREATE TABLE Categories
(
    id   INT PRIMARY KEY IDENTITY,
    name nvarchar(20) UNIQUE NOT NULL
);

CREATE TABLE Tags
(
    id   INT PRIMARY KEY IDENTITY,
    name nvarchar(20) UNIQUE NOT NULL
);

CREATE TABLE Users
(
    id        INT PRIMARY KEY IDENTITY,
    user_name nvarchar(20) UNIQUE NOT NULL,
    full_name nvarchar(20)        NOT NULL,
    age       INT CHECK (age > 0 AND age < 150)
);

CREATE TABLE Comments
(
    id      INT PRIMARY KEY IDENTITY,
    content VARCHAR(250) NOT NULL CHECK (LEN(content) > 0 AND LEN(content) <= 250),
    user_id INT REFERENCES Users (id),
    blog_id INT REFERENCES Blogs (id),
);

CREATE TABLE Blogs
(
    id          INT PRIMARY KEY IDENTITY,
    title       VARCHAR(50)   NOT NULL CHECK (LEN(title) > 0 AND LEN(title) <= 50),
    description NVARCHAR(500) NOT NULL,
    user_id     INT REFERENCES Users (id),
    category_id INT REFERENCES Categories (id),
);

CREATE TABLE BlogTags
(
    blog_id INT REFERENCES Blogs (id),
    tag_id  INT REFERENCES Tags (id),
    PRIMARY KEY (blog_id, tag_id)
);


CREATE VIEW BlogUserInfo AS
SELECT b.title     AS BlogTitle,
       u.user_name AS UserName,
       u.full_name AS FullName
FROM Blogs AS b
         JOIN Users AS u ON b.user_id = u.id;

SELECT * FROM BlogUserInfo;

CREATE VIEW BlogCategoryInfo AS
SELECT b.title AS BlogTitle, c.name AS CategoryName
FROM Blogs AS b
         JOIN Categories AS c ON b.category_id = c.id;

SELECT * FROM BlogCategoryInfo;

CREATE PROCEDURE usp_GetUserComments @userId INT
AS
BEGIN
    SELECT c.id      AS CommentId,
           c.content AS CommentContent,
           c.blog_id AS BlogId,
           c.user_id AS UserId
    FROM Comments c
    WHERE c.user_id = @userId;
END;

    EXEC usp_GetUserComments @userId = 1;


    CREATE PROCEDURE usp_GetUserBlogs @userId INT
    AS
    BEGIN
        SELECT b.id          AS BlogId,
               b.title       AS BlogTitle,
               b.description AS BlogDescription,
               b.user_id     AS UserId,
               b.category_id AS CategoryId
        FROM Blogs b
        WHERE b.user_id = @userId;
    END;

        EXEC usp_GetUserBlogs @userId = 1;
