using System.Dynamic;
using GadgetoComparer.Settings;

namespace GadgetoComparer;
public static class GadgetoComparer
{
    public static bool CompareProperties(this object subject, object objectToCompare, GadgetoCompareSettings gadgetoCompareSettings, out object? resultWithDifferences, out string message)
    {
        var subjectProps = subject.GetType().GetProperties();
        var objectToCompareProps = objectToCompare.GetType().GetProperties();
        if (subjectProps.Length != objectToCompareProps.Length)
        {
            resultWithDifferences = objectToCompare;
            message = "This objects have differnt number of properties";
            return false;
        }
        var distinctProperties = subjectProps.Except(objectToCompareProps);
        if (distinctProperties.Any())
        {
            var result = new ExpandoObject();
            resultWithDifferences = result;
            message = "The objects have different properties";
            return false;
        }
        foreach (var item in subjectProps)
        {
            var meth = item.Name;
            var proptp = item.PropertyType;
        }
        resultWithDifferences = null;
        message = string.Empty;
        return true;
    }
}

