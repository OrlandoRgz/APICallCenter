using System.Data.SqlClient;

public class Sessions
{
    #region SQL Statement
    private static string selectSession = "select id, dateTimeLogin, dateTimeLogout, idAgent, idStation, idCurrentCall, active from sessions";
    #endregion

    #region attributes
    private int _id;
    private DateTime _dateTimeLogin;
    private DateTime _dateTimeLogout;
    #endregion

    #region properties

    #endregion


    #region constructor

    #endregion


    #region method
    public static List<Sessions> GetAll()
    {
        SqlCommand command = new SqlCommand(selectSession);
        return command;
    }

    #endregion
}

