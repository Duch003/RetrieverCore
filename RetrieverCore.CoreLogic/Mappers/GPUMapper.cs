﻿using GathererEngine.Decoders;
using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models;
using RetrieverCore.Models.WMIEntieties;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class GPUMapper
    {
        public static GPU From(Win32_VideoController win32VideoController)
        {
            var output = new GPU();
            output.Availability = AvailabilityDecoder.Decode(win32VideoController.Availability ?? 0);
            output.Height = win32VideoController.CurrentVerticalResolution ?? 0;
            output.Width = win32VideoController.CurrentHorizontalResolution ?? 0;
            output.Name = string.IsNullOrWhiteSpace(win32VideoController.Caption)
                ? "Unknown"
                : win32VideoController.Caption;
            output.Capacity = win32VideoController.AdapterRAM.HasValue
                ? win32VideoController.AdapterRAM.Value / Constants.Gibibyte
                : Constants.DefaultNumericValue;
            output.AdapterDACType = string.IsNullOrWhiteSpace(win32VideoController.AdapterDACType)
                ? "Unknown"
                : win32VideoController.AdapterDACType;
            output.VideoArchitecture = VideoArchitectureDecoder.Decode(win32VideoController.VideoArchitecture ?? 0);
            output.NumberOfColors = win32VideoController.CurrentNumberOfColors.HasValue
                ? (long)win32VideoController.CurrentNumberOfColors.Value
                : Constants.DefaultNumericValue;
            output.MaxRefreshRate = win32VideoController.MaxRefreshRate.HasValue 
                ? (int)win32VideoController.MaxRefreshRate.Value
                : Constants.DefaultNumericValue;

            return output;
        }
    }
}
