using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetrieverCore.Models;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class CPUMapperTests
    {
        [Fact]
        public void From_ParameterIsValid_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 2000,
                L2CacheSize = 6000,
                L3CacheSize = 2000,
                Name = "Model - Vendor",
                NumberOfCores = 12,
                NumberOfLogicalProcessors = 24,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == win32Processor.Name);
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Theory]
        [InlineData(0, "x86")]
        [InlineData(1, "MIPS")]
        [InlineData(2, "Alpha")]
        [InlineData(3, "PowerPC")]
        [InlineData(4, "Unknown")]
        [InlineData(5, "ARM")]
        [InlineData(6, "ia64")]
        [InlineData(7, "Unknown")]
        [InlineData(8, "Unknown")]
        [InlineData(9, "x64")]
        [InlineData(10, "Unknown")]
        public void From_VariousArchitectures_ReturnsCPU(ushort architecture, string decoded)
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = architecture,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == decoded);
        }

        [Theory]
        [InlineData(0, "Unknown")]
        [InlineData(1, "Other")]
        [InlineData(2, "Unknown")]
        [InlineData(3, "Central Processor")]
        [InlineData(4, "Math Processor")]
        [InlineData(5, "DSP Processor")]
        [InlineData(6, "Video Processor")]
        [InlineData(7, "Unknown")]
        public void From_VariousProcessorTypes_ReturnsCPU(ushort processorType, string decoded)
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = processorType,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ProcessorType == decoded);
        }

        [Theory]
        [InlineData(1, "Other")]
        [InlineData(2, "Unknown")]
        [InlineData(3, "8086")]
        [InlineData(4, "80286")]
        [InlineData(5, "80386")]
        [InlineData(6, "80486")]
        [InlineData(7, "8087")]
        [InlineData(8, "80287")]
        [InlineData(9, "80387")]
        [InlineData(10, "80487")]
        [InlineData(11, "Pentium(R) brand")]
        [InlineData(12, "Pentium(R) Pro")]
        [InlineData(13, "Pentium(R) II")]
        [InlineData(14, "Pentium(R) processor with MMX(TM) technology")]
        [InlineData(15, "Celeron(TM)")]
        [InlineData(16, "Pentium(R) II Xeon(TM)")]
        [InlineData(17, "Pentium(R) III")]
        [InlineData(18, "M1 Family")]
        [InlineData(19, "M2 Family")]
        [InlineData(20, "Intel(R) Celeron(R) M processor")]
        [InlineData(21, "Intel(R) Pentium(R) 4 HT processor")]
        [InlineData(24, "K5 Family")]
        [InlineData(25, "K6 Family")]
        [InlineData(26, "K6-2")]
        [InlineData(27, "K6-3")]
        [InlineData(28, "AMD Athlon(TM) Processor Family")]
        [InlineData(29, "AMD(R) Duron(TM) Processor")]
        [InlineData(30, "AMD29000 Family")]
        [InlineData(31, "K6-2+")]
        [InlineData(32, "Power PC Family")]
        [InlineData(33, "Power PC 601")]
        [InlineData(34, "Power PC 603")]
        [InlineData(35, "Power PC 603+")]
        [InlineData(36, "Power PC 604")]
        [InlineData(37, "Power PC 620")]
        [InlineData(38, "Power PC X704")]
        [InlineData(39, "Power PC 750")]
        [InlineData(40, "Intel(R) Core(TM) Duo processor")]
        [InlineData(41, "Intel(R) Core(TM) Duo mobile processor")]
        [InlineData(42, "Intel(R) Core(TM) Solo mobile processor")]
        [InlineData(43, "Intel(R) Atom(TM) processor")]
        [InlineData(48, "Alpha Family")]
        [InlineData(49, "Alpha 21064")]
        [InlineData(50, "Alpha 21066")]
        [InlineData(51, "Alpha 21164")]
        [InlineData(52, "Alpha 21164PC")]
        [InlineData(53, "Alpha 21164a")]
        [InlineData(54, "Alpha 21264")]
        [InlineData(55, "Alpha 21364")]
        [InlineData(56, "AMD Turion(TM) II Ultra Dual-Core Mobile M Processor Family")]
        [InlineData(57, "AMD Turion(TM) II Dual-Core Mobile M Processor Family")]
        [InlineData(58, "AMD Athlon(TM) II Dual-Core Mobile M Processor Family")]
        [InlineData(59, "AMD Opteron(TM) 6100 Series Processor")]
        [InlineData(60, "AMD Opteron(TM) 4100 Series Processor")]
        [InlineData(64, "MIPS Family")]
        [InlineData(65, "MIPS R4000")]
        [InlineData(66, "MIPS R4200")]
        [InlineData(67, "MIPS R4400")]
        [InlineData(68, "MIPS R4600")]
        [InlineData(69, "MIPS R10000")]
        [InlineData(80, "SPARC Family")]
        [InlineData(81, "SuperSPARC")]
        [InlineData(82, "microSPARC II")]
        [InlineData(83, "microSPARC IIep")]
        [InlineData(84, "UltraSPARC")]
        [InlineData(85, "UltraSPARC II")]
        [InlineData(86, "UltraSPARC IIi")]
        [InlineData(87, "UltraSPARC III")]
        [InlineData(88, "UltraSPARC IIIi")]
        [InlineData(96, "68040")]
        [InlineData(97, "68xxx Family")]
        [InlineData(98, "68000")]
        [InlineData(99, "68010")]
        [InlineData(100, "68020")]
        [InlineData(101, "68030")]
        [InlineData(112, "Hobbit Family")]
        [InlineData(120, "Crusoe(TM) TM5000 Family")]
        [InlineData(121, "Crusoe(TM) TM3000 Family")]
        [InlineData(122, "Efficeon(TM) TM8000 Family")]
        [InlineData(128, "Weitek")]
        [InlineData(130, "Itanium(TM) Processor")]
        [InlineData(131, "AMD Athlon(TM) 64 Processor Family")]
        [InlineData(132, "AMD Opteron(TM) Processor Family")]
        [InlineData(133, "AMD Sempron(TM) Processor Family")]
        [InlineData(134, "AMD Turion(TM) 64 Mobile Technology")]
        [InlineData(135, "Dual-Core AMD Opteron(TM) Processor Family")]
        [InlineData(136, "AMD Athlon(TM) 64 X2 Dual-Core Processor Family")]
        [InlineData(137, "AMD Turion(TM) 64 X2 Mobile Technology")]
        [InlineData(138, "Quad-Core AMD Opteron(TM) Processor Family")]
        [InlineData(139, "Third-Generation AMD Opteron(TM) Processor Family")]
        [InlineData(140, "AMD Phenom(TM) FX Quad-Core Processor Family")]
        [InlineData(141, "AMD Phenom(TM) X4 Quad-Core Processor Family")]
        [InlineData(142, "AMD Phenom(TM) X2 Dual-Core Processor Family")]
        [InlineData(143, "AMD Athlon(TM) X2 Dual-Core Processor Family")]
        [InlineData(144, "PA-RISC Family")]
        [InlineData(145, "PA-RISC 8500")]
        [InlineData(146, "PA-RISC 8000")]
        [InlineData(147, "PA-RISC 7300LC")]
        [InlineData(148, "PA-RISC 7200")]
        [InlineData(149, "PA-RISC 7100LC")]
        [InlineData(150, "PA-RISC 7100")]
        [InlineData(160, "V30 Family")]
        [InlineData(161, "Quad-Core Intel(R) Xeon(R) processor 3200 Series")]
        [InlineData(162, "Dual-Core Intel(R) Xeon(R) processor 3000 Series")]
        [InlineData(163, "Quad-Core Intel(R) Xeon(R) processor 5300 Series")]
        [InlineData(164, "Dual-Core Intel(R) Xeon(R) processor 5100 Series")]
        [InlineData(165, "Dual-Core Intel(R) Xeon(R) processor 5000 Series")]
        [InlineData(166, "Dual-Core Intel(R) Xeon(R) processor LV")]
        [InlineData(167, "Dual-Core Intel(R) Xeon(R) processor ULV")]
        [InlineData(168, "Dual-Core Intel(R) Xeon(R) processor 7100 Series")]
        [InlineData(169, "Quad-Core Intel(R) Xeon(R) processor 5400 Series")]
        [InlineData(170, "Quad-Core Intel(R) Xeon(R) processor")]
        [InlineData(171, "Dual-Core Intel(R) Xeon(R) processor 5200 Series")]
        [InlineData(172, "Dual-Core Intel(R) Xeon(R) processor 7200 Series")]
        [InlineData(173, "Quad-Core Intel(R) Xeon(R) processor 7300 Series")]
        [InlineData(174, "Quad-Core Intel(R) Xeon(R) processor 7400 Series")]
        [InlineData(175, "Multi-Core Intel(R) Xeon(R) processor 7400 Series")]
        [InlineData(176, "Pentium(R) III Xeon(TM)")]
        [InlineData(177, "Pentium(R) III Processor with Intel(R) SpeedStep(TM) Technology")]
        [InlineData(178, "Pentium(R) 4")]
        [InlineData(179, "Intel(R) Xeon(TM)")]
        [InlineData(180, "AS400 Family")]
        [InlineData(181, "Intel(R) Xeon(TM) processor MP")]
        [InlineData(182, "AMD Athlon(TM) XP Family")]
        [InlineData(183, "AMD Athlon(TM) MP Family")]
        [InlineData(184, "Intel(R) Itanium(R) 2")]
        [InlineData(185, "Intel(R) Pentium(R) M processor")]
        [InlineData(186, "Intel(R) Celeron(R) D processor")]
        [InlineData(187, "Intel(R) Pentium(R) D processor")]
        [InlineData(188, "Intel(R) Pentium(R) Processor Extreme Edition")]
        [InlineData(189, "Intel(R) Core(TM) Solo Processor")]
        [InlineData(190, "K7")]
        [InlineData(191, "Intel(R) Core(TM)2 Duo Processor")]
        [InlineData(192, "Intel(R) Core(TM)2 Solo processor")]
        [InlineData(193, "Intel(R) Core(TM)2 Extreme processor")]
        [InlineData(194, "Intel(R) Core(TM)2 Quad processor")]
        [InlineData(195, "Intel(R) Core(TM)2 Extreme mobile processor")]
        [InlineData(196, "Intel(R) Core(TM)2 Duo mobile processor")]
        [InlineData(197, "Intel(R) Core(TM)2 Solo mobile processor")]
        [InlineData(198, "Intel(R) Core(TM) i7 processor")]
        [InlineData(199, "Dual-Core Intel(R) Celeron(R) Processor")]
        [InlineData(200, "S/390 and zSeries Family")]
        [InlineData(201, "ESA/390 G4")]
        [InlineData(202, "ESA/390 G5")]
        [InlineData(203, "ESA/390 G6")]
        [InlineData(204, "z/Architectur base")]
        [InlineData(205, "Intel(R) Core(TM) i5 processor")]
        [InlineData(206, "Intel(R) Core(TM) i3 processor")]
        [InlineData(210, "VIA C7(TM)-M Processor Family")]
        [InlineData(211, "VIA C7(TM)-D Processor Family")]
        [InlineData(212, "VIA C7(TM) Processor Family")]
        [InlineData(213, "VIA Eden(TM) Processor Family")]
        [InlineData(214, "Multi-Core Intel(R) Xeon(R) processor")]
        [InlineData(215, "Dual-Core Intel(R) Xeon(R) processor 3xxx Series")]
        [InlineData(216, "Quad-Core Intel(R) Xeon(R) processor 3xxx Series")]
        [InlineData(217, "VIA Nano(TM) Processor Family")]
        [InlineData(218, "Dual-Core Intel(R) Xeon(R) processor 5xxx Series")]
        [InlineData(219, "Quad-Core Intel(R) Xeon(R) processor 5xxx Series")]
        [InlineData(221, "Dual-Core Intel(R) Xeon(R) processor 7xxx Series")]
        [InlineData(222, "Quad-Core Intel(R) Xeon(R) processor 7xxx Series")]
        [InlineData(223, "Multi-Core Intel(R) Xeon(R) processor 7xxx Series")]
        [InlineData(224, "Multi-Core Intel(R) Xeon(R) processor 3400 Series")]
        [InlineData(230, "Embedded AMD Opteron(TM) Quad-Core Processor Family")]
        [InlineData(231, "AMD Phenom(TM) Triple-Core Processor Family")]
        [InlineData(232, "AMD Turion(TM) Ultra Dual-Core Mobile Processor Family")]
        [InlineData(233, "AMD Turion(TM) Dual-Core Mobile Processor Family")]
        [InlineData(234, "AMD Athlon(TM) Dual-Core Processor Family")]
        [InlineData(235, "AMD Sempron(TM) SI Processor Family")]
        [InlineData(236, "AMD Phenom(TM) II Processor Family")]
        [InlineData(237, "AMD Athlon(TM) II Processor Family")]
        [InlineData(238, "Six-Core AMD Opteron(TM) Processor Family")]
        [InlineData(239, "AMD Sempron(TM) M Processor Family")]
        [InlineData(250, "i860")]
        [InlineData(251, "i960")]
        [InlineData(254, "Reserved (SMBIOS Extension)")]
        [InlineData(255, "Reserved (Un-initialized Flash Content - Lo)")]
        [InlineData(260, "SH-3")]
        [InlineData(261, "SH-4")]
        [InlineData(280, "ARM")]
        [InlineData(281, "StrongARM")]
        [InlineData(300, "6x86")]
        [InlineData(301, "MediaGX")]
        [InlineData(302, "MII")]
        [InlineData(320, "WinChip")]
        [InlineData(350, "DSP")]
        [InlineData(500, "Video Processor")]
        [InlineData(65534, "Reserved (For Future Special Purpose Assignment)")]
        [InlineData(65535, "Reserved (Un-initialized Flash Content - Hi)")]
        public void From_VariousFamilies_ReturnsCPU(ushort family, string decoded)
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = family,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Family == decoded);
        }

        [Theory]
        [InlineData(0, "Unknown")]
        [InlineData(1, "Other")]
        [InlineData(2, "Unknown")]
        [InlineData(3, "Daughter Board")]
        [InlineData(4, "ZIF Socket")]
        [InlineData(5, "Replacement/Piggy Back")]
        [InlineData(6, "None")]
        [InlineData(7, "LIF Socket")]
        [InlineData(8, "Slot 1")]
        [InlineData(9, "Slot 2")]
        [InlineData(10, "370 Pin Socket")]
        [InlineData(11, "Slot A")]
        [InlineData(12, "Slot M")]
        [InlineData(13, "Socket 423")]
        [InlineData(14, "Socket A (Socket 462)")]
        [InlineData(15, "Socket 478")]
        [InlineData(16, "Socket 754")]
        [InlineData(17, "Socket 940")]
        [InlineData(18, "Socket 939")]
        public void From_VariousUpgradeMethods_ReturnsCPU(ushort upgradeMethod, string decoded)
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = upgradeMethod
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.UpgradeMethod == decoded);
        }

        [Fact]
        public void From_ArchitectureIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = null,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "Unknown");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == win32Processor.Name);
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_CurrentClockSpeedIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = null,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == Constants.DefaultNumericValue);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == win32Processor.Name);
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_L2CacheSizeIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = null,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == Constants.DefaultNumericValue);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == win32Processor.Name);
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_L3CacheSizeIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = null,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == Constants.DefaultNumericValue);
            Assert.True(result.ModelWithVendor == win32Processor.Name);
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_NameIsEmpty_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = string.Empty,
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Unknown");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_NameIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = null,
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Unknown");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_NameIsWhitespace_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = " ",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Unknown");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_NumberOfCoresIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = null,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == Constants.DefaultNumericValue);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_NumberOfLogicalProcessorsIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = null,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == Constants.DefaultNumericValue);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_ProcessorTypeIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = null,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Unknown");
            Assert.True(result.Caption == win32Processor.Caption);
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_CaptionIsEmpty_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = string.Empty,
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == "-");
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_CaptionIsWhiteSpace_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = " ",
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == "-");
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_CaptionIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = null,
                Family = 1,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == "-");
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_FamilyIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = null,
                UpgradeMethod = 1
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == "Caption");
            Assert.True(result.Family == "Unknown");
            Assert.True(result.UpgradeMethod == "Other");
        }

        [Fact]
        public void From_UpgradeMethodIsNull_ReturnsCPU()
        {
            //Arrange
            var win32Processor = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Model - Vendor",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption",
                Family = 1,
                UpgradeMethod = null
            };

            //Act
            var result = CPUMapper.From(win32Processor);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Architecture == "MIPS");
            Assert.True(result.CurrentClockSpeed == win32Processor.CurrentClockSpeed);
            Assert.True(result.L2CacheSize == win32Processor.L2CacheSize);
            Assert.True(result.L3CacheSize == win32Processor.L3CacheSize);
            Assert.True(result.ModelWithVendor == "Model - Vendor");
            Assert.True(result.NumberOfCores == win32Processor.NumberOfCores);
            Assert.True(result.NumberOfLogicalProcessors == win32Processor.NumberOfLogicalProcessors);
            Assert.True(result.ProcessorType == "Other");
            Assert.True(result.Caption == "Caption");
            Assert.True(result.Family == "Other");
            Assert.True(result.UpgradeMethod == "Unknown");
        }
    }
}
