Add-Migration Initial -Context WmiResultsContext -Project RetrieverCore.IO -StartupProject TestConsole -OutputDir ./Migrations/WmiResults
Update-Database -Context WmiResultsContext -Project RetrieverCore.IO -StartupProject TestConsole

Enable-PSRemoting -SkipNetworkProfileCheck -Force