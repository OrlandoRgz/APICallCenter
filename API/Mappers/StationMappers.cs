
using System.Data;
using System.Net;
using System.Security.Cryptography;

public class StationMappers
{
    public static Station ToObject(DataRow row)
    {
        Station station = new Station();
        station.Id         = Convert.ToInt(row, "id");
        station.RowNumber  = Convert.ToInt(row, "rowNumber");
        station.DeskNumber = Convert.ToInt(row, "deskNumber");
        station.IpAddress  = Convert.ToString(row, "ipAddress");
        station.Active     = Convert.ToBool(row, "active");
        return station;
    }

    public static List<Station> ToList(DataTable table)
    {
        List<Station> list = new List<Station>();
        foreach(DataRow row in table.Rows)
        {
            list.Add(ToObject(row));
        }
        return list;
    }
}

