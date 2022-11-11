using System.Data.SqlClient;

public class StatusCall
{
    #region SQL Command
    private static string selectStatusCall = "select id, description, availableToAnswer from statusCall";
    #endregion

    #region attributes
    private int    _id;
    private string _description;
    private bool   _availableToAnswer;
    #endregion

    #region properties
    public int    Id { get => _id; set => _id = value; }
    public string Description { get => _description; set => _description = value; }
    public bool   AvailableToAnswer { get => _availableToAnswer; set => _availableToAnswer = value; }
    #endregion

    #region constructor
    public StatusCall()
    {
        _id = 0;
        _description = "";
        _availableToAnswer = true;
    }

    public StatusCall(int id, string description, bool availableToAnswer)
    {
        _id = id;
        _description = description;
        _availableToAnswer = availableToAnswer;
    }
    #endregion

    #region methods
    public static List<StatusCall> GetAll()
    {
        SqlCommand command = new SqlCommand(selectStatusCall);
        return StatusCallMappers.ToList(SqlServerConnection.ExecuteQuery(command));
    }
    #endregion
}

