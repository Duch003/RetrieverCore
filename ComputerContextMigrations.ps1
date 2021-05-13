Add-Migration <<NAME>> -Context LocalDatabaseContext -Project Databases\RetrieverCore.LocalDatabase
Update-Database -Context LocalDatabaseContext -Project Databases\RetrieverCore.LocalDatabase

Add-Migration UpdateGuidAdded -Context MasterDatabaseContext -Project Databases\RetrieverCore.MasterDatabase
Update-Database -Context MasterDatabaseContext -Project Databases\RetrieverCore.MasterDatabase
