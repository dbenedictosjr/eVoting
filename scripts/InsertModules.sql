INSERT INTO [OSPIIntegratedDB].[dbo].[Modules]
           ([ModuleID]
           ,[ModuleName]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[UpdatedBy]
           ,[UpdatedDate])
SELECT [ModuleID]
      ,[ModuleName]
      ,[CreatedBy]
      ,[CreatedDate]
      ,[UpdatedBy]
      ,[UpdatedDate]
  FROM [Test].[dbo].[Modules]
GO


