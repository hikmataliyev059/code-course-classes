CREATE DATABASE AB_107;

CREATE TABLE students
(
    name      NVARCHAR(20)  NOT NULL,
    surname   NVARCHAR(20)  NOT NULL,
    age       INT,
    avg_point FLOAT
);

INSERT INTO students
VALUES ('Hikmat', 'Aliyev', 19, 86.7),
       ('Ali', 'Rzayev', 18, 37.2),
       ('Farid', 'Agayev', 20, 56.3),
       ('Azi', 'Demirov', 18, 92.9),
       ('Omar', 'Mammadov', 21, 42.9);

SELECT * FROM students;

SELECT * FROM students
WHERE avg_point > 51;

SELECT * FROM students
WHERE avg_point > 51 AND avg_point < 90;

SELECT * FROM students
WHERE name LIKE 'A%' AND name LIKE '%i'

