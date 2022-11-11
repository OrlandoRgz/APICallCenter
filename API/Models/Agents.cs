using System.Data;
using System.Data.SqlClient;

public class Agents
{
    #region SQL Statements
    private static string selectField = "select id, name, photo, pin from agents";
    #endregion

    #region attributes
    private int _id;
    private string _name;
    private string _photo;
    private int _pin;
    #endregion

    #region properties
    public int id       { get => _id;    set => _id = value; }
    public string name  { get => _name;  set => _name = value; }
    public string photo { get => _photo; set => _photo = value; }
    public int pin      { get => _pin;   set => _pin = value; }
    #endregion

    #region constructors
    public Agents()
    {
        _id    = 0;
        _name  = "";
        _photo = "";
        _pin   = 0;
    }

    public Agents(int id, string name, string photo, int pin)
    {
        _id = id;
        _name = name;
        _photo = photo;
        _pin = pin;
    }
    #endregion

    #region class methods
    public static List<Agents> GetAll()
    {
        SqlCommand command = new SqlCommand(selectField + " order by id");
        return AgentsMappers.ToList(SqlServerConnection.ExecuteQuery(command));
    }
    #endregion


}

