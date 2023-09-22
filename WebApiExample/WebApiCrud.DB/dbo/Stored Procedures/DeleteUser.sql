create procedure [dbo].[DeleteUser]    
(    
    @Id int     
)    
As    
BEGIN    
    Update Users Set IsDeleted = 1 Where Id = @Id  
END