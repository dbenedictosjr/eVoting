INSERT INTO [OSPIIntegratedDB].[dbo].[Roles]
           ([RoleID]
           ,[RoleName]
           ,[Description]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[UpdatedBy]
           ,[UpdatedDate])
SELECT [RoleID]
      ,[RoleName]
      ,[Description]
      ,[CreatedBy]
      ,[CreatedDate]
      ,[UpdatedBy]
      ,[UpdatedDate]
  FROM [Test].[dbo].[Roles]
GO


