CREATE procedure [dbo].[InsertUser]    
(    
    @Name varchar(50),    
    @City varchar(200),    
    @Address varchar(50),    
    @Dob DateTime,
	@MobileNumber bigint,    
    @SalesId bigint
)    
As    
BEGIN    
    
 INSERT INTO Users(Name,City,Address,Dob,MobileNumber,SalesId,IsDeleted)    
 VALUES(@Name,@City,@Address,@Dob,@MobileNumber,@SalesId,'0')    
    
END