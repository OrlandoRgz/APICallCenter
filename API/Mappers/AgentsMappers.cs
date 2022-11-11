using System.Data;

public class AgentsMappers
{
    //Mapeo de las columnas de la tabla en BD
    public static Agents ToObject(DataRow row)
    {
        var agents   = new Agents();
        agents.id    = Convert.ToInt(row, "id");
        agents.name  = Convert.ToString(row, "name");
        agents.photo = Convert.ToString(row, "photo");
        agents.pin   = Convert.ToInt(row, "pin");
        return agents;
    }

    //Devolver una lista ya mapeada
    public static List<Agents> ToList(DataTable table)
    {
        List<Agents> list = new List<Agents>();
        foreach (DataRow row in table.Rows)
        {
            list.Add(ToObject(row));
        }
        return list;
    }

}

