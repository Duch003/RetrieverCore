Add-Migration Initial -Context ComputerContext -Project RetrieverCore.IO -StartupProject TestConsole -OutputDir ./Migrations/Computer
Update-Database -Context ComputerContext -Project RetrieverCore.IO -StartupProject TestConsole