create PROCEDURE SaveDocument
(@Name VARCHAR, @CreationDate DATETIME, @FileName VARCHAR, @UsersId INT)
AS
BEGIN
    SET NOCOUNT ON;

    insert into Documents values(@Name, @CreationDate, @FileName, @UsersId);

END
