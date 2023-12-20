using Easy.GeneralModels.Resources.Txt;

namespace Easy.GeneralModels.Result;

public class Error
{
    public string Message { get; set; }
    public int Code { get; set; }

    public Error()
    {
        Code = 500;
        Message = Massages.General.Failure;
    }

    public Error(int code, string message)
    {
        Code = code;
        Message = message;
    }

}
