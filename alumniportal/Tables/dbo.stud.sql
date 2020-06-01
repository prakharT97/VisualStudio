CREATE TABLE [dbo].[stud] (
    [student_name] VARCHAR (50) NOT NULL,
    [branch]       VARCHAR (50) NOT NULL,
    [password]     VARCHAR (50) NOT NULL,
    [company]      VARCHAR (50) NULL,
    [year]         VARCHAR(50)          NULL,
    [survey] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([student_name] ASC)
);

