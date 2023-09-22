CREATE procedure [dbo].[GetUserById](@Id int)     
AS    
BEGIN    
     SELECT u.* FROM [Users] u Where u.IsDeleted = 0 and u.Id = @Id
END