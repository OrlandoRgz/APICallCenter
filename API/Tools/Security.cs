
public class Security
{
    //Esta clase solo es para validar el token
    public static bool ValidateToken(string username, string token)
    {
        if (token == "123456")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //Este metodo lo agregamos para el enumerador, que ya tiene los mensajes de error con su codigo
    public static ErrorResponse GetError(SecurityError error)
    {
        ErrorResponse er = new ErrorResponse();
        er.Status = (int)error;
        er.ErrorMessage = error.ToString();
        return er;
    }
}

