using GathererEngine.Database;
using GathererEngine.Models;
using Microsoft.EntityFrameworkCore;
using RetrieverCore.MasterDatabase.Extensions;
using System;
using System.Linq;

namespace RetrieverCore.MasterDatabase.Context
{
    public class MasterDatabaseContext : DbContext
    {
        public MasterDatabaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DUCH003\\TOLEARNINSTANCE;Initial Catalog=WmiResults;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.BatteryFullChargedCapacity)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<BatteryFullChargedCapacity>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.BatteryStaticData)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<BatteryStaticData>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.BatteryStatus)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<BatteryStatus>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Battery)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Battery>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Battery>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_BIOSElement)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_BIOSElement>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_BIOSElement>()
                .Property(x => x.BiosCharacteristics)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_BIOSElement>()
                .Property(x => x.BIOSVersion)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_BIOSElement>()
                .Property(x => x.ListOfLanguages)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Card)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Card>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Card>()
                .Property(x => x.ConfigOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Chip)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Chip>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_ComputerSystem)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_ComputerSystem>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.BootStatus)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.InitialLoadInfo)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.OEMLogoBitmap)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.OEMStringArray)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.Roles)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.SupportContactDescription)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_ComputerSystem>()
                .Property(x => x.SystemStartupOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Controller)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Controller>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Controller>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_CoolingDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_CoolingDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_CoolingDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_CurrentSensor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_CurrentSensor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_CurrentSensor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_DesktopMonitor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_DesktopMonitor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_DesktopMonitor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_DiskDrive)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_DiskDrive>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_DiskDrive>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_DiskDrive>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_DiskDrive>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_DiskPartition)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_DiskPartition>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_DiskPartition>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Display)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Display>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Display>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Fan)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Fan>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Fan>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_InstalledOS)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_InstalledOS>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Keyboard)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Keyboard>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Keyboard>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_LogicalDisk)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_LogicalDisk>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_LogicalDisk>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Memory)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Memory>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Memory>()
                .Property(x => x.AdditionalErrorData)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_Memory>()
                .Property(x => x.CurrentSRAM)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Memory>()
                .Property(x => x.ErrorData)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_Memory>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Memory>()
                .Property(x => x.SupportedSRAM)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_NetworkAdapter)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_NetworkAdapter>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_NetworkAdapter>()
                .Property(x => x.NetworkAddresses)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_NetworkAdapter>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_NumericSensor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_NumericSensor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_NumericSensor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_OperatingSystem)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_OperatingSystem>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_OperatingSystem>()
                .Property(x => x.MUILanguages)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_PCVideoController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_PCVideoController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_PCVideoController>()
                .Property(x => x.AcceleratorCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_PCVideoController>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_PCVideoController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_PhysicalConnector)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_PhysicalConnector>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_PhysicalConnector>()
                .Property(x => x.ConnectorType)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_PhysicalConnector>()
                .Property(x => x.VccMixedVoltageSupport)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_PhysicalConnector>()
                .Property(x => x.VppMixedVoltageSupport)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_PhysicalElement)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_PhysicalElement>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_PhysicalElement>()
                .Property(x => x.ConfigOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_PhysicalMemory)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_PhysicalMemory>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_PointingDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_PointingDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_PointingDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Printer)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Printer>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.AvailableJobSheets)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.CharSetsSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.CurrentCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.DefaultCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.ErrorInformation)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.LanguagesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.MimeTypesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.NaturalLanguagesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.PaperSizesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.PaperTypesAvailable)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Printer>()
                .Property(x => x.PrinterPaperNames)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Process)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Process>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Processor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Processor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Processor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Product)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Product>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_SCSIController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_SCSIController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_SCSIController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Sensor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Sensor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Sensor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_SerialController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_SerialController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_SerialController>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_SerialController>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_SerialController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_Slot)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_Slot>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_Slot>()
                .Property(x => x.ConnectorType)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Slot>()
                .Property(x => x.VccMixedVoltageSupport)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_Slot>()
                .Property(x => x.VppMixedVoltageSupport)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_StorageVolume)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_StorageVolume>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_StorageVolume>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_System)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_System>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.BootStatus)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.InitialLoadInfo)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.OEMLogoBitmap)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.OEMStringArray)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.Roles)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.SupportContactDescription)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_System>()
                .Property(x => x.SystemStartupOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_TemperatureSensor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_TemperatureSensor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_TemperatureSensor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_UnitaryComputerSystem)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.BootStatus)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.InitialLoadInfo)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.OEMLogoBitmap)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.OEMStringArray)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.Roles)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.SupportContactDescription)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_UnitaryComputerSystem>()
                .Property(x => x.SystemStartupOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_USBController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_USBController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_USBController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_USBDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_USBDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_USBDevice>()
                .Property(x => x.CurrentAlternateSettings)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<CIM_USBDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_VideoController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_VideoController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_VideoController>()
                .Property(x => x.AcceleratorCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<CIM_VideoController>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<CIM_VideoController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_VideoControllerResolution)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_VideoControllerResolution>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_VideoSetting)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_VideoSetting>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.CIM_VoltageSensor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<CIM_VoltageSensor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<CIM_VoltageSensor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.MSAcpi_ThermalZoneTemperature)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<MSAcpi_ThermalZoneTemperature>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<MSAcpi_ThermalZoneTemperature>()
                .Property(x => x.ActiveTripPoint)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt32>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.MSFT_PhysicalDisk)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<MSFT_PhysicalDisk>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<MSFT_PhysicalDisk>()
                .Property(x => x.CannotPoolReason)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<MSFT_PhysicalDisk>()
                .Property(x => x.OperationalDetails)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<MSFT_PhysicalDisk>()
                .Property(x => x.OperationalStatus)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<MSFT_PhysicalDisk>()
                .Property(x => x.SupportedUsages)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.SoftwareLicensingProduct)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<SoftwareLicensingProduct>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.SoftwareLicensingService)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<SoftwareLicensingService>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Account)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Account>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_AssociatedProcessorMemory)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_AssociatedProcessorMemory>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_BaseBoard)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_BaseBoard>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_BaseBoard>()
                .Property(x => x.ConfigOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Battery)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Battery>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Battery>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_BIOS)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_BIOS>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_BIOS>()
                .Property(x => x.BiosCharacteristics)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_BIOS>()
                .Property(x => x.BIOSVersion)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_BIOS>()
                .Property(x => x.ListOfLanguages)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Bus)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Bus>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Bus>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_CacheMemory)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_CacheMemory>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_CacheMemory>()
                .Property(x => x.AdditionalErrorData)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<Win32_CacheMemory>()
                .Property(x => x.CurrentSRAM)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_CacheMemory>()
                .Property(x => x.ErrorData)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<Win32_CacheMemory>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_CacheMemory>()
                .Property(x => x.SupportedSRAM)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_CDROMDrive)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_CDROMDrive>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_CDROMDrive>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_CDROMDrive>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_CDROMDrive>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());


            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_ComputerSystem)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_ComputerSystem>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.BootStatus)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.InitialLoadInfo)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.OEMLogoBitmap)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<byte>())
                        .ToArray());
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.OEMStringArray)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.Roles)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.SupportContactDescription)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_ComputerSystem>()
                .Property(x => x.SystemStartupOptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_DiskDrive)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_DiskDrive>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_DiskDrive>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_DiskDrive>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_DiskDrive>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_DiskPartition)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_DiskPartition>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_DiskPartition>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Fan)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Fan>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Fan>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Keyboard)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Keyboard>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Keyboard>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_LogicalDisk)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_LogicalDisk>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_LogicalDisk>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_MotherboardDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_MotherboardDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_MotherboardDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_NetworkAdapter)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_NetworkAdapter>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_NetworkAdapter>()
                .Property(x => x.NetworkAddresses)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapter>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_NetworkAdapterConfiguration)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.DefaultIPGateway)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.DNSDomainSuffixSearchOrder)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.DNSServerSearchOrder)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.GatewayCostMetric)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPAddress)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPSecPermitIPProtocols)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPSecPermitTCPPorts)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPSecPermitUDPPorts)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPSubnet)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPXFrameType)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt32>())
                        .ToArray());
            modelBuilder.Entity<Win32_NetworkAdapterConfiguration>()
                .Property(x => x.IPXNetworkNumber)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_OperatingSystem)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_OperatingSystem>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_OperatingSystem>()
                .Property(x => x.MUILanguages)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PhysicalMemory)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PhysicalMemory>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PnPDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PnPDevice>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PnPEntity)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PnPEntity>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_PnPEntity>()
                .Property(x => x.CompatibleID)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_PnPEntity>()
                .Property(x => x.HardwareID)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_PnPEntity>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PointingDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PointingDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_PointingDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PortConnector)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PortConnector>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_PortConnector>()
                .Property(x => x.ConnectorType)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_PortResource)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_PortResource>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Printer)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Printer>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.AvailableJobSheets)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.CharSetsSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.CurrentCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.DefaultCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.ErrorInformation)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.LanguagesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.MimeTypesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.NaturalLanguagesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.PaperSizesSupported)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.PaperTypesAvailable)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_Printer>()
                .Property(x => x.PrinterPaperNames)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Process)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Process>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Processor)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Processor>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Processor>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_SerialPort)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_SerialPort>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_SerialPort>()
                .Property(x => x.Capabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_SerialPort>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_SerialPort>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_SoundDevice)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_SoundDevice>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_SoundDevice>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_TimeZone)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_TimeZone>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_VideoController)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_VideoController>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_VideoController>()
                .Property(x => x.AcceleratorCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
            modelBuilder.Entity<Win32_VideoController>()
                .Property(x => x.CapabilityDescriptions)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None));
            modelBuilder.Entity<Win32_VideoController>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_VideoSettings)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_VideoSettings>()
                .HasKey(x => x.WMIID);

            modelBuilder.Entity<WmiResultsSetEntity>()
                .HasMany(x => x.Win32_Volume)
                .WithOne(x => x.WmiResultsSetEntity);
            modelBuilder.Entity<Win32_Volume>()
                .HasKey(x => x.WMIID);
            modelBuilder.Entity<Win32_Volume>()
                .Property(x => x.PowerManagementCapabilities)
                .HasConversion(
                    to => string.Join(';', to),
                    from => from.Split(';', StringSplitOptions.None)
                        .Select(x => x.ToNullable<UInt16>())
                        .ToArray());
        }

        public DbSet<WmiResultsSetEntity> WmiResultsSet { get; set; }
        public DbSet<BatteryFullChargedCapacity> BatteryFullChargedCapacity { get; set; }
        public DbSet<BatteryStaticData> BatteryStaticData { get; set; }
        public DbSet<BatteryStatus> BatteryStatus { get; set; }
        public DbSet<CIM_Battery> CIM_Battery { get; set; }
        public DbSet<CIM_BIOSElement> CIM_BIOSElement { get; set; }
        public DbSet<CIM_Card> CIM_Card { get; set; }
        public DbSet<CIM_Chip> CIM_Chip { get; set; }
        public DbSet<CIM_ComputerSystem> CIM_ComputerSystem { get; set; }
        public DbSet<CIM_Controller> CIM_Controller { get; set; }
        public DbSet<CIM_CoolingDevice> CIM_CoolingDevice { get; set; }
        public DbSet<CIM_CurrentSensor> CIM_CurrentSensor { get; set; }
        public DbSet<CIM_DesktopMonitor> CIM_DesktopMonitor { get; set; }
        public DbSet<CIM_DiskDrive> CIM_DiskDrive { get; set; }
        public DbSet<CIM_DiskPartition> CIM_DiskPartition { get; set; }
        public DbSet<CIM_Display> CIM_Display { get; set; }
        public DbSet<CIM_Fan> CIM_Fan { get; set; }
        public DbSet<CIM_InstalledOS> CIM_InstalledOS { get; set; }
        public DbSet<CIM_Keyboard> CIM_Keyboard { get; set; }
        public DbSet<CIM_LogicalDisk> CIM_LogicalDisk { get; set; }
        public DbSet<CIM_Memory> CIM_Memory { get; set; }
        public DbSet<CIM_NetworkAdapter> CIM_NetworkAdapter { get; set; }
        public DbSet<CIM_NumericSensor> CIM_NumericSensor { get; set; }
        public DbSet<CIM_OperatingSystem> CIM_OperatingSystem { get; set; }
        public DbSet<CIM_PCVideoController> CIM_PCVideoController { get; set; }
        public DbSet<CIM_PhysicalConnector> CIM_PhysicalConnector { get; set; }
        public DbSet<CIM_PhysicalElement> CIM_PhysicalElement { get; set; }
        public DbSet<CIM_PhysicalMemory> CIM_PhysicalMemory { get; set; }
        public DbSet<CIM_PointingDevice> CIM_PointingDevice { get; set; }
        public DbSet<CIM_Printer> CIM_Printer { get; set; }
        public DbSet<CIM_Process> CIM_Process { get; set; }
        public DbSet<CIM_Processor> CIM_Processor { get; set; }
        public DbSet<CIM_Product> CIM_Product { get; set; }
        public DbSet<CIM_SCSIController> CIM_SCSIController { get; set; }
        public DbSet<CIM_Sensor> CIM_Sensor { get; set; }
        public DbSet<CIM_SerialController> CIM_SerialController { get; set; }
        public DbSet<CIM_Slot> CIM_Slot { get; set; }
        public DbSet<CIM_StorageVolume> CIM_StorageVolume { get; set; }
        public DbSet<CIM_System> CIM_System { get; set; }
        public DbSet<CIM_TemperatureSensor> CIM_TemperatureSensor { get; set; }
        public DbSet<CIM_UnitaryComputerSystem> CIM_UnitaryComputerSystem { get; set; }
        public DbSet<CIM_USBController> CIM_USBController { get; set; }
        public DbSet<CIM_USBDevice> CIM_USBDevice { get; set; }
        public DbSet<CIM_VideoController> CIM_VideoController { get; set; }
        public DbSet<CIM_VideoControllerResolution> CIM_VideoControllerResolution { get; set; }
        public DbSet<CIM_VideoSetting> CIM_VideoSetting { get; set; }
        public DbSet<CIM_VoltageSensor> CIM_VoltageSensor { get; set; }
        public DbSet<MSAcpi_ThermalZoneTemperature> MSAcpi_ThermalZoneTemperature { get; set; }
        public DbSet<MSFT_PhysicalDisk> MSFT_PhysicalDisk { get; set; }
        public DbSet<SoftwareLicensingProduct> SoftwareLicensingProduct { get; set; }
        public DbSet<SoftwareLicensingService> SoftwareLicensingService { get; set; }
        public DbSet<Win32_Account> Win32_Account { get; set; }
        public DbSet<Win32_AssociatedProcessorMemory> Win32_AssociatedProcessorMemory { get; set; }
        public DbSet<Win32_BaseBoard> Win32_BaseBoard { get; set; }
        public DbSet<Win32_Battery> Win32_Battery { get; set; }
        public DbSet<Win32_BIOS> Win32_BIOS { get; set; }
        public DbSet<Win32_Bus> Win32_Bus { get; set; }
        public DbSet<Win32_CacheMemory> Win32_CacheMemory { get; set; }
        public DbSet<Win32_CDROMDrive> Win32_CDROMDrive { get; set; }
        public DbSet<Win32_ComputerSystem> Win32_ComputerSystem { get; set; }
        public DbSet<Win32_DiskDrive> Win32_DiskDrive { get; set; }
        public DbSet<Win32_DiskPartition> Win32_DiskPartition { get; set; }
        public DbSet<Win32_Fan> Win32_Fan { get; set; }
        public DbSet<Win32_Keyboard> Win32_Keyboard { get; set; }
        public DbSet<Win32_LogicalDisk> Win32_LogicalDisk { get; set; }
        public DbSet<Win32_MotherboardDevice> Win32_MotherboardDevice { get; set; }
        public DbSet<Win32_NetworkAdapter> Win32_NetworkAdapter { get; set; }
        public DbSet<Win32_NetworkAdapterConfiguration> Win32_NetworkAdapterConfiguration { get; set; }
        public DbSet<Win32_OperatingSystem> Win32_OperatingSystem { get; set; }
        public DbSet<Win32_PhysicalMemory> Win32_PhysicalMemory { get; set; }
        public DbSet<Win32_PnPDevice> Win32_PnPDevice { get; set; }
        public DbSet<Win32_PnPEntity> Win32_PnPEntity { get; set; }
        public DbSet<Win32_PointingDevice> Win32_PointingDevice { get; set; }
        public DbSet<Win32_PortConnector> Win32_PortConnector { get; set; }
        public DbSet<Win32_PortResource> Win32_PortResource { get; set; }
        public DbSet<Win32_Printer> Win32_Printer { get; set; }
        public DbSet<Win32_Process> Win32_Process { get; set; }
        public DbSet<Win32_Processor> Win32_Processor { get; set; }
        public DbSet<Win32_SerialPort> Win32_SerialPort { get; set; }
        public DbSet<Win32_SoundDevice> Win32_SoundDevice { get; set; }
        public DbSet<Win32_TimeZone> Win32_TimeZone { get; set; }
        public DbSet<Win32_VideoController> Win32_VideoController { get; set; }
        public DbSet<Win32_VideoSettings> Win32_VideoSettings { get; set; }
        public DbSet<Win32_Volume> Win32_Volume { get; set; }
    }
}
