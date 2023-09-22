CREATE procedure [dbo].[UpdateUser]    
(    @Id int,
    @Name varchar(50),    
    @City varchar(250),    
    @Address varchar(50),    
    @Dob DateTime,
	@MobileNumber bigint,    
    @SalesId bigint
)    

As    
BEGIN    
     UPDATE Users    
     SET Name =@Name,    
     City =@City,    
     Address = @Address,    
     Dob= @Dob,
	 MobileNumber = @MobileNumber,
	 SalesId = @SalesId
     Where Id=@Id    
END