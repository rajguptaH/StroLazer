CREATE procedure [dbo].[GetUser]    
AS    
BEGIN    
     SELECT u.* FROM [Users] u Where u.IsDeleted = 0 
END