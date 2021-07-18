using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Databases.RetrieverCore.MasterDatabase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WmiResultsSet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmiResultsSet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BatteryFullChargedCapacity",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Frequency_Object = table.Column<decimal>(nullable: true),
                    Frequency_PerfTime = table.Column<decimal>(nullable: true),
                    Frequency_Sys100NS = table.Column<decimal>(nullable: true),
                    FullChargedCapacity = table.Column<long>(nullable: true),
                    InstanceName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Tag = table.Column<long>(nullable: true),
                    Timestamp_Object = table.Column<decimal>(nullable: true),
                    Timestamp_PerfTime = table.Column<decimal>(nullable: true),
                    Timestamp_Sys100NS = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryFullChargedCapacity", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_BatteryFullChargedCapacity_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BatteryStaticData",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Capabilities = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Chemistry = table.Column<long>(nullable: true),
                    CriticalBias = table.Column<long>(nullable: true),
                    DefaultAlert1 = table.Column<long>(nullable: true),
                    DefaultAlert2 = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesignedCapacity = table.Column<long>(nullable: true),
                    DeviceName = table.Column<string>(nullable: true),
                    Frequency_Object = table.Column<decimal>(nullable: true),
                    Frequency_PerfTime = table.Column<decimal>(nullable: true),
                    Frequency_Sys100NS = table.Column<decimal>(nullable: true),
                    Granularity0 = table.Column<decimal>(nullable: true),
                    Granularity1 = table.Column<decimal>(nullable: true),
                    Granularity2 = table.Column<decimal>(nullable: true),
                    Granularity3 = table.Column<decimal>(nullable: true),
                    InstanceName = table.Column<string>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: true),
                    ManufactureName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Tag = table.Column<long>(nullable: true),
                    Technology = table.Column<byte>(nullable: true),
                    Timestamp_Object = table.Column<decimal>(nullable: true),
                    Timestamp_PerfTime = table.Column<decimal>(nullable: true),
                    Timestamp_Sys100NS = table.Column<decimal>(nullable: true),
                    UniqueID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryStaticData", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_BatteryStaticData_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BatteryStatus",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ChargeRate = table.Column<int>(nullable: true),
                    Charging = table.Column<bool>(nullable: true),
                    Critical = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DischargeRate = table.Column<int>(nullable: true),
                    Discharging = table.Column<bool>(nullable: true),
                    Frequency_Object = table.Column<decimal>(nullable: true),
                    Frequency_PerfTime = table.Column<decimal>(nullable: true),
                    Frequency_Sys100NS = table.Column<decimal>(nullable: true),
                    InstanceName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PowerOnline = table.Column<bool>(nullable: true),
                    RemainingCapacity = table.Column<long>(nullable: true),
                    Tag = table.Column<long>(nullable: true),
                    Timestamp_Object = table.Column<decimal>(nullable: true),
                    Timestamp_PerfTime = table.Column<decimal>(nullable: true),
                    Timestamp_Sys100NS = table.Column<decimal>(nullable: true),
                    Voltage = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryStatus", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_BatteryStatus_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Battery",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BatteryRechargeTime = table.Column<long>(nullable: true),
                    BatteryStatus = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Chemistry = table.Column<int>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesignCapacity = table.Column<long>(nullable: true),
                    DesignVoltage = table.Column<decimal>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    EstimatedChargeRemaining = table.Column<int>(nullable: true),
                    EstimatedRunTime = table.Column<long>(nullable: true),
                    ExpectedBatteryLife = table.Column<long>(nullable: true),
                    ExpectedLife = table.Column<long>(nullable: true),
                    FullChargeCapacity = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxRechargeTime = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    SmartBatteryVersion = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOnBattery = table.Column<long>(nullable: true),
                    TimeToFullCharge = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Battery", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Battery_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_BIOSElement",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BiosCharacteristics = table.Column<string>(nullable: true),
                    BIOSVersion = table.Column<string>(nullable: true),
                    BuildNumber = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CodeSet = table.Column<string>(nullable: true),
                    CurrentLanguage = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EmbeddedControllerMajorVersion = table.Column<byte>(nullable: true),
                    EmbeddedControllerMinorVersion = table.Column<byte>(nullable: true),
                    IdentificationCode = table.Column<string>(nullable: true),
                    InstallableLanguages = table.Column<int>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LanguageEdition = table.Column<string>(nullable: true),
                    ListOfLanguages = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherTargetOS = table.Column<string>(nullable: true),
                    PrimaryBIOS = table.Column<bool>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SMBIOSBIOSVersion = table.Column<string>(nullable: true),
                    SMBIOSMajorVersion = table.Column<int>(nullable: true),
                    SMBIOSMinorVersion = table.Column<int>(nullable: true),
                    SMBIOSPresent = table.Column<bool>(nullable: true),
                    SoftwareElementID = table.Column<string>(nullable: true),
                    SoftwareElementState = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SystemBiosMajorVersion = table.Column<byte>(nullable: true),
                    SystemBiosMinorVersion = table.Column<byte>(nullable: true),
                    TargetOperatingSystem = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_BIOSElement", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_BIOSElement_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Card",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigOptions = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Depth = table.Column<float>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    HostingBoard = table.Column<bool>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    RequirementsDescription = table.Column<string>(nullable: true),
                    RequiresDaughterBoard = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SlotLayout = table.Column<string>(nullable: true),
                    SpecialRequirements = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: true),
                    Width = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Card", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Card_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Chip",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Attributes = table.Column<long>(nullable: true),
                    BankLabel = table.Column<string>(nullable: true),
                    Capacity = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfiguredClockSpeed = table.Column<long>(nullable: true),
                    ConfiguredVoltage = table.Column<long>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    DataWidth = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceLocator = table.Column<string>(nullable: true),
                    FormFactor = table.Column<int>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InterleaveDataDepth = table.Column<int>(nullable: true),
                    InterleavePosition = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxVoltage = table.Column<long>(nullable: true),
                    MemoryType = table.Column<int>(nullable: true),
                    MinVoltage = table.Column<long>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PositionInRow = table.Column<long>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SMBIOSMemoryType = table.Column<long>(nullable: true),
                    Speed = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    TotalWidth = table.Column<int>(nullable: true),
                    TypeDetail = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Chip", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Chip_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_ComputerSystem",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdminPasswordStatus = table.Column<int>(nullable: true),
                    AutomaticManagedPagefile = table.Column<bool>(nullable: true),
                    AutomaticResetBootOption = table.Column<bool>(nullable: true),
                    AutomaticResetCapability = table.Column<bool>(nullable: true),
                    BootOptionOnLimit = table.Column<int>(nullable: true),
                    BootOptionOnWatchDog = table.Column<int>(nullable: true),
                    BootROMSupported = table.Column<bool>(nullable: true),
                    BootStatus = table.Column<string>(nullable: true),
                    BootupState = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ChassisBootupState = table.Column<int>(nullable: true),
                    ChassisSKUNumber = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DaylightInEffect = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DNSHostName = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    DomainRole = table.Column<int>(nullable: true),
                    EnableDaylightSavingsTime = table.Column<bool>(nullable: true),
                    FrontPanelResetStatus = table.Column<int>(nullable: true),
                    HypervisorPresent = table.Column<bool>(nullable: true),
                    InfraredSupported = table.Column<bool>(nullable: true),
                    InitialLoadInfo = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KeyboardPasswordStatus = table.Column<int>(nullable: true),
                    LastLoadInfo = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameFormat = table.Column<string>(nullable: true),
                    NetworkServerModeEnabled = table.Column<bool>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    NumberOfProcessors = table.Column<long>(nullable: true),
                    OEMLogoBitmap = table.Column<string>(nullable: true),
                    OEMStringArray = table.Column<string>(nullable: true),
                    PartOfDomain = table.Column<bool>(nullable: true),
                    PauseAfterReset = table.Column<long>(nullable: true),
                    PCSystemType = table.Column<int>(nullable: true),
                    PCSystemTypeEx = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PowerOnPasswordStatus = table.Column<int>(nullable: true),
                    PowerState = table.Column<int>(nullable: true),
                    PowerSupplyState = table.Column<int>(nullable: true),
                    PrimaryOwnerContact = table.Column<string>(nullable: true),
                    PrimaryOwnerName = table.Column<string>(nullable: true),
                    ResetCapability = table.Column<int>(nullable: true),
                    ResetCount = table.Column<short>(nullable: true),
                    ResetLimit = table.Column<short>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportContactDescription = table.Column<string>(nullable: true),
                    SystemFamily = table.Column<string>(nullable: true),
                    SystemSKUNumber = table.Column<string>(nullable: true),
                    SystemStartupDelay = table.Column<int>(nullable: true),
                    SystemStartupOptions = table.Column<string>(nullable: true),
                    SystemStartupSetting = table.Column<byte>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    ThermalState = table.Column<int>(nullable: true),
                    TotalPhysicalMemory = table.Column<decimal>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    WakeUpType = table.Column<int>(nullable: true),
                    Workgroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_ComputerSystem", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_ComputerSystem_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Controller",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Controller", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Controller_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_CoolingDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ActiveCooling = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesiredSpeed = table.Column<decimal>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    VariableSpeed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_CoolingDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_CoolingDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_CurrentSensor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentReading = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLinear = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    LowerThresholdCritical = table.Column<int>(nullable: true),
                    LowerThresholdFatal = table.Column<int>(nullable: true),
                    LowerThresholdNonCritical = table.Column<int>(nullable: true),
                    MaxReadable = table.Column<int>(nullable: true),
                    MinReadable = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NominalReading = table.Column<int>(nullable: true),
                    NormalMax = table.Column<int>(nullable: true),
                    NormalMin = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Tolerance = table.Column<int>(nullable: true),
                    UpperThresholdCritical = table.Column<int>(nullable: true),
                    UpperThresholdFatal = table.Column<int>(nullable: true),
                    UpperThresholdNonCritical = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_CurrentSensor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_CurrentSensor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_DesktopMonitor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Bandwidth = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DisplayType = table.Column<int>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MonitorManufacturer = table.Column<string>(nullable: true),
                    MonitorType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PixelsPerXLogicalInch = table.Column<long>(nullable: true),
                    PixelsPerYLogicalInch = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ScreenHeight = table.Column<long>(nullable: true),
                    ScreenWidth = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_DesktopMonitor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_DesktopMonitor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_DiskDrive",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BytesPerSector = table.Column<long>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CompressionMethod = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    DefaultBlockSize = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FirmwareRevision = table.Column<string>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InterfaceType = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxBlockSize = table.Column<decimal>(nullable: true),
                    MaxMediaSize = table.Column<decimal>(nullable: true),
                    MediaLoaded = table.Column<bool>(nullable: true),
                    MediaType = table.Column<string>(nullable: true),
                    MinBlockSize = table.Column<decimal>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NeedsCleaning = table.Column<bool>(nullable: true),
                    NumberOfMediaSupported = table.Column<long>(nullable: true),
                    Partitions = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    SCSIBus = table.Column<long>(nullable: true),
                    SCSILogicalUnit = table.Column<int>(nullable: true),
                    SCSIPort = table.Column<int>(nullable: true),
                    SCSITargetId = table.Column<int>(nullable: true),
                    SectorsPerTrack = table.Column<long>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Signature = table.Column<long>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TotalCylinders = table.Column<decimal>(nullable: true),
                    TotalHeads = table.Column<long>(nullable: true),
                    TotalSectors = table.Column<decimal>(nullable: true),
                    TotalTracks = table.Column<decimal>(nullable: true),
                    TracksPerCylinder = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_DiskDrive", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_DiskDrive_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_DiskPartition",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    Bootable = table.Column<bool>(nullable: true),
                    BootPartition = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DiskIndex = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    HiddenSectors = table.Column<long>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PrimaryPartition = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    RewritePartition = table.Column<bool>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    StartingOffset = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_DiskPartition", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_DiskPartition_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Display",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Bandwidth = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DisplayType = table.Column<int>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MonitorManufacturer = table.Column<string>(nullable: true),
                    MonitorType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PixelsPerXLogicalInch = table.Column<long>(nullable: true),
                    PixelsPerYLogicalInch = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ScreenHeight = table.Column<long>(nullable: true),
                    ScreenWidth = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Display", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Display_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Fan",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ActiveCooling = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesiredSpeed = table.Column<decimal>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    VariableSpeed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Fan", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Fan_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_InstalledOS",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    GroupComponent = table.Column<string>(nullable: true),
                    PartComponent = table.Column<string>(nullable: true),
                    PrimaryOS = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_InstalledOS", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_InstalledOS_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Keyboard",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Layout = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfFunctionKeys = table.Column<int>(nullable: true),
                    Password = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Keyboard", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Keyboard_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_LogicalDisk",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Compressed = table.Column<bool>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DriveType = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FileSystem = table.Column<string>(nullable: true),
                    FreeSpace = table.Column<decimal>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaximumComponentLength = table.Column<long>(nullable: true),
                    MediaType = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProviderName = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    QuotasDisabled = table.Column<bool>(nullable: true),
                    QuotasIncomplete = table.Column<bool>(nullable: true),
                    QuotasRebuilding = table.Column<bool>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportsDiskQuotas = table.Column<bool>(nullable: true),
                    SupportsFileBasedCompression = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    VolumeDirty = table.Column<bool>(nullable: true),
                    VolumeName = table.Column<string>(nullable: true),
                    VolumeSerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_LogicalDisk", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_LogicalDisk_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Memory",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    AdditionalErrorData = table.Column<string>(nullable: true),
                    Associativity = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    CacheSpeed = table.Column<long>(nullable: true),
                    CacheType = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CorrectableError = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentSRAM = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    EndingAddress = table.Column<decimal>(nullable: true),
                    ErrorAccess = table.Column<int>(nullable: true),
                    ErrorAddress = table.Column<decimal>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorCorrectType = table.Column<int>(nullable: true),
                    ErrorData = table.Column<string>(nullable: true),
                    ErrorDataOrder = table.Column<int>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorInfo = table.Column<int>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    ErrorResolution = table.Column<decimal>(nullable: true),
                    ErrorTime = table.Column<DateTime>(nullable: true),
                    ErrorTransferSize = table.Column<long>(nullable: true),
                    FlushTimer = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstalledSize = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    LineSize = table.Column<long>(nullable: true),
                    Location = table.Column<int>(nullable: true),
                    MaxCacheSize = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    OtherErrorDescription = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    ReadPolicy = table.Column<int>(nullable: true),
                    ReplacementPolicy = table.Column<int>(nullable: true),
                    StartingAddress = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportedSRAM = table.Column<string>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemLevelAddress = table.Column<bool>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    WritePolicy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Memory", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Memory_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_NetworkAdapter",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdapterType = table.Column<string>(nullable: true),
                    AdapterTypeId = table.Column<int>(nullable: true),
                    AutoSense = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    GUID = table.Column<string>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Installed = table.Column<bool>(nullable: true),
                    InterfaceIndex = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MACAddress = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxSpeed = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NetConnectionID = table.Column<string>(nullable: true),
                    NetConnectionStatus = table.Column<int>(nullable: true),
                    NetEnabled = table.Column<bool>(nullable: true),
                    NetworkAddresses = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    PhysicalAdapter = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ServiceName = table.Column<string>(nullable: true),
                    Speed = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_NetworkAdapter", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_NetworkAdapter_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_NumericSensor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentReading = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLinear = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    LowerThresholdCritical = table.Column<int>(nullable: true),
                    LowerThresholdFatal = table.Column<int>(nullable: true),
                    LowerThresholdNonCritical = table.Column<int>(nullable: true),
                    MaxReadable = table.Column<int>(nullable: true),
                    MinReadable = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NominalReading = table.Column<int>(nullable: true),
                    NormalMax = table.Column<int>(nullable: true),
                    NormalMin = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Tolerance = table.Column<int>(nullable: true),
                    UpperThresholdCritical = table.Column<int>(nullable: true),
                    UpperThresholdFatal = table.Column<int>(nullable: true),
                    UpperThresholdNonCritical = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_NumericSensor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_NumericSensor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_OperatingSystem",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BootDevice = table.Column<string>(nullable: true),
                    BuildNumber = table.Column<string>(nullable: true),
                    BuildType = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CodeSet = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CSCreationClassName = table.Column<string>(nullable: true),
                    CSDVersion = table.Column<string>(nullable: true),
                    CSName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DataExecutionPrevention_32BitApplications = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_Available = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_Drivers = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_SupportPolicy = table.Column<byte>(nullable: true),
                    Debug = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Distributed = table.Column<bool>(nullable: true),
                    EncryptionLevel = table.Column<long>(nullable: true),
                    ForegroundApplicationBoost = table.Column<byte>(nullable: true),
                    FreePhysicalMemory = table.Column<decimal>(nullable: true),
                    FreeSpaceInPagingFiles = table.Column<decimal>(nullable: true),
                    FreeVirtualMemory = table.Column<decimal>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LargeSystemCache = table.Column<long>(nullable: true),
                    LastBootUpTime = table.Column<DateTime>(nullable: true),
                    LocalDateTime = table.Column<DateTime>(nullable: true),
                    Locale = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberOfProcesses = table.Column<long>(nullable: true),
                    MaxProcessMemorySize = table.Column<decimal>(nullable: true),
                    MUILanguages = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfLicensedUsers = table.Column<long>(nullable: true),
                    NumberOfProcesses = table.Column<long>(nullable: true),
                    NumberOfUsers = table.Column<long>(nullable: true),
                    OperatingSystemSKU = table.Column<long>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    OSArchitecture = table.Column<string>(nullable: true),
                    OSLanguage = table.Column<long>(nullable: true),
                    OSProductSuite = table.Column<long>(nullable: true),
                    OSType = table.Column<int>(nullable: true),
                    OtherTypeDescription = table.Column<string>(nullable: true),
                    PAEEnabled = table.Column<bool>(nullable: true),
                    PlusProductID = table.Column<string>(nullable: true),
                    PlusVersionNumber = table.Column<string>(nullable: true),
                    PortableOperatingSystem = table.Column<bool>(nullable: true),
                    Primary = table.Column<bool>(nullable: true),
                    ProductType = table.Column<long>(nullable: true),
                    RegisteredUser = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    ServicePackMajorVersion = table.Column<int>(nullable: true),
                    ServicePackMinorVersion = table.Column<int>(nullable: true),
                    SizeStoredInPagingFiles = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SuiteMask = table.Column<long>(nullable: true),
                    SystemDevice = table.Column<string>(nullable: true),
                    SystemDirectory = table.Column<string>(nullable: true),
                    SystemDrive = table.Column<string>(nullable: true),
                    TotalSwapSpaceSize = table.Column<decimal>(nullable: true),
                    TotalVirtualMemorySize = table.Column<decimal>(nullable: true),
                    TotalVisibleMemorySize = table.Column<decimal>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    WindowsDirectory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_OperatingSystem", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_OperatingSystem_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_PCVideoController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AcceleratorCapabilities = table.Column<string>(nullable: true),
                    AdapterCompatibility = table.Column<string>(nullable: true),
                    AdapterDACType = table.Column<string>(nullable: true),
                    AdapterRAM = table.Column<long>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ColorTableEntries = table.Column<long>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentBitsPerPixel = table.Column<long>(nullable: true),
                    CurrentHorizontalResolution = table.Column<long>(nullable: true),
                    CurrentNumberOfColors = table.Column<decimal>(nullable: true),
                    CurrentNumberOfColumns = table.Column<long>(nullable: true),
                    CurrentNumberOfRows = table.Column<long>(nullable: true),
                    CurrentRefreshRate = table.Column<long>(nullable: true),
                    CurrentScanMode = table.Column<int>(nullable: true),
                    CurrentVerticalResolution = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceSpecificPens = table.Column<long>(nullable: true),
                    DitherType = table.Column<long>(nullable: true),
                    DriverDate = table.Column<DateTime>(nullable: true),
                    DriverVersion = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ICMIntent = table.Column<long>(nullable: true),
                    ICMMethod = table.Column<long>(nullable: true),
                    InfFilename = table.Column<string>(nullable: true),
                    InfSection = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstalledDisplayDrivers = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxMemorySupported = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxRefreshRate = table.Column<long>(nullable: true),
                    MinRefreshRate = table.Column<long>(nullable: true),
                    Monochrome = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfColorPlanes = table.Column<int>(nullable: true),
                    NumberOfVideoPages = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    ReservedSystemPaletteEntries = table.Column<long>(nullable: true),
                    SpecificationVersion = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    SystemPaletteEntries = table.Column<long>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true),
                    VideoArchitecture = table.Column<int>(nullable: true),
                    VideoMemoryType = table.Column<int>(nullable: true),
                    VideoMode = table.Column<int>(nullable: true),
                    VideoModeDescription = table.Column<string>(nullable: true),
                    VideoProcessor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_PCVideoController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_PCVideoController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_PhysicalConnector",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BusNumber = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConnectorPinout = table.Column<string>(nullable: true),
                    ConnectorType = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentUsage = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceNumber = table.Column<long>(nullable: true),
                    FunctionNumber = table.Column<long>(nullable: true),
                    HeightAllowed = table.Column<float>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LengthAllowed = table.Column<float>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxDataWidth = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PMESignal = table.Column<bool>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    PurposeDescription = table.Column<string>(nullable: true),
                    SegmentGroupNumber = table.Column<long>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Shared = table.Column<bool>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SlotDesignation = table.Column<string>(nullable: true),
                    SpecialPurpose = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportsHotPlug = table.Column<bool>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    ThermalRating = table.Column<long>(nullable: true),
                    VccMixedVoltageSupport = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VppMixedVoltageSupport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_PhysicalConnector", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_PhysicalConnector_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_PhysicalElement",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigOptions = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Depth = table.Column<float>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    HostingBoard = table.Column<bool>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    RequirementsDescription = table.Column<string>(nullable: true),
                    RequiresDaughterBoard = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SlotLayout = table.Column<string>(nullable: true),
                    SpecialRequirements = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: true),
                    Width = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_PhysicalElement", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_PhysicalElement_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_PhysicalMemory",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Attributes = table.Column<long>(nullable: true),
                    BankLabel = table.Column<string>(nullable: true),
                    Capacity = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfiguredClockSpeed = table.Column<long>(nullable: true),
                    ConfiguredVoltage = table.Column<long>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    DataWidth = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceLocator = table.Column<string>(nullable: true),
                    FormFactor = table.Column<int>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InterleaveDataDepth = table.Column<int>(nullable: true),
                    InterleavePosition = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxVoltage = table.Column<long>(nullable: true),
                    MemoryType = table.Column<int>(nullable: true),
                    MinVoltage = table.Column<long>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PositionInRow = table.Column<long>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SMBIOSMemoryType = table.Column<long>(nullable: true),
                    Speed = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    TotalWidth = table.Column<int>(nullable: true),
                    TypeDetail = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_PhysicalMemory", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_PhysicalMemory_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_PointingDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceInterface = table.Column<int>(nullable: true),
                    DoubleSpeedThreshold = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    Handedness = table.Column<int>(nullable: true),
                    HardwareType = table.Column<string>(nullable: true),
                    InfFileName = table.Column<string>(nullable: true),
                    InfSection = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfButtons = table.Column<byte>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PointingType = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    QuadSpeedThreshold = table.Column<long>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    SampleRate = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Synch = table.Column<long>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_PointingDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_PointingDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Printer",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Attributes = table.Column<long>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    AvailableJobSheets = table.Column<string>(nullable: true),
                    AveragePagesPerMinute = table.Column<long>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CharSetsSupported = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentCapabilities = table.Column<string>(nullable: true),
                    CurrentCharSet = table.Column<string>(nullable: true),
                    CurrentLanguage = table.Column<int>(nullable: true),
                    CurrentMimeType = table.Column<string>(nullable: true),
                    CurrentNaturalLanguage = table.Column<string>(nullable: true),
                    CurrentPaperType = table.Column<string>(nullable: true),
                    Default = table.Column<bool>(nullable: true),
                    DefaultCapabilities = table.Column<string>(nullable: true),
                    DefaultCopies = table.Column<long>(nullable: true),
                    DefaultLanguage = table.Column<int>(nullable: true),
                    DefaultMimeType = table.Column<string>(nullable: true),
                    DefaultNumberUp = table.Column<long>(nullable: true),
                    DefaultPaperType = table.Column<string>(nullable: true),
                    DefaultPriority = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DetectedErrorState = table.Column<int>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    Direct = table.Column<bool>(nullable: true),
                    DoCompleteFirst = table.Column<bool>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    EnableBIDI = table.Column<bool>(nullable: true),
                    EnableDevQueryPrint = table.Column<bool>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorInformation = table.Column<string>(nullable: true),
                    ExtendedDetectedErrorState = table.Column<int>(nullable: true),
                    ExtendedPrinterStatus = table.Column<int>(nullable: true),
                    Hidden = table.Column<bool>(nullable: true),
                    HorizontalResolution = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    JobCountSinceLastReset = table.Column<long>(nullable: true),
                    KeepPrintedJobs = table.Column<bool>(nullable: true),
                    LanguagesSupported = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Local = table.Column<bool>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    MarkingTechnology = table.Column<int>(nullable: true),
                    MaxCopies = table.Column<long>(nullable: true),
                    MaxNumberUp = table.Column<long>(nullable: true),
                    MaxSizeSupported = table.Column<long>(nullable: true),
                    MimeTypesSupported = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NaturalLanguagesSupported = table.Column<string>(nullable: true),
                    Network = table.Column<bool>(nullable: true),
                    PaperSizesSupported = table.Column<string>(nullable: true),
                    PaperTypesAvailable = table.Column<string>(nullable: true),
                    Parameters = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PortName = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PrinterPaperNames = table.Column<string>(nullable: true),
                    PrinterState = table.Column<long>(nullable: true),
                    PrinterStatus = table.Column<int>(nullable: true),
                    PrintJobDataType = table.Column<string>(nullable: true),
                    PrintProcessor = table.Column<string>(nullable: true),
                    Priority = table.Column<long>(nullable: true),
                    Published = table.Column<bool>(nullable: true),
                    Queued = table.Column<bool>(nullable: true),
                    RawOnly = table.Column<bool>(nullable: true),
                    SeparatorFile = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    Shared = table.Column<bool>(nullable: true),
                    ShareName = table.Column<string>(nullable: true),
                    SpoolEnabled = table.Column<bool>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true),
                    UntilTime = table.Column<DateTime>(nullable: true),
                    VerticalResolution = table.Column<long>(nullable: true),
                    WorkOffline = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Printer", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Printer_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Process",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CommandLine = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    CSCreationClassName = table.Column<string>(nullable: true),
                    CSName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExecutablePath = table.Column<string>(nullable: true),
                    ExecutionState = table.Column<int>(nullable: true),
                    Handle = table.Column<string>(nullable: true),
                    HandleCount = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KernelModeTime = table.Column<decimal>(nullable: true),
                    MaximumWorkingSetSize = table.Column<long>(nullable: true),
                    MinimumWorkingSetSize = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OSCreationClassName = table.Column<string>(nullable: true),
                    OSName = table.Column<string>(nullable: true),
                    OtherOperationCount = table.Column<decimal>(nullable: true),
                    OtherTransferCount = table.Column<decimal>(nullable: true),
                    PageFaults = table.Column<long>(nullable: true),
                    PageFileUsage = table.Column<long>(nullable: true),
                    ParentProcessId = table.Column<long>(nullable: true),
                    PeakPageFileUsage = table.Column<long>(nullable: true),
                    PeakVirtualSize = table.Column<decimal>(nullable: true),
                    PeakWorkingSetSize = table.Column<long>(nullable: true),
                    Priority = table.Column<long>(nullable: true),
                    PrivatePageCount = table.Column<decimal>(nullable: true),
                    ProcessId = table.Column<long>(nullable: true),
                    QuotaNonPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPeakNonPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPeakPagedPoolUsage = table.Column<long>(nullable: true),
                    ReadOperationCount = table.Column<decimal>(nullable: true),
                    ReadTransferCount = table.Column<decimal>(nullable: true),
                    SessionId = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TerminationDate = table.Column<DateTime>(nullable: true),
                    ThreadCount = table.Column<long>(nullable: true),
                    UserModeTime = table.Column<decimal>(nullable: true),
                    VirtualSize = table.Column<decimal>(nullable: true),
                    WindowsVersion = table.Column<string>(nullable: true),
                    WorkingSetSize = table.Column<decimal>(nullable: true),
                    WriteOperationCount = table.Column<decimal>(nullable: true),
                    WriteTransferCount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Process", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Process_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Processor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AddressWidth = table.Column<int>(nullable: true),
                    Architecture = table.Column<int>(nullable: true),
                    AssetTag = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Characteristics = table.Column<long>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CpuStatus = table.Column<int>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentClockSpeed = table.Column<long>(nullable: true),
                    CurrentVoltage = table.Column<int>(nullable: true),
                    DataWidth = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ExtClock = table.Column<long>(nullable: true),
                    Family = table.Column<int>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    L2CacheSize = table.Column<long>(nullable: true),
                    L2CacheSpeed = table.Column<long>(nullable: true),
                    L3CacheSize = table.Column<long>(nullable: true),
                    L3CacheSpeed = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    LoadPercentage = table.Column<int>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxClockSpeed = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfCores = table.Column<long>(nullable: true),
                    NumberOfEnabledCore = table.Column<long>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    OtherFamilyDescription = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProcessorId = table.Column<string>(nullable: true),
                    ProcessorType = table.Column<int>(nullable: true),
                    Revision = table.Column<int>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    SecondLevelAddressTranslationExtensions = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SocketDesignation = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Stepping = table.Column<string>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    ThreadCount = table.Column<long>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true),
                    UpgradeMethod = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VirtualizationFirmwareEnabled = table.Column<bool>(nullable: true),
                    VMMonitorModeExtensions = table.Column<bool>(nullable: true),
                    VoltageCaps = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Processor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Processor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Product",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IdentifyingNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SKUNumber = table.Column<string>(nullable: true),
                    UUID = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Product", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Product_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_SCSIController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    ControllerTimeouts = table.Column<long>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceMap = table.Column<string>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    HardwareVersion = table.Column<string>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxDataWidth = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxTransferRate = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtectionManagement = table.Column<int>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_SCSIController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_SCSIController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Sensor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentReading = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLinear = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    LowerThresholdCritical = table.Column<int>(nullable: true),
                    LowerThresholdFatal = table.Column<int>(nullable: true),
                    LowerThresholdNonCritical = table.Column<int>(nullable: true),
                    MaxReadable = table.Column<int>(nullable: true),
                    MinReadable = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NominalReading = table.Column<int>(nullable: true),
                    NormalMax = table.Column<int>(nullable: true),
                    NormalMin = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Tolerance = table.Column<int>(nullable: true),
                    UpperThresholdCritical = table.Column<int>(nullable: true),
                    UpperThresholdFatal = table.Column<int>(nullable: true),
                    UpperThresholdNonCritical = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Sensor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Sensor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_SerialController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Binary = table.Column<bool>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxBaudRate = table.Column<long>(nullable: true),
                    MaximumInputBufferSize = table.Column<long>(nullable: true),
                    MaximumOutputBufferSize = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OSAutoDiscovered = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    ProviderType = table.Column<string>(nullable: true),
                    SettableBaudRate = table.Column<bool>(nullable: true),
                    SettableDataBits = table.Column<bool>(nullable: true),
                    SettableFlowControl = table.Column<bool>(nullable: true),
                    SettableParity = table.Column<bool>(nullable: true),
                    SettableParityCheck = table.Column<bool>(nullable: true),
                    SettableRLSD = table.Column<bool>(nullable: true),
                    SettableStopBits = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Supports16BitMode = table.Column<bool>(nullable: true),
                    SupportsDTRDSR = table.Column<bool>(nullable: true),
                    SupportsElapsedTimeouts = table.Column<bool>(nullable: true),
                    SupportsIntTimeouts = table.Column<bool>(nullable: true),
                    SupportsParityCheck = table.Column<bool>(nullable: true),
                    SupportsRLSD = table.Column<bool>(nullable: true),
                    SupportsRTSCTS = table.Column<bool>(nullable: true),
                    SupportsSpecialCharacters = table.Column<bool>(nullable: true),
                    SupportsXOnXOff = table.Column<bool>(nullable: true),
                    SupportsXOnXOffSet = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_SerialController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_SerialController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_Slot",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BusNumber = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConnectorPinout = table.Column<string>(nullable: true),
                    ConnectorType = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentUsage = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceNumber = table.Column<long>(nullable: true),
                    FunctionNumber = table.Column<long>(nullable: true),
                    HeightAllowed = table.Column<float>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LengthAllowed = table.Column<float>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxDataWidth = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PMESignal = table.Column<bool>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    PurposeDescription = table.Column<string>(nullable: true),
                    SegmentGroupNumber = table.Column<long>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Shared = table.Column<bool>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SlotDesignation = table.Column<string>(nullable: true),
                    SpecialPurpose = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportsHotPlug = table.Column<bool>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    ThermalRating = table.Column<long>(nullable: true),
                    VccMixedVoltageSupport = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VppMixedVoltageSupport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_Slot", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_Slot_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_StorageVolume",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Automount = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    BootVolume = table.Column<bool>(nullable: true),
                    Capacity = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Compressed = table.Column<bool>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DirtyBitSet = table.Column<bool>(nullable: true),
                    DriveLetter = table.Column<string>(nullable: true),
                    DriveType = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FileSystem = table.Column<string>(nullable: true),
                    FreeSpace = table.Column<decimal>(nullable: true),
                    IndexingEnabled = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaximumFileNameLength = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PageFilePresent = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    QuotasEnabled = table.Column<bool>(nullable: true),
                    QuotasIncomplete = table.Column<bool>(nullable: true),
                    QuotasRebuilding = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportsDiskQuotas = table.Column<bool>(nullable: true),
                    SupportsFileBasedCompression = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    SystemVolume = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_StorageVolume", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_StorageVolume_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_System",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdminPasswordStatus = table.Column<int>(nullable: true),
                    AutomaticManagedPagefile = table.Column<bool>(nullable: true),
                    AutomaticResetBootOption = table.Column<bool>(nullable: true),
                    AutomaticResetCapability = table.Column<bool>(nullable: true),
                    BootOptionOnLimit = table.Column<int>(nullable: true),
                    BootOptionOnWatchDog = table.Column<int>(nullable: true),
                    BootROMSupported = table.Column<bool>(nullable: true),
                    BootStatus = table.Column<string>(nullable: true),
                    BootupState = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ChassisBootupState = table.Column<int>(nullable: true),
                    ChassisSKUNumber = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DaylightInEffect = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DNSHostName = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    DomainRole = table.Column<int>(nullable: true),
                    EnableDaylightSavingsTime = table.Column<bool>(nullable: true),
                    FrontPanelResetStatus = table.Column<int>(nullable: true),
                    HypervisorPresent = table.Column<bool>(nullable: true),
                    InfraredSupported = table.Column<bool>(nullable: true),
                    InitialLoadInfo = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KeyboardPasswordStatus = table.Column<int>(nullable: true),
                    LastLoadInfo = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameFormat = table.Column<string>(nullable: true),
                    NetworkServerModeEnabled = table.Column<bool>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    NumberOfProcessors = table.Column<long>(nullable: true),
                    OEMLogoBitmap = table.Column<string>(nullable: true),
                    OEMStringArray = table.Column<string>(nullable: true),
                    PartOfDomain = table.Column<bool>(nullable: true),
                    PauseAfterReset = table.Column<long>(nullable: true),
                    PCSystemType = table.Column<int>(nullable: true),
                    PCSystemTypeEx = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PowerOnPasswordStatus = table.Column<int>(nullable: true),
                    PowerState = table.Column<int>(nullable: true),
                    PowerSupplyState = table.Column<int>(nullable: true),
                    PrimaryOwnerContact = table.Column<string>(nullable: true),
                    PrimaryOwnerName = table.Column<string>(nullable: true),
                    ResetCapability = table.Column<int>(nullable: true),
                    ResetCount = table.Column<short>(nullable: true),
                    ResetLimit = table.Column<short>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportContactDescription = table.Column<string>(nullable: true),
                    SystemFamily = table.Column<string>(nullable: true),
                    SystemSKUNumber = table.Column<string>(nullable: true),
                    SystemStartupDelay = table.Column<int>(nullable: true),
                    SystemStartupOptions = table.Column<string>(nullable: true),
                    SystemStartupSetting = table.Column<byte>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    ThermalState = table.Column<int>(nullable: true),
                    TotalPhysicalMemory = table.Column<decimal>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    WakeUpType = table.Column<int>(nullable: true),
                    Workgroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_System", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_System_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_TemperatureSensor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentReading = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLinear = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    LowerThresholdCritical = table.Column<int>(nullable: true),
                    LowerThresholdFatal = table.Column<int>(nullable: true),
                    LowerThresholdNonCritical = table.Column<int>(nullable: true),
                    MaxReadable = table.Column<int>(nullable: true),
                    MinReadable = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NominalReading = table.Column<int>(nullable: true),
                    NormalMax = table.Column<int>(nullable: true),
                    NormalMin = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Tolerance = table.Column<int>(nullable: true),
                    UpperThresholdCritical = table.Column<int>(nullable: true),
                    UpperThresholdFatal = table.Column<int>(nullable: true),
                    UpperThresholdNonCritical = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_TemperatureSensor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_TemperatureSensor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_UnitaryComputerSystem",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdminPasswordStatus = table.Column<int>(nullable: true),
                    AutomaticManagedPagefile = table.Column<bool>(nullable: true),
                    AutomaticResetBootOption = table.Column<bool>(nullable: true),
                    AutomaticResetCapability = table.Column<bool>(nullable: true),
                    BootOptionOnLimit = table.Column<int>(nullable: true),
                    BootOptionOnWatchDog = table.Column<int>(nullable: true),
                    BootROMSupported = table.Column<bool>(nullable: true),
                    BootStatus = table.Column<string>(nullable: true),
                    BootupState = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ChassisBootupState = table.Column<int>(nullable: true),
                    ChassisSKUNumber = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DaylightInEffect = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DNSHostName = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    DomainRole = table.Column<int>(nullable: true),
                    EnableDaylightSavingsTime = table.Column<bool>(nullable: true),
                    FrontPanelResetStatus = table.Column<int>(nullable: true),
                    HypervisorPresent = table.Column<bool>(nullable: true),
                    InfraredSupported = table.Column<bool>(nullable: true),
                    InitialLoadInfo = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KeyboardPasswordStatus = table.Column<int>(nullable: true),
                    LastLoadInfo = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameFormat = table.Column<string>(nullable: true),
                    NetworkServerModeEnabled = table.Column<bool>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    NumberOfProcessors = table.Column<long>(nullable: true),
                    OEMLogoBitmap = table.Column<string>(nullable: true),
                    OEMStringArray = table.Column<string>(nullable: true),
                    PartOfDomain = table.Column<bool>(nullable: true),
                    PauseAfterReset = table.Column<long>(nullable: true),
                    PCSystemType = table.Column<int>(nullable: true),
                    PCSystemTypeEx = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PowerOnPasswordStatus = table.Column<int>(nullable: true),
                    PowerState = table.Column<int>(nullable: true),
                    PowerSupplyState = table.Column<int>(nullable: true),
                    PrimaryOwnerContact = table.Column<string>(nullable: true),
                    PrimaryOwnerName = table.Column<string>(nullable: true),
                    ResetCapability = table.Column<int>(nullable: true),
                    ResetCount = table.Column<short>(nullable: true),
                    ResetLimit = table.Column<short>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportContactDescription = table.Column<string>(nullable: true),
                    SystemFamily = table.Column<string>(nullable: true),
                    SystemSKUNumber = table.Column<string>(nullable: true),
                    SystemStartupDelay = table.Column<int>(nullable: true),
                    SystemStartupOptions = table.Column<string>(nullable: true),
                    SystemStartupSetting = table.Column<byte>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    ThermalState = table.Column<int>(nullable: true),
                    TotalPhysicalMemory = table.Column<decimal>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    WakeUpType = table.Column<int>(nullable: true),
                    Workgroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_UnitaryComputerSystem", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_UnitaryComputerSystem_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_USBController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_USBController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_USBController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_USBDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ClassCode = table.Column<byte>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentAlternateSettings = table.Column<string>(nullable: true),
                    CurrentConfigValue = table.Column<byte>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    GangSwitched = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfConfigs = table.Column<byte>(nullable: true),
                    NumberOfPorts = table.Column<byte>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolCode = table.Column<byte>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SubclassCode = table.Column<byte>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    USBVersion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_USBDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_USBDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_VideoController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AcceleratorCapabilities = table.Column<string>(nullable: true),
                    AdapterCompatibility = table.Column<string>(nullable: true),
                    AdapterDACType = table.Column<string>(nullable: true),
                    AdapterRAM = table.Column<long>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ColorTableEntries = table.Column<long>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentBitsPerPixel = table.Column<long>(nullable: true),
                    CurrentHorizontalResolution = table.Column<long>(nullable: true),
                    CurrentNumberOfColors = table.Column<decimal>(nullable: true),
                    CurrentNumberOfColumns = table.Column<long>(nullable: true),
                    CurrentNumberOfRows = table.Column<long>(nullable: true),
                    CurrentRefreshRate = table.Column<long>(nullable: true),
                    CurrentScanMode = table.Column<int>(nullable: true),
                    CurrentVerticalResolution = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceSpecificPens = table.Column<long>(nullable: true),
                    DitherType = table.Column<long>(nullable: true),
                    DriverDate = table.Column<DateTime>(nullable: true),
                    DriverVersion = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ICMIntent = table.Column<long>(nullable: true),
                    ICMMethod = table.Column<long>(nullable: true),
                    InfFilename = table.Column<string>(nullable: true),
                    InfSection = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstalledDisplayDrivers = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxMemorySupported = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxRefreshRate = table.Column<long>(nullable: true),
                    MinRefreshRate = table.Column<long>(nullable: true),
                    Monochrome = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfColorPlanes = table.Column<int>(nullable: true),
                    NumberOfVideoPages = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    ReservedSystemPaletteEntries = table.Column<long>(nullable: true),
                    SpecificationVersion = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    SystemPaletteEntries = table.Column<long>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true),
                    VideoArchitecture = table.Column<int>(nullable: true),
                    VideoMemoryType = table.Column<int>(nullable: true),
                    VideoMode = table.Column<int>(nullable: true),
                    VideoModeDescription = table.Column<string>(nullable: true),
                    VideoProcessor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_VideoController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_VideoController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_VideoControllerResolution",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HorizontalResolution = table.Column<long>(nullable: true),
                    MaxRefreshRate = table.Column<long>(nullable: true),
                    MinRefreshRate = table.Column<long>(nullable: true),
                    NumberOfColors = table.Column<decimal>(nullable: true),
                    RefreshRate = table.Column<long>(nullable: true),
                    ScanMode = table.Column<int>(nullable: true),
                    SettingID = table.Column<string>(nullable: true),
                    VerticalResolution = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_VideoControllerResolution", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_VideoControllerResolution_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_VideoSetting",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Element = table.Column<string>(nullable: true),
                    Setting = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_VideoSetting", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_VideoSetting_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIM_VoltageSensor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentReading = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLinear = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    LowerThresholdCritical = table.Column<int>(nullable: true),
                    LowerThresholdFatal = table.Column<int>(nullable: true),
                    LowerThresholdNonCritical = table.Column<int>(nullable: true),
                    MaxReadable = table.Column<int>(nullable: true),
                    MinReadable = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NominalReading = table.Column<int>(nullable: true),
                    NormalMax = table.Column<int>(nullable: true),
                    NormalMin = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Tolerance = table.Column<int>(nullable: true),
                    UpperThresholdCritical = table.Column<int>(nullable: true),
                    UpperThresholdFatal = table.Column<int>(nullable: true),
                    UpperThresholdNonCritical = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIM_VoltageSensor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_CIM_VoltageSensor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MSAcpi_ThermalZoneTemperature",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    ActiveTripPoint = table.Column<string>(nullable: true),
                    ActiveTripPointCount = table.Column<long>(nullable: true),
                    CriticalTripPoint = table.Column<long>(nullable: true),
                    CurrentTemperature = table.Column<long>(nullable: true),
                    InstanceName = table.Column<string>(nullable: true),
                    PassiveTripPoint = table.Column<long>(nullable: true),
                    Reserved = table.Column<long>(nullable: true),
                    SamplingPeriod = table.Column<long>(nullable: true),
                    ThermalConstant1 = table.Column<long>(nullable: true),
                    ThermalConstant2 = table.Column<long>(nullable: true),
                    ThermalStamp = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSAcpi_ThermalZoneTemperature", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_MSAcpi_ThermalZoneTemperature_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MSFT_PhysicalDisk",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdapterSerialNumber = table.Column<string>(nullable: true),
                    AllocatedSize = table.Column<decimal>(nullable: true),
                    BusType = table.Column<int>(nullable: true),
                    CannotPoolReason = table.Column<string>(nullable: true),
                    CanPool = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceId = table.Column<string>(nullable: true),
                    EnclosureNumber = table.Column<int>(nullable: true),
                    FirmwareVersion = table.Column<string>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    HealthStatus = table.Column<int>(nullable: true),
                    IsIndicationEnabled = table.Column<bool>(nullable: true),
                    IsPartial = table.Column<bool>(nullable: true),
                    LogicalSectorSize = table.Column<decimal>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MediaType = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ObjectId = table.Column<string>(nullable: true),
                    OperationalDetails = table.Column<string>(nullable: true),
                    OperationalStatus = table.Column<string>(nullable: true),
                    OtherCannotPoolReasonDescription = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PassThroughClass = table.Column<string>(nullable: true),
                    PassThroughIds = table.Column<string>(nullable: true),
                    PassThroughNamespace = table.Column<string>(nullable: true),
                    PassThroughServer = table.Column<string>(nullable: true),
                    PhysicalLocation = table.Column<string>(nullable: true),
                    PhysicalSectorSize = table.Column<decimal>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    SlotNumber = table.Column<int>(nullable: true),
                    SoftwareVersion = table.Column<string>(nullable: true),
                    SpindleSpeed = table.Column<long>(nullable: true),
                    StoragePoolUniqueId = table.Column<string>(nullable: true),
                    SupportedUsages = table.Column<string>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true),
                    UniqueIdFormat = table.Column<int>(nullable: true),
                    Usage = table.Column<int>(nullable: true),
                    VirtualDiskFootprint = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSFT_PhysicalDisk", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_MSFT_PhysicalDisk_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareLicensingProduct",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ADActivationCsvlkPid = table.Column<string>(nullable: true),
                    ADActivationCsvlkSkuId = table.Column<string>(nullable: true),
                    ADActivationObjectDN = table.Column<string>(nullable: true),
                    ADActivationObjectName = table.Column<string>(nullable: true),
                    ApplicationID = table.Column<string>(nullable: true),
                    AutomaticVMActivationHostDigitalPid2 = table.Column<string>(nullable: true),
                    AutomaticVMActivationHostMachineName = table.Column<string>(nullable: true),
                    AutomaticVMActivationLastActivationTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachineIpAddress = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachineName = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachinePort = table.Column<long>(nullable: true),
                    EvaluationEndDate = table.Column<DateTime>(nullable: true),
                    ExtendedGrace = table.Column<long>(nullable: true),
                    GenuineStatus = table.Column<long>(nullable: true),
                    GracePeriodRemaining = table.Column<long>(nullable: true),
                    IAID = table.Column<string>(nullable: true),
                    ID = table.Column<string>(nullable: true),
                    IsKeyManagementServiceMachine = table.Column<long>(nullable: true),
                    KeyManagementServiceCurrentCount = table.Column<long>(nullable: true),
                    KeyManagementServiceFailedRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceLicensedRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceLookupDomain = table.Column<string>(nullable: true),
                    KeyManagementServiceMachine = table.Column<string>(nullable: true),
                    KeyManagementServiceNonGenuineGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceNotificationRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceOOBGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceOOTGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServicePort = table.Column<long>(nullable: true),
                    KeyManagementServiceProductKeyID = table.Column<string>(nullable: true),
                    KeyManagementServiceTotalRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceUnlicensedRequests = table.Column<long>(nullable: true),
                    LicenseDependsOn = table.Column<string>(nullable: true),
                    LicenseFamily = table.Column<string>(nullable: true),
                    LicenseIsAddon = table.Column<bool>(nullable: true),
                    LicenseStatus = table.Column<long>(nullable: true),
                    LicenseStatusReason = table.Column<long>(nullable: true),
                    MachineURL = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OfflineInstallationId = table.Column<string>(nullable: true),
                    PartialProductKey = table.Column<string>(nullable: true),
                    ProcessorURL = table.Column<string>(nullable: true),
                    ProductKeyChannel = table.Column<string>(nullable: true),
                    ProductKeyID = table.Column<string>(nullable: true),
                    ProductKeyID2 = table.Column<string>(nullable: true),
                    ProductKeyURL = table.Column<string>(nullable: true),
                    RemainingAppReArmCount = table.Column<long>(nullable: true),
                    RemainingSkuReArmCount = table.Column<long>(nullable: true),
                    RequiredClientCount = table.Column<long>(nullable: true),
                    TokenActivationAdditionalInfo = table.Column<string>(nullable: true),
                    TokenActivationCertificateThumbprint = table.Column<string>(nullable: true),
                    TokenActivationGrantNumber = table.Column<long>(nullable: true),
                    TokenActivationILID = table.Column<string>(nullable: true),
                    TokenActivationILVID = table.Column<long>(nullable: true),
                    TrustedTime = table.Column<DateTime>(nullable: true),
                    UseLicenseURL = table.Column<string>(nullable: true),
                    ValidationURL = table.Column<string>(nullable: true),
                    VLActivationInterval = table.Column<long>(nullable: true),
                    VLActivationType = table.Column<long>(nullable: true),
                    VLActivationTypeEnabled = table.Column<long>(nullable: true),
                    VLRenewalInterval = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareLicensingProduct", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_SoftwareLicensingProduct_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareLicensingService",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ClientMachineID = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachineIpAddress = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachineName = table.Column<string>(nullable: true),
                    DiscoveredKeyManagementServiceMachinePort = table.Column<long>(nullable: true),
                    IsKeyManagementServiceMachine = table.Column<long>(nullable: true),
                    KeyManagementServiceCurrentCount = table.Column<long>(nullable: true),
                    KeyManagementServiceDnsPublishing = table.Column<bool>(nullable: true),
                    KeyManagementServiceFailedRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceHostCaching = table.Column<bool>(nullable: true),
                    KeyManagementServiceLicensedRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceListeningPort = table.Column<long>(nullable: true),
                    KeyManagementServiceLookupDomain = table.Column<string>(nullable: true),
                    KeyManagementServiceLowPriority = table.Column<bool>(nullable: true),
                    KeyManagementServiceMachine = table.Column<string>(nullable: true),
                    KeyManagementServiceNonGenuineGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceNotificationRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceOOBGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceOOTGraceRequests = table.Column<long>(nullable: true),
                    KeyManagementServicePort = table.Column<long>(nullable: true),
                    KeyManagementServiceProductKeyID = table.Column<string>(nullable: true),
                    KeyManagementServiceTotalRequests = table.Column<long>(nullable: true),
                    KeyManagementServiceUnlicensedRequests = table.Column<long>(nullable: true),
                    OA2xBiosMarkerMinorVersion = table.Column<long>(nullable: true),
                    OA2xBiosMarkerStatus = table.Column<long>(nullable: true),
                    OA3xOriginalProductKey = table.Column<string>(nullable: true),
                    OA3xOriginalProductKeyDescription = table.Column<string>(nullable: true),
                    OA3xOriginalProductKeyPkPn = table.Column<string>(nullable: true),
                    PolicyCacheRefreshRequired = table.Column<long>(nullable: true),
                    RemainingWindowsReArmCount = table.Column<long>(nullable: true),
                    RequiredClientCount = table.Column<long>(nullable: true),
                    TokenActivationAdditionalInfo = table.Column<string>(nullable: true),
                    TokenActivationCertificateThumbprint = table.Column<string>(nullable: true),
                    TokenActivationGrantNumber = table.Column<long>(nullable: true),
                    TokenActivationILID = table.Column<string>(nullable: true),
                    TokenActivationILVID = table.Column<long>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VLActivationInterval = table.Column<long>(nullable: true),
                    VLRenewalInterval = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareLicensingService", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_SoftwareLicensingService_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Account",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LocalAccount = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SID = table.Column<string>(nullable: true),
                    SIDType = table.Column<byte>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Account", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Account_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_AssociatedProcessorMemory",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Antecedent = table.Column<string>(nullable: true),
                    BusSpeed = table.Column<long>(nullable: true),
                    Dependent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_AssociatedProcessorMemory", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_AssociatedProcessorMemory_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_BaseBoard",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigOptions = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Depth = table.Column<float>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    HostingBoard = table.Column<bool>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    RequirementsDescription = table.Column<string>(nullable: true),
                    RequiresDaughterBoard = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SlotLayout = table.Column<string>(nullable: true),
                    SpecialRequirements = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: true),
                    Width = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_BaseBoard", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_BaseBoard_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Battery",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BatteryRechargeTime = table.Column<long>(nullable: true),
                    BatteryStatus = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Chemistry = table.Column<int>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesignCapacity = table.Column<long>(nullable: true),
                    DesignVoltage = table.Column<decimal>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    EstimatedChargeRemaining = table.Column<int>(nullable: true),
                    EstimatedRunTime = table.Column<long>(nullable: true),
                    ExpectedBatteryLife = table.Column<long>(nullable: true),
                    ExpectedLife = table.Column<long>(nullable: true),
                    FullChargeCapacity = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxRechargeTime = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    SmartBatteryVersion = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOnBattery = table.Column<long>(nullable: true),
                    TimeToFullCharge = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Battery", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Battery_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_BIOS",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BiosCharacteristics = table.Column<string>(nullable: true),
                    BIOSVersion = table.Column<string>(nullable: true),
                    BuildNumber = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CodeSet = table.Column<string>(nullable: true),
                    CurrentLanguage = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EmbeddedControllerMajorVersion = table.Column<byte>(nullable: true),
                    EmbeddedControllerMinorVersion = table.Column<byte>(nullable: true),
                    IdentificationCode = table.Column<string>(nullable: true),
                    InstallableLanguages = table.Column<int>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LanguageEdition = table.Column<string>(nullable: true),
                    ListOfLanguages = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherTargetOS = table.Column<string>(nullable: true),
                    PrimaryBIOS = table.Column<bool>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SMBIOSBIOSVersion = table.Column<string>(nullable: true),
                    SMBIOSMajorVersion = table.Column<int>(nullable: true),
                    SMBIOSMinorVersion = table.Column<int>(nullable: true),
                    SMBIOSPresent = table.Column<bool>(nullable: true),
                    SoftwareElementID = table.Column<string>(nullable: true),
                    SoftwareElementState = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SystemBiosMajorVersion = table.Column<byte>(nullable: true),
                    SystemBiosMinorVersion = table.Column<byte>(nullable: true),
                    TargetOperatingSystem = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_BIOS", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_BIOS_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Bus",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BusNum = table.Column<long>(nullable: true),
                    BusType = table.Column<long>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Bus", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Bus_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_CacheMemory",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    AdditionalErrorData = table.Column<string>(nullable: true),
                    Associativity = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    CacheSpeed = table.Column<long>(nullable: true),
                    CacheType = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CorrectableError = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentSRAM = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    EndingAddress = table.Column<decimal>(nullable: true),
                    ErrorAccess = table.Column<int>(nullable: true),
                    ErrorAddress = table.Column<decimal>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorCorrectType = table.Column<int>(nullable: true),
                    ErrorData = table.Column<string>(nullable: true),
                    ErrorDataOrder = table.Column<int>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorInfo = table.Column<int>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    ErrorResolution = table.Column<decimal>(nullable: true),
                    ErrorTime = table.Column<DateTime>(nullable: true),
                    ErrorTransferSize = table.Column<long>(nullable: true),
                    FlushTimer = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstalledSize = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    LineSize = table.Column<long>(nullable: true),
                    Location = table.Column<int>(nullable: true),
                    MaxCacheSize = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    OtherErrorDescription = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    ReadPolicy = table.Column<int>(nullable: true),
                    ReplacementPolicy = table.Column<int>(nullable: true),
                    StartingAddress = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportedSRAM = table.Column<string>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemLevelAddress = table.Column<bool>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    WritePolicy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_CacheMemory", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_CacheMemory_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_CDROMDrive",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_CDROMDrive", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_CDROMDrive_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_ComputerSystem",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdminPasswordStatus = table.Column<int>(nullable: true),
                    AutomaticManagedPagefile = table.Column<bool>(nullable: true),
                    AutomaticResetBootOption = table.Column<bool>(nullable: true),
                    AutomaticResetCapability = table.Column<bool>(nullable: true),
                    BootOptionOnLimit = table.Column<int>(nullable: true),
                    BootOptionOnWatchDog = table.Column<int>(nullable: true),
                    BootROMSupported = table.Column<bool>(nullable: true),
                    BootStatus = table.Column<string>(nullable: true),
                    BootupState = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ChassisBootupState = table.Column<int>(nullable: true),
                    ChassisSKUNumber = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DaylightInEffect = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DNSHostName = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    DomainRole = table.Column<int>(nullable: true),
                    EnableDaylightSavingsTime = table.Column<bool>(nullable: true),
                    FrontPanelResetStatus = table.Column<int>(nullable: true),
                    HypervisorPresent = table.Column<bool>(nullable: true),
                    InfraredSupported = table.Column<bool>(nullable: true),
                    InitialLoadInfo = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KeyboardPasswordStatus = table.Column<int>(nullable: true),
                    LastLoadInfo = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameFormat = table.Column<string>(nullable: true),
                    NetworkServerModeEnabled = table.Column<bool>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    NumberOfProcessors = table.Column<long>(nullable: true),
                    OEMLogoBitmap = table.Column<string>(nullable: true),
                    OEMStringArray = table.Column<string>(nullable: true),
                    PartOfDomain = table.Column<bool>(nullable: true),
                    PauseAfterReset = table.Column<long>(nullable: true),
                    PCSystemType = table.Column<int>(nullable: true),
                    PCSystemTypeEx = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PowerOnPasswordStatus = table.Column<int>(nullable: true),
                    PowerState = table.Column<int>(nullable: true),
                    PowerSupplyState = table.Column<int>(nullable: true),
                    PrimaryOwnerContact = table.Column<string>(nullable: true),
                    PrimaryOwnerName = table.Column<string>(nullable: true),
                    ResetCapability = table.Column<int>(nullable: true),
                    ResetCount = table.Column<short>(nullable: true),
                    ResetLimit = table.Column<short>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SupportContactDescription = table.Column<string>(nullable: true),
                    SystemFamily = table.Column<string>(nullable: true),
                    SystemSKUNumber = table.Column<string>(nullable: true),
                    SystemStartupDelay = table.Column<int>(nullable: true),
                    SystemStartupOptions = table.Column<string>(nullable: true),
                    SystemStartupSetting = table.Column<byte>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    ThermalState = table.Column<int>(nullable: true),
                    TotalPhysicalMemory = table.Column<decimal>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    WakeUpType = table.Column<int>(nullable: true),
                    Workgroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_ComputerSystem", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_ComputerSystem_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_DiskDrive",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BytesPerSector = table.Column<long>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CompressionMethod = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    DefaultBlockSize = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FirmwareRevision = table.Column<string>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InterfaceType = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxBlockSize = table.Column<decimal>(nullable: true),
                    MaxMediaSize = table.Column<decimal>(nullable: true),
                    MediaLoaded = table.Column<bool>(nullable: true),
                    MediaType = table.Column<string>(nullable: true),
                    MinBlockSize = table.Column<decimal>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NeedsCleaning = table.Column<bool>(nullable: true),
                    NumberOfMediaSupported = table.Column<long>(nullable: true),
                    Partitions = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    SCSIBus = table.Column<long>(nullable: true),
                    SCSILogicalUnit = table.Column<int>(nullable: true),
                    SCSIPort = table.Column<int>(nullable: true),
                    SCSITargetId = table.Column<int>(nullable: true),
                    SectorsPerTrack = table.Column<long>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Signature = table.Column<long>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TotalCylinders = table.Column<decimal>(nullable: true),
                    TotalHeads = table.Column<long>(nullable: true),
                    TotalSectors = table.Column<decimal>(nullable: true),
                    TotalTracks = table.Column<decimal>(nullable: true),
                    TracksPerCylinder = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_DiskDrive", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_DiskDrive_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_DiskPartition",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    Bootable = table.Column<bool>(nullable: true),
                    BootPartition = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DiskIndex = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    HiddenSectors = table.Column<long>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PrimaryPartition = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    RewritePartition = table.Column<bool>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    StartingOffset = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_DiskPartition", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_DiskPartition_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Fan",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ActiveCooling = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesiredSpeed = table.Column<decimal>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    VariableSpeed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Fan", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Fan_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Keyboard",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Layout = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfFunctionKeys = table.Column<int>(nullable: true),
                    Password = table.Column<int>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Keyboard", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Keyboard_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_LogicalDisk",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Compressed = table.Column<bool>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DriveType = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FileSystem = table.Column<string>(nullable: true),
                    FreeSpace = table.Column<decimal>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaximumComponentLength = table.Column<long>(nullable: true),
                    MediaType = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProviderName = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    QuotasDisabled = table.Column<bool>(nullable: true),
                    QuotasIncomplete = table.Column<bool>(nullable: true),
                    QuotasRebuilding = table.Column<bool>(nullable: true),
                    Size = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportsDiskQuotas = table.Column<bool>(nullable: true),
                    SupportsFileBasedCompression = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    VolumeDirty = table.Column<bool>(nullable: true),
                    VolumeName = table.Column<string>(nullable: true),
                    VolumeSerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_LogicalDisk", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_LogicalDisk_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_MotherboardDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PrimaryBusType = table.Column<string>(nullable: true),
                    RevisionNumber = table.Column<string>(nullable: true),
                    SecondaryBusType = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_MotherboardDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_MotherboardDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_NetworkAdapter",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AdapterType = table.Column<string>(nullable: true),
                    AdapterTypeId = table.Column<int>(nullable: true),
                    AutoSense = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    GUID = table.Column<string>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Installed = table.Column<bool>(nullable: true),
                    InterfaceIndex = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MACAddress = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxSpeed = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NetConnectionID = table.Column<string>(nullable: true),
                    NetConnectionStatus = table.Column<int>(nullable: true),
                    NetEnabled = table.Column<bool>(nullable: true),
                    NetworkAddresses = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    PhysicalAdapter = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ServiceName = table.Column<string>(nullable: true),
                    Speed = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_NetworkAdapter", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_NetworkAdapter_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_NetworkAdapterConfiguration",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    ArpAlwaysSourceRoute = table.Column<bool>(nullable: true),
                    ArpUseEtherSNAP = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    DatabasePath = table.Column<string>(nullable: true),
                    DeadGWDetectEnabled = table.Column<bool>(nullable: true),
                    DefaultIPGateway = table.Column<string>(nullable: true),
                    DefaultTOS = table.Column<byte>(nullable: true),
                    DefaultTTL = table.Column<byte>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DHCPEnabled = table.Column<bool>(nullable: true),
                    DHCPLeaseExpires = table.Column<DateTime>(nullable: true),
                    DHCPLeaseObtained = table.Column<DateTime>(nullable: true),
                    DHCPServer = table.Column<string>(nullable: true),
                    DNSDomain = table.Column<string>(nullable: true),
                    DNSDomainSuffixSearchOrder = table.Column<string>(nullable: true),
                    DNSEnabledForWINSResolution = table.Column<bool>(nullable: true),
                    DNSHostName = table.Column<string>(nullable: true),
                    DNSServerSearchOrder = table.Column<string>(nullable: true),
                    DomainDNSRegistrationEnabled = table.Column<bool>(nullable: true),
                    ForwardBufferMemory = table.Column<long>(nullable: true),
                    FullDNSRegistrationEnabled = table.Column<bool>(nullable: true),
                    GatewayCostMetric = table.Column<string>(nullable: true),
                    IGMPLevel = table.Column<byte>(nullable: true),
                    Index = table.Column<long>(nullable: true),
                    InterfaceIndex = table.Column<long>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    IPConnectionMetric = table.Column<long>(nullable: true),
                    IPEnabled = table.Column<bool>(nullable: true),
                    IPFilterSecurityEnabled = table.Column<bool>(nullable: true),
                    IPPortSecurityEnabled = table.Column<bool>(nullable: true),
                    IPSecPermitIPProtocols = table.Column<string>(nullable: true),
                    IPSecPermitTCPPorts = table.Column<string>(nullable: true),
                    IPSecPermitUDPPorts = table.Column<string>(nullable: true),
                    IPSubnet = table.Column<string>(nullable: true),
                    IPUseZeroBroadcast = table.Column<bool>(nullable: true),
                    IPXAddress = table.Column<string>(nullable: true),
                    IPXEnabled = table.Column<bool>(nullable: true),
                    IPXFrameType = table.Column<string>(nullable: true),
                    IPXMediaType = table.Column<long>(nullable: true),
                    IPXNetworkNumber = table.Column<string>(nullable: true),
                    IPXVirtualNetNumber = table.Column<string>(nullable: true),
                    KeepAliveInterval = table.Column<long>(nullable: true),
                    KeepAliveTime = table.Column<long>(nullable: true),
                    MACAddress = table.Column<string>(nullable: true),
                    MTU = table.Column<long>(nullable: true),
                    NumForwardPackets = table.Column<long>(nullable: true),
                    PMTUBHDetectEnabled = table.Column<bool>(nullable: true),
                    PMTUDiscoveryEnabled = table.Column<bool>(nullable: true),
                    ServiceName = table.Column<string>(nullable: true),
                    SettingID = table.Column<string>(nullable: true),
                    TcpipNetbiosOptions = table.Column<long>(nullable: true),
                    TcpMaxConnectRetransmissions = table.Column<long>(nullable: true),
                    TcpMaxDataRetransmissions = table.Column<long>(nullable: true),
                    TcpNumConnections = table.Column<long>(nullable: true),
                    TcpUseRFC1122UrgentPointer = table.Column<bool>(nullable: true),
                    TcpWindowSize = table.Column<int>(nullable: true),
                    WINSEnableLMHostsLookup = table.Column<bool>(nullable: true),
                    WINSHostLookupFile = table.Column<string>(nullable: true),
                    WINSPrimaryServer = table.Column<string>(nullable: true),
                    WINSScopeID = table.Column<string>(nullable: true),
                    WINSSecondaryServer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_NetworkAdapterConfiguration", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_NetworkAdapterConfiguration_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_OperatingSystem",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    BootDevice = table.Column<string>(nullable: true),
                    BuildNumber = table.Column<string>(nullable: true),
                    BuildType = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CodeSet = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CSCreationClassName = table.Column<string>(nullable: true),
                    CSDVersion = table.Column<string>(nullable: true),
                    CSName = table.Column<string>(nullable: true),
                    CurrentTimeZone = table.Column<short>(nullable: true),
                    DataExecutionPrevention_32BitApplications = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_Available = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_Drivers = table.Column<bool>(nullable: true),
                    DataExecutionPrevention_SupportPolicy = table.Column<byte>(nullable: true),
                    Debug = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Distributed = table.Column<bool>(nullable: true),
                    EncryptionLevel = table.Column<long>(nullable: true),
                    ForegroundApplicationBoost = table.Column<byte>(nullable: true),
                    FreePhysicalMemory = table.Column<decimal>(nullable: true),
                    FreeSpaceInPagingFiles = table.Column<decimal>(nullable: true),
                    FreeVirtualMemory = table.Column<decimal>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LargeSystemCache = table.Column<long>(nullable: true),
                    LastBootUpTime = table.Column<DateTime>(nullable: true),
                    LocalDateTime = table.Column<DateTime>(nullable: true),
                    Locale = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxNumberOfProcesses = table.Column<long>(nullable: true),
                    MaxProcessMemorySize = table.Column<decimal>(nullable: true),
                    MUILanguages = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfLicensedUsers = table.Column<long>(nullable: true),
                    NumberOfProcesses = table.Column<long>(nullable: true),
                    NumberOfUsers = table.Column<long>(nullable: true),
                    OperatingSystemSKU = table.Column<long>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    OSArchitecture = table.Column<string>(nullable: true),
                    OSLanguage = table.Column<long>(nullable: true),
                    OSProductSuite = table.Column<long>(nullable: true),
                    OSType = table.Column<int>(nullable: true),
                    OtherTypeDescription = table.Column<string>(nullable: true),
                    PAEEnabled = table.Column<bool>(nullable: true),
                    PlusProductID = table.Column<string>(nullable: true),
                    PlusVersionNumber = table.Column<string>(nullable: true),
                    PortableOperatingSystem = table.Column<bool>(nullable: true),
                    Primary = table.Column<bool>(nullable: true),
                    ProductType = table.Column<long>(nullable: true),
                    RegisteredUser = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    ServicePackMajorVersion = table.Column<int>(nullable: true),
                    ServicePackMinorVersion = table.Column<int>(nullable: true),
                    SizeStoredInPagingFiles = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SuiteMask = table.Column<long>(nullable: true),
                    SystemDevice = table.Column<string>(nullable: true),
                    SystemDirectory = table.Column<string>(nullable: true),
                    SystemDrive = table.Column<string>(nullable: true),
                    TotalSwapSpaceSize = table.Column<decimal>(nullable: true),
                    TotalVirtualMemorySize = table.Column<decimal>(nullable: true),
                    TotalVisibleMemorySize = table.Column<decimal>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    WindowsDirectory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_OperatingSystem", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_OperatingSystem_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PhysicalMemory",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Attributes = table.Column<long>(nullable: true),
                    BankLabel = table.Column<string>(nullable: true),
                    Capacity = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfiguredClockSpeed = table.Column<long>(nullable: true),
                    ConfiguredVoltage = table.Column<long>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    DataWidth = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceLocator = table.Column<string>(nullable: true),
                    FormFactor = table.Column<int>(nullable: true),
                    HotSwappable = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InterleaveDataDepth = table.Column<int>(nullable: true),
                    InterleavePosition = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxVoltage = table.Column<long>(nullable: true),
                    MemoryType = table.Column<int>(nullable: true),
                    MinVoltage = table.Column<long>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PositionInRow = table.Column<long>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    Removable = table.Column<bool>(nullable: true),
                    Replaceable = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SMBIOSMemoryType = table.Column<long>(nullable: true),
                    Speed = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    TotalWidth = table.Column<int>(nullable: true),
                    TypeDetail = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PhysicalMemory", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PhysicalMemory_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PnPDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    SameElement = table.Column<string>(nullable: true),
                    SystemElement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PnPDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PnPDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PnPEntity",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ClassGuid = table.Column<string>(nullable: true),
                    CompatibleID = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    HardwareID = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPClass = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Present = table.Column<bool>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PnPEntity", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PnPEntity_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PointingDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceInterface = table.Column<int>(nullable: true),
                    DoubleSpeedThreshold = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    Handedness = table.Column<int>(nullable: true),
                    HardwareType = table.Column<string>(nullable: true),
                    InfFileName = table.Column<string>(nullable: true),
                    InfSection = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfButtons = table.Column<byte>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PointingType = table.Column<int>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    QuadSpeedThreshold = table.Column<long>(nullable: true),
                    Resolution = table.Column<long>(nullable: true),
                    SampleRate = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Synch = table.Column<long>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PointingDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PointingDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PortConnector",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConnectorPinout = table.Column<string>(nullable: true),
                    ConnectorType = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExternalReferenceDesignator = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InternalReferenceDesignator = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtherIdentifyingInfo = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PortType = table.Column<int>(nullable: true),
                    PoweredOn = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PortConnector", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PortConnector_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_PortResource",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Alias = table.Column<bool>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CSCreationClassName = table.Column<string>(nullable: true),
                    CSName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndingAddress = table.Column<decimal>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StartingAddress = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_PortResource", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_PortResource_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Printer",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Attributes = table.Column<long>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    AvailableJobSheets = table.Column<string>(nullable: true),
                    AveragePagesPerMinute = table.Column<long>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CharSetsSupported = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentCapabilities = table.Column<string>(nullable: true),
                    CurrentCharSet = table.Column<string>(nullable: true),
                    CurrentLanguage = table.Column<int>(nullable: true),
                    CurrentMimeType = table.Column<string>(nullable: true),
                    CurrentNaturalLanguage = table.Column<string>(nullable: true),
                    CurrentPaperType = table.Column<string>(nullable: true),
                    Default = table.Column<bool>(nullable: true),
                    DefaultCapabilities = table.Column<string>(nullable: true),
                    DefaultCopies = table.Column<long>(nullable: true),
                    DefaultLanguage = table.Column<int>(nullable: true),
                    DefaultMimeType = table.Column<string>(nullable: true),
                    DefaultNumberUp = table.Column<long>(nullable: true),
                    DefaultPaperType = table.Column<string>(nullable: true),
                    DefaultPriority = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DetectedErrorState = table.Column<int>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    Direct = table.Column<bool>(nullable: true),
                    DoCompleteFirst = table.Column<bool>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    EnableBIDI = table.Column<bool>(nullable: true),
                    EnableDevQueryPrint = table.Column<bool>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorInformation = table.Column<string>(nullable: true),
                    ExtendedDetectedErrorState = table.Column<int>(nullable: true),
                    ExtendedPrinterStatus = table.Column<int>(nullable: true),
                    Hidden = table.Column<bool>(nullable: true),
                    HorizontalResolution = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    JobCountSinceLastReset = table.Column<long>(nullable: true),
                    KeepPrintedJobs = table.Column<bool>(nullable: true),
                    LanguagesSupported = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Local = table.Column<bool>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    MarkingTechnology = table.Column<int>(nullable: true),
                    MaxCopies = table.Column<long>(nullable: true),
                    MaxNumberUp = table.Column<long>(nullable: true),
                    MaxSizeSupported = table.Column<long>(nullable: true),
                    MimeTypesSupported = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NaturalLanguagesSupported = table.Column<string>(nullable: true),
                    Network = table.Column<bool>(nullable: true),
                    PaperSizesSupported = table.Column<string>(nullable: true),
                    PaperTypesAvailable = table.Column<string>(nullable: true),
                    Parameters = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PortName = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    PrinterPaperNames = table.Column<string>(nullable: true),
                    PrinterState = table.Column<long>(nullable: true),
                    PrinterStatus = table.Column<int>(nullable: true),
                    PrintJobDataType = table.Column<string>(nullable: true),
                    PrintProcessor = table.Column<string>(nullable: true),
                    Priority = table.Column<long>(nullable: true),
                    Published = table.Column<bool>(nullable: true),
                    Queued = table.Column<bool>(nullable: true),
                    RawOnly = table.Column<bool>(nullable: true),
                    SeparatorFile = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    Shared = table.Column<bool>(nullable: true),
                    ShareName = table.Column<string>(nullable: true),
                    SpoolEnabled = table.Column<bool>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true),
                    UntilTime = table.Column<DateTime>(nullable: true),
                    VerticalResolution = table.Column<long>(nullable: true),
                    WorkOffline = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Printer", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Printer_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Process",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    CommandLine = table.Column<string>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    CSCreationClassName = table.Column<string>(nullable: true),
                    CSName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExecutablePath = table.Column<string>(nullable: true),
                    ExecutionState = table.Column<int>(nullable: true),
                    Handle = table.Column<string>(nullable: true),
                    HandleCount = table.Column<long>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    KernelModeTime = table.Column<decimal>(nullable: true),
                    MaximumWorkingSetSize = table.Column<long>(nullable: true),
                    MinimumWorkingSetSize = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OSCreationClassName = table.Column<string>(nullable: true),
                    OSName = table.Column<string>(nullable: true),
                    OtherOperationCount = table.Column<decimal>(nullable: true),
                    OtherTransferCount = table.Column<decimal>(nullable: true),
                    PageFaults = table.Column<long>(nullable: true),
                    PageFileUsage = table.Column<long>(nullable: true),
                    ParentProcessId = table.Column<long>(nullable: true),
                    PeakPageFileUsage = table.Column<long>(nullable: true),
                    PeakVirtualSize = table.Column<decimal>(nullable: true),
                    PeakWorkingSetSize = table.Column<long>(nullable: true),
                    Priority = table.Column<long>(nullable: true),
                    PrivatePageCount = table.Column<decimal>(nullable: true),
                    ProcessId = table.Column<long>(nullable: true),
                    QuotaNonPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPeakNonPagedPoolUsage = table.Column<long>(nullable: true),
                    QuotaPeakPagedPoolUsage = table.Column<long>(nullable: true),
                    ReadOperationCount = table.Column<decimal>(nullable: true),
                    ReadTransferCount = table.Column<decimal>(nullable: true),
                    SessionId = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TerminationDate = table.Column<DateTime>(nullable: true),
                    ThreadCount = table.Column<long>(nullable: true),
                    UserModeTime = table.Column<decimal>(nullable: true),
                    VirtualSize = table.Column<decimal>(nullable: true),
                    WindowsVersion = table.Column<string>(nullable: true),
                    WorkingSetSize = table.Column<decimal>(nullable: true),
                    WriteOperationCount = table.Column<decimal>(nullable: true),
                    WriteTransferCount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Process", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Process_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Processor",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AddressWidth = table.Column<int>(nullable: true),
                    Architecture = table.Column<int>(nullable: true),
                    AssetTag = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Characteristics = table.Column<long>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CpuStatus = table.Column<int>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentClockSpeed = table.Column<long>(nullable: true),
                    CurrentVoltage = table.Column<int>(nullable: true),
                    DataWidth = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ExtClock = table.Column<long>(nullable: true),
                    Family = table.Column<int>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    L2CacheSize = table.Column<long>(nullable: true),
                    L2CacheSpeed = table.Column<long>(nullable: true),
                    L3CacheSize = table.Column<long>(nullable: true),
                    L3CacheSpeed = table.Column<long>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    LoadPercentage = table.Column<int>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxClockSpeed = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfCores = table.Column<long>(nullable: true),
                    NumberOfEnabledCore = table.Column<long>(nullable: true),
                    NumberOfLogicalProcessors = table.Column<long>(nullable: true),
                    OtherFamilyDescription = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProcessorId = table.Column<string>(nullable: true),
                    ProcessorType = table.Column<int>(nullable: true),
                    Revision = table.Column<int>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    SecondLevelAddressTranslationExtensions = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SocketDesignation = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Stepping = table.Column<string>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    ThreadCount = table.Column<long>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true),
                    UpgradeMethod = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VirtualizationFirmwareEnabled = table.Column<bool>(nullable: true),
                    VMMonitorModeExtensions = table.Column<bool>(nullable: true),
                    VoltageCaps = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Processor", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Processor_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_SerialPort",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Binary = table.Column<bool>(nullable: true),
                    Capabilities = table.Column<string>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxBaudRate = table.Column<long>(nullable: true),
                    MaximumInputBufferSize = table.Column<long>(nullable: true),
                    MaximumOutputBufferSize = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OSAutoDiscovered = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    ProviderType = table.Column<string>(nullable: true),
                    SettableBaudRate = table.Column<bool>(nullable: true),
                    SettableDataBits = table.Column<bool>(nullable: true),
                    SettableFlowControl = table.Column<bool>(nullable: true),
                    SettableParity = table.Column<bool>(nullable: true),
                    SettableParityCheck = table.Column<bool>(nullable: true),
                    SettableRLSD = table.Column<bool>(nullable: true),
                    SettableStopBits = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    Supports16BitMode = table.Column<bool>(nullable: true),
                    SupportsDTRDSR = table.Column<bool>(nullable: true),
                    SupportsElapsedTimeouts = table.Column<bool>(nullable: true),
                    SupportsIntTimeouts = table.Column<bool>(nullable: true),
                    SupportsParityCheck = table.Column<bool>(nullable: true),
                    SupportsRLSD = table.Column<bool>(nullable: true),
                    SupportsRTSCTS = table.Column<bool>(nullable: true),
                    SupportsSpecialCharacters = table.Column<bool>(nullable: true),
                    SupportsXOnXOff = table.Column<bool>(nullable: true),
                    SupportsXOnXOffSet = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_SerialPort", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_SerialPort_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_SoundDevice",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DMABufferSize = table.Column<int>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MPU401Address = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_SoundDevice", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_SoundDevice_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_TimeZone",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Bias = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    DaylightBias = table.Column<int>(nullable: true),
                    DaylightDay = table.Column<long>(nullable: true),
                    DaylightDayOfWeek = table.Column<byte>(nullable: true),
                    DaylightHour = table.Column<long>(nullable: true),
                    DaylightMillisecond = table.Column<long>(nullable: true),
                    DaylightMinute = table.Column<long>(nullable: true),
                    DaylightMonth = table.Column<long>(nullable: true),
                    DaylightName = table.Column<string>(nullable: true),
                    DaylightSecond = table.Column<long>(nullable: true),
                    DaylightYear = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SettingID = table.Column<string>(nullable: true),
                    StandardBias = table.Column<long>(nullable: true),
                    StandardDay = table.Column<long>(nullable: true),
                    StandardDayOfWeek = table.Column<byte>(nullable: true),
                    StandardHour = table.Column<long>(nullable: true),
                    StandardMillisecond = table.Column<long>(nullable: true),
                    StandardMinute = table.Column<long>(nullable: true),
                    StandardMonth = table.Column<long>(nullable: true),
                    StandardName = table.Column<string>(nullable: true),
                    StandardSecond = table.Column<long>(nullable: true),
                    StandardYear = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_TimeZone", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_TimeZone_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_VideoController",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    AcceleratorCapabilities = table.Column<string>(nullable: true),
                    AdapterCompatibility = table.Column<string>(nullable: true),
                    AdapterDACType = table.Column<string>(nullable: true),
                    AdapterRAM = table.Column<long>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    CapabilityDescriptions = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ColorTableEntries = table.Column<long>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    CurrentBitsPerPixel = table.Column<long>(nullable: true),
                    CurrentHorizontalResolution = table.Column<long>(nullable: true),
                    CurrentNumberOfColors = table.Column<decimal>(nullable: true),
                    CurrentNumberOfColumns = table.Column<long>(nullable: true),
                    CurrentNumberOfRows = table.Column<long>(nullable: true),
                    CurrentRefreshRate = table.Column<long>(nullable: true),
                    CurrentScanMode = table.Column<int>(nullable: true),
                    CurrentVerticalResolution = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DeviceSpecificPens = table.Column<long>(nullable: true),
                    DitherType = table.Column<long>(nullable: true),
                    DriverDate = table.Column<DateTime>(nullable: true),
                    DriverVersion = table.Column<string>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ICMIntent = table.Column<long>(nullable: true),
                    ICMMethod = table.Column<long>(nullable: true),
                    InfFilename = table.Column<string>(nullable: true),
                    InfSection = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstalledDisplayDrivers = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaxMemorySupported = table.Column<long>(nullable: true),
                    MaxNumberControlled = table.Column<long>(nullable: true),
                    MaxRefreshRate = table.Column<long>(nullable: true),
                    MinRefreshRate = table.Column<long>(nullable: true),
                    Monochrome = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfColorPlanes = table.Column<int>(nullable: true),
                    NumberOfVideoPages = table.Column<long>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    ProtocolSupported = table.Column<int>(nullable: true),
                    ReservedSystemPaletteEntries = table.Column<long>(nullable: true),
                    SpecificationVersion = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    SystemPaletteEntries = table.Column<long>(nullable: true),
                    TimeOfLastReset = table.Column<DateTime>(nullable: true),
                    VideoArchitecture = table.Column<int>(nullable: true),
                    VideoMemoryType = table.Column<int>(nullable: true),
                    VideoMode = table.Column<int>(nullable: true),
                    VideoModeDescription = table.Column<string>(nullable: true),
                    VideoProcessor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_VideoController", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_VideoController_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_VideoSettings",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Element = table.Column<string>(nullable: true),
                    Setting = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_VideoSettings", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_VideoSettings_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Win32_Volume",
                columns: table => new
                {
                    WMIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    WmiResultsSetEntityID = table.Column<int>(nullable: true),
                    Access = table.Column<int>(nullable: true),
                    Automount = table.Column<bool>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    BlockSize = table.Column<decimal>(nullable: true),
                    BootVolume = table.Column<bool>(nullable: true),
                    Capacity = table.Column<decimal>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Compressed = table.Column<bool>(nullable: true),
                    ConfigManagerErrorCode = table.Column<long>(nullable: true),
                    ConfigManagerUserConfig = table.Column<bool>(nullable: true),
                    CreationClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    DirtyBitSet = table.Column<bool>(nullable: true),
                    DriveLetter = table.Column<string>(nullable: true),
                    DriveType = table.Column<long>(nullable: true),
                    ErrorCleared = table.Column<bool>(nullable: true),
                    ErrorDescription = table.Column<string>(nullable: true),
                    ErrorMethodology = table.Column<string>(nullable: true),
                    FileSystem = table.Column<string>(nullable: true),
                    FreeSpace = table.Column<decimal>(nullable: true),
                    IndexingEnabled = table.Column<bool>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastErrorCode = table.Column<long>(nullable: true),
                    MaximumFileNameLength = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBlocks = table.Column<decimal>(nullable: true),
                    PageFilePresent = table.Column<bool>(nullable: true),
                    PNPDeviceID = table.Column<string>(nullable: true),
                    PowerManagementCapabilities = table.Column<string>(nullable: true),
                    PowerManagementSupported = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    QuotasEnabled = table.Column<bool>(nullable: true),
                    QuotasIncomplete = table.Column<bool>(nullable: true),
                    QuotasRebuilding = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<long>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusInfo = table.Column<int>(nullable: true),
                    SupportsDiskQuotas = table.Column<bool>(nullable: true),
                    SupportsFileBasedCompression = table.Column<bool>(nullable: true),
                    SystemCreationClassName = table.Column<string>(nullable: true),
                    SystemName = table.Column<string>(nullable: true),
                    SystemVolume = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Win32_Volume", x => x.WMIID);
                    table.ForeignKey(
                        name: "FK_Win32_Volume_WmiResultsSet_WmiResultsSetEntityID",
                        column: x => x.WmiResultsSetEntityID,
                        principalTable: "WmiResultsSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryFullChargedCapacity_WmiResultsSetEntityID",
                table: "BatteryFullChargedCapacity",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BatteryStaticData_WmiResultsSetEntityID",
                table: "BatteryStaticData",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BatteryStatus_WmiResultsSetEntityID",
                table: "BatteryStatus",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Battery_WmiResultsSetEntityID",
                table: "CIM_Battery",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_BIOSElement_WmiResultsSetEntityID",
                table: "CIM_BIOSElement",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Card_WmiResultsSetEntityID",
                table: "CIM_Card",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Chip_WmiResultsSetEntityID",
                table: "CIM_Chip",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_ComputerSystem_WmiResultsSetEntityID",
                table: "CIM_ComputerSystem",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Controller_WmiResultsSetEntityID",
                table: "CIM_Controller",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_CoolingDevice_WmiResultsSetEntityID",
                table: "CIM_CoolingDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_CurrentSensor_WmiResultsSetEntityID",
                table: "CIM_CurrentSensor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_DesktopMonitor_WmiResultsSetEntityID",
                table: "CIM_DesktopMonitor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_DiskDrive_WmiResultsSetEntityID",
                table: "CIM_DiskDrive",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_DiskPartition_WmiResultsSetEntityID",
                table: "CIM_DiskPartition",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Display_WmiResultsSetEntityID",
                table: "CIM_Display",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Fan_WmiResultsSetEntityID",
                table: "CIM_Fan",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_InstalledOS_WmiResultsSetEntityID",
                table: "CIM_InstalledOS",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Keyboard_WmiResultsSetEntityID",
                table: "CIM_Keyboard",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_LogicalDisk_WmiResultsSetEntityID",
                table: "CIM_LogicalDisk",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Memory_WmiResultsSetEntityID",
                table: "CIM_Memory",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_NetworkAdapter_WmiResultsSetEntityID",
                table: "CIM_NetworkAdapter",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_NumericSensor_WmiResultsSetEntityID",
                table: "CIM_NumericSensor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_OperatingSystem_WmiResultsSetEntityID",
                table: "CIM_OperatingSystem",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_PCVideoController_WmiResultsSetEntityID",
                table: "CIM_PCVideoController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_PhysicalConnector_WmiResultsSetEntityID",
                table: "CIM_PhysicalConnector",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_PhysicalElement_WmiResultsSetEntityID",
                table: "CIM_PhysicalElement",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_PhysicalMemory_WmiResultsSetEntityID",
                table: "CIM_PhysicalMemory",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_PointingDevice_WmiResultsSetEntityID",
                table: "CIM_PointingDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Printer_WmiResultsSetEntityID",
                table: "CIM_Printer",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Process_WmiResultsSetEntityID",
                table: "CIM_Process",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Processor_WmiResultsSetEntityID",
                table: "CIM_Processor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Product_WmiResultsSetEntityID",
                table: "CIM_Product",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_SCSIController_WmiResultsSetEntityID",
                table: "CIM_SCSIController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Sensor_WmiResultsSetEntityID",
                table: "CIM_Sensor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_SerialController_WmiResultsSetEntityID",
                table: "CIM_SerialController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_Slot_WmiResultsSetEntityID",
                table: "CIM_Slot",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_StorageVolume_WmiResultsSetEntityID",
                table: "CIM_StorageVolume",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_System_WmiResultsSetEntityID",
                table: "CIM_System",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_TemperatureSensor_WmiResultsSetEntityID",
                table: "CIM_TemperatureSensor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_UnitaryComputerSystem_WmiResultsSetEntityID",
                table: "CIM_UnitaryComputerSystem",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_USBController_WmiResultsSetEntityID",
                table: "CIM_USBController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_USBDevice_WmiResultsSetEntityID",
                table: "CIM_USBDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_VideoController_WmiResultsSetEntityID",
                table: "CIM_VideoController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_VideoControllerResolution_WmiResultsSetEntityID",
                table: "CIM_VideoControllerResolution",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_VideoSetting_WmiResultsSetEntityID",
                table: "CIM_VideoSetting",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CIM_VoltageSensor_WmiResultsSetEntityID",
                table: "CIM_VoltageSensor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_MSAcpi_ThermalZoneTemperature_WmiResultsSetEntityID",
                table: "MSAcpi_ThermalZoneTemperature",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_MSFT_PhysicalDisk_WmiResultsSetEntityID",
                table: "MSFT_PhysicalDisk",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareLicensingProduct_WmiResultsSetEntityID",
                table: "SoftwareLicensingProduct",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareLicensingService_WmiResultsSetEntityID",
                table: "SoftwareLicensingService",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Account_WmiResultsSetEntityID",
                table: "Win32_Account",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_AssociatedProcessorMemory_WmiResultsSetEntityID",
                table: "Win32_AssociatedProcessorMemory",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_BaseBoard_WmiResultsSetEntityID",
                table: "Win32_BaseBoard",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Battery_WmiResultsSetEntityID",
                table: "Win32_Battery",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_BIOS_WmiResultsSetEntityID",
                table: "Win32_BIOS",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Bus_WmiResultsSetEntityID",
                table: "Win32_Bus",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_CacheMemory_WmiResultsSetEntityID",
                table: "Win32_CacheMemory",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_CDROMDrive_WmiResultsSetEntityID",
                table: "Win32_CDROMDrive",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_ComputerSystem_WmiResultsSetEntityID",
                table: "Win32_ComputerSystem",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_DiskDrive_WmiResultsSetEntityID",
                table: "Win32_DiskDrive",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_DiskPartition_WmiResultsSetEntityID",
                table: "Win32_DiskPartition",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Fan_WmiResultsSetEntityID",
                table: "Win32_Fan",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Keyboard_WmiResultsSetEntityID",
                table: "Win32_Keyboard",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_LogicalDisk_WmiResultsSetEntityID",
                table: "Win32_LogicalDisk",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_MotherboardDevice_WmiResultsSetEntityID",
                table: "Win32_MotherboardDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_NetworkAdapter_WmiResultsSetEntityID",
                table: "Win32_NetworkAdapter",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_NetworkAdapterConfiguration_WmiResultsSetEntityID",
                table: "Win32_NetworkAdapterConfiguration",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_OperatingSystem_WmiResultsSetEntityID",
                table: "Win32_OperatingSystem",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PhysicalMemory_WmiResultsSetEntityID",
                table: "Win32_PhysicalMemory",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PnPDevice_WmiResultsSetEntityID",
                table: "Win32_PnPDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PnPEntity_WmiResultsSetEntityID",
                table: "Win32_PnPEntity",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PointingDevice_WmiResultsSetEntityID",
                table: "Win32_PointingDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PortConnector_WmiResultsSetEntityID",
                table: "Win32_PortConnector",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_PortResource_WmiResultsSetEntityID",
                table: "Win32_PortResource",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Printer_WmiResultsSetEntityID",
                table: "Win32_Printer",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Process_WmiResultsSetEntityID",
                table: "Win32_Process",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Processor_WmiResultsSetEntityID",
                table: "Win32_Processor",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_SerialPort_WmiResultsSetEntityID",
                table: "Win32_SerialPort",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_SoundDevice_WmiResultsSetEntityID",
                table: "Win32_SoundDevice",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_TimeZone_WmiResultsSetEntityID",
                table: "Win32_TimeZone",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_VideoController_WmiResultsSetEntityID",
                table: "Win32_VideoController",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_VideoSettings_WmiResultsSetEntityID",
                table: "Win32_VideoSettings",
                column: "WmiResultsSetEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Win32_Volume_WmiResultsSetEntityID",
                table: "Win32_Volume",
                column: "WmiResultsSetEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteryFullChargedCapacity");

            migrationBuilder.DropTable(
                name: "BatteryStaticData");

            migrationBuilder.DropTable(
                name: "BatteryStatus");

            migrationBuilder.DropTable(
                name: "CIM_Battery");

            migrationBuilder.DropTable(
                name: "CIM_BIOSElement");

            migrationBuilder.DropTable(
                name: "CIM_Card");

            migrationBuilder.DropTable(
                name: "CIM_Chip");

            migrationBuilder.DropTable(
                name: "CIM_ComputerSystem");

            migrationBuilder.DropTable(
                name: "CIM_Controller");

            migrationBuilder.DropTable(
                name: "CIM_CoolingDevice");

            migrationBuilder.DropTable(
                name: "CIM_CurrentSensor");

            migrationBuilder.DropTable(
                name: "CIM_DesktopMonitor");

            migrationBuilder.DropTable(
                name: "CIM_DiskDrive");

            migrationBuilder.DropTable(
                name: "CIM_DiskPartition");

            migrationBuilder.DropTable(
                name: "CIM_Display");

            migrationBuilder.DropTable(
                name: "CIM_Fan");

            migrationBuilder.DropTable(
                name: "CIM_InstalledOS");

            migrationBuilder.DropTable(
                name: "CIM_Keyboard");

            migrationBuilder.DropTable(
                name: "CIM_LogicalDisk");

            migrationBuilder.DropTable(
                name: "CIM_Memory");

            migrationBuilder.DropTable(
                name: "CIM_NetworkAdapter");

            migrationBuilder.DropTable(
                name: "CIM_NumericSensor");

            migrationBuilder.DropTable(
                name: "CIM_OperatingSystem");

            migrationBuilder.DropTable(
                name: "CIM_PCVideoController");

            migrationBuilder.DropTable(
                name: "CIM_PhysicalConnector");

            migrationBuilder.DropTable(
                name: "CIM_PhysicalElement");

            migrationBuilder.DropTable(
                name: "CIM_PhysicalMemory");

            migrationBuilder.DropTable(
                name: "CIM_PointingDevice");

            migrationBuilder.DropTable(
                name: "CIM_Printer");

            migrationBuilder.DropTable(
                name: "CIM_Process");

            migrationBuilder.DropTable(
                name: "CIM_Processor");

            migrationBuilder.DropTable(
                name: "CIM_Product");

            migrationBuilder.DropTable(
                name: "CIM_SCSIController");

            migrationBuilder.DropTable(
                name: "CIM_Sensor");

            migrationBuilder.DropTable(
                name: "CIM_SerialController");

            migrationBuilder.DropTable(
                name: "CIM_Slot");

            migrationBuilder.DropTable(
                name: "CIM_StorageVolume");

            migrationBuilder.DropTable(
                name: "CIM_System");

            migrationBuilder.DropTable(
                name: "CIM_TemperatureSensor");

            migrationBuilder.DropTable(
                name: "CIM_UnitaryComputerSystem");

            migrationBuilder.DropTable(
                name: "CIM_USBController");

            migrationBuilder.DropTable(
                name: "CIM_USBDevice");

            migrationBuilder.DropTable(
                name: "CIM_VideoController");

            migrationBuilder.DropTable(
                name: "CIM_VideoControllerResolution");

            migrationBuilder.DropTable(
                name: "CIM_VideoSetting");

            migrationBuilder.DropTable(
                name: "CIM_VoltageSensor");

            migrationBuilder.DropTable(
                name: "MSAcpi_ThermalZoneTemperature");

            migrationBuilder.DropTable(
                name: "MSFT_PhysicalDisk");

            migrationBuilder.DropTable(
                name: "SoftwareLicensingProduct");

            migrationBuilder.DropTable(
                name: "SoftwareLicensingService");

            migrationBuilder.DropTable(
                name: "Win32_Account");

            migrationBuilder.DropTable(
                name: "Win32_AssociatedProcessorMemory");

            migrationBuilder.DropTable(
                name: "Win32_BaseBoard");

            migrationBuilder.DropTable(
                name: "Win32_Battery");

            migrationBuilder.DropTable(
                name: "Win32_BIOS");

            migrationBuilder.DropTable(
                name: "Win32_Bus");

            migrationBuilder.DropTable(
                name: "Win32_CacheMemory");

            migrationBuilder.DropTable(
                name: "Win32_CDROMDrive");

            migrationBuilder.DropTable(
                name: "Win32_ComputerSystem");

            migrationBuilder.DropTable(
                name: "Win32_DiskDrive");

            migrationBuilder.DropTable(
                name: "Win32_DiskPartition");

            migrationBuilder.DropTable(
                name: "Win32_Fan");

            migrationBuilder.DropTable(
                name: "Win32_Keyboard");

            migrationBuilder.DropTable(
                name: "Win32_LogicalDisk");

            migrationBuilder.DropTable(
                name: "Win32_MotherboardDevice");

            migrationBuilder.DropTable(
                name: "Win32_NetworkAdapter");

            migrationBuilder.DropTable(
                name: "Win32_NetworkAdapterConfiguration");

            migrationBuilder.DropTable(
                name: "Win32_OperatingSystem");

            migrationBuilder.DropTable(
                name: "Win32_PhysicalMemory");

            migrationBuilder.DropTable(
                name: "Win32_PnPDevice");

            migrationBuilder.DropTable(
                name: "Win32_PnPEntity");

            migrationBuilder.DropTable(
                name: "Win32_PointingDevice");

            migrationBuilder.DropTable(
                name: "Win32_PortConnector");

            migrationBuilder.DropTable(
                name: "Win32_PortResource");

            migrationBuilder.DropTable(
                name: "Win32_Printer");

            migrationBuilder.DropTable(
                name: "Win32_Process");

            migrationBuilder.DropTable(
                name: "Win32_Processor");

            migrationBuilder.DropTable(
                name: "Win32_SerialPort");

            migrationBuilder.DropTable(
                name: "Win32_SoundDevice");

            migrationBuilder.DropTable(
                name: "Win32_TimeZone");

            migrationBuilder.DropTable(
                name: "Win32_VideoController");

            migrationBuilder.DropTable(
                name: "Win32_VideoSettings");

            migrationBuilder.DropTable(
                name: "Win32_Volume");

            migrationBuilder.DropTable(
                name: "WmiResultsSet");
        }
    }
}
