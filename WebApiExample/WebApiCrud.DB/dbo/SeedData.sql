GO
SET IDENTITY_INSERT [dbo].[City] ON 
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (1, N'india')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (2, N'patna')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (3, N'bihar')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (4, N'gorakhpur')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (5, N'bhuj')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (6, N'ahamdabad')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (7, N'kolkata')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (8, N'pune')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (9, N'merut')
GO
INSERT [dbo].[City] ([Id], [Name]) VALUES (10, N'ayodhya')
GO
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (1, N'raj Narayan Gupta', N'khagual patna', N'Sep 14 2023 12:00AM', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (2, N'Santi Kum', N'Jos partin, Karachi in', N'Sep 14 2023 12:00AM', 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (3, N'Raj Gupta', N'Neem Kuan Jai Ram Bazar Khagaul Patna', N'Sep 22 2023 12:00AM', 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (4, N'Rohit Kumar', N'Gujrat bhuj', N'Sep 29 2023 12:00AM', 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (6, N'Raj Gupta', N'Neem Kuan Jai Ram Bazar Khagaul Patna', N'Sep 20 2023 12:00AM', 1, N'4,5', 8679343289, 9308337023)
GO
INSERT [dbo].[Users] ([Id], [Name], [Address], [Dob], [IsDeleted], [City], [SalesId], [MobileNumber]) VALUES (7, N'Raj Narayan Gupta', N'Gorakhpur', N'Sep 29 2023 12:00AM', 0, N'bihar,ayodhya', 9308337023, 9308337023)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
