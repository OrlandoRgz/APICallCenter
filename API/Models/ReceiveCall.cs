using System.Data.SqlClient;

public class ReceiveCall
{
    #region SQL Statement
    private static string selectCall = "select * from viewCalls";
    #endregion

    #region atributes
    private int        _id;
    private DateTime   _datetimeReceived;
    private DateTime   _datetimeAnswered;
    private DateTime   _datetimeEnded;
    private string     _phoneNumber;
    private Sessions   _session;
    private StatusCall _statusCall;

    #endregion
}

