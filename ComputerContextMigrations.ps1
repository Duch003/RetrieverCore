Add-Migration <<NAME>> -Context LocalDatabaseContext -Project Databases.RetrieverCore..Common.Models..LocalDatabase
Update-Database -Context LocalDatabaseContext -Project Databases.RetrieverCore..Common.Models..LocalDatabase

Add-Migration UpdateGuidAdded -Context MasterDatabaseContext -Project Databases.RetrieverCore..Common.Models..MasterDatabase
Update-Database -Context MasterDatabaseContext -Project Databases.RetrieverCore..Common.Models..MasterDatabase
