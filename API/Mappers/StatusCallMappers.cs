
using System.Data;

public class StatusCallMappers
{
    public static StatusCall ToObject(DataRow row)
    {
        StatusCall statusCall        = new StatusCall();
        statusCall.Id                = Convert.ToInt(row, "id");
        statusCall.Description       = Convert.ToString(row, "description");
        statusCall.AvailableToAnswer = Convert.ToBool(row, "availableToAnswer");
        return statusCall;
    }

    public static List<StatusCall> ToList(DataTable table)
    {
        List<StatusCall> list = new List<StatusCall>();
        foreach(DataRow row in table.Rows)
        {
            list.Add(ToObject(row));
        }
        return list;
    }
}

