using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Data;

public class Convert
{
    public static string ToString(DataRow row, string fieldName)
    {
        if (row[fieldName] != DBNull.Value) return (string)row[fieldName]; else return "";
    }

    //New method added
    public static int ToInt(DataRow row, string fieldName)
    {
        if (row[fieldName] != DBNull.Value) return (int)row[fieldName]; else return 0;
    }

    //New method added
    public static DateTime toDateTime(DataRow row, string field)
    {
        if (row[field] != DBNull.Value) return (DateTime)row[field]; else return new DateTime();
    }

    public static bool ToBool(DataRow row, string fielName)
    {
        if (row[fielName] != DBNull.Value) return (bool)row[fielName]; else return new bool();
    }
}

