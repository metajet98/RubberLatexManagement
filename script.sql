USE [ThaiSonDB]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [Password], [Salt], [Role], [Active]) VALUES (1, N'CanhNT', N'MRYICoYV5TVrzYXcG580PXu8HsfD6FoDhWcV1OtCWvw=', N'8nO0tyOMwexRJAcw', N'Manager', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
