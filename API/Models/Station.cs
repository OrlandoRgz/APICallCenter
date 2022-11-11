
using System.Data;
using System.Data.SqlClient;

public class Station
{
    #region SQL Statements
    private static string selectField = "select id, rowNumber, deskNumber, ipAddress, active from stations";
    #endregion

    #region attributes
    private int _id;
    private int _rowNumber;
    private int _deskNumber;
    private string _ipAddress;
    private bool _active;
    #endregion

    #region properties
    public int Id { get => _id; set => _id = value; }
    public int RowNumber { get => _rowNumber; set => _rowNumber = value; }
    public int DeskNumber { get => _deskNumber; set => _deskNumber = value; }
    public string IpAddress { get => _ipAddress; set => _ipAddress = value; }
    public bool Active { get => _active; set => _active = value; }
    #endregion

    #region constructors
    public Station()
    {
        _id = 0;
        _rowNumber = 0;
        _deskNumber = 0;
        _ipAddress = "";
        _active = true;
    }

    public Station(int id, int rowNumber, int deskNumber, string ipAddress, bool active)
    {
        _id = id;
        _rowNumber = rowNumber;
        _deskNumber = deskNumber;
        _ipAddress = ipAddress;
        _active = active;
    }
    #endregion

    #region class methods
    public static List<Station> GetAll()
    {
        SqlCommand command = new SqlCommand(selectField + " order by id");
        return StationMappers.ToList(SqlServerConnection.ExecuteQuery(command));
    }
    #endregion


}

