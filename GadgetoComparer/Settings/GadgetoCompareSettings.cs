using System;
namespace GadgetoComparer.Settings
{
    public class GadgetoCompareSettings
    {
        public bool CompareNumberOfProperties { get; set; }

        public GadgetoCompareSettings(bool compareNumberOfProperties)
        {
            CompareNumberOfProperties = compareNumberOfProperties;
        }

        public GadgetoCompareSettings()
        {
        }
    }
}

