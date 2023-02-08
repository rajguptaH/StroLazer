# StroLazer
## You can sync with server with Asp .net Core Web Api

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://instagram.com/bug__developer)



- This is Helpful For Learning How to Do Crud Operation In .net Core Web Api
- Give A Like To This Repo If you Found Something Helpful
- ✨RNG✨
## Requirments
- .net 6.0 or newest 

## Setup 
- Clone The Repository And Then Open This .sln Project File 
- Then Create A Database And Tables Using This Script
```sql
USE [master]
GO
/****** Object:  Database [YourDatabaseName]    Script Date: 2/4/2023 6:21:03 PM ******/
CREATE DATABASE [YourDatabaseName]

ALTER DATABASE [YourDatabaseName] SET QUERY_STORE = OFF
GO
USE [YourDatabaseName]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2/4/2023 6:21:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Class] [varchar](50) NOT NULL,
	[RollNo] [int] NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]

USE [master]
GO
ALTER DATABASE [YourDatabaseName] SET  READ_WRITE 
GO
```
- Replace Server Name DbName UserName Password In AppSettings.Json File 
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "Value": "Server=localhost;Database=YouDatabaseName; User ID=sa;Password=admin;"
  },
  "AllowedHosts": "*"
}
```
- And Then Just Save And Run This Using Swagger You Can Easily Navigate To HttpRequests😁
## Thanks 

- I would Like To collaborate With Other Developers💛
- Mail : Rajkumar00999.rk@gmail.com
-  [Follow Us On Instagram]( https://instagram.com/raj__rr)
- [![GitHub rajguptaH](https://img.shields.io/github/followers/rajguptaH?label=follow&style=social)](https://github.com/rajguptaH)

## License

MIT

**Free Software, Hell Yeah!**
-
![visitors](https://visitor-badge.glitch.me/badge?page_id=rajguptaH.StroLazer)
## Mail Me Or Give a messege In Instagram If You Have Any Suggestion / Questions / Issues or Feel Free To Contribute
