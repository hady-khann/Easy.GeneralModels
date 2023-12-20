using static Easy.GeneralModels.Resources.Txt.Massages;

namespace Easy.GeneralModels.Result;

public class GeneralResult : GeneralResult<object>
{
    public static GeneralResult Done()
    {
        return new GeneralResult(null, success: true);
    }

    public static GeneralResult<T> Done<T>()
    {
        return new GeneralResult<T>(default, success: true);
    }

    public static GeneralResult<T> Done<T>(T data)
    {
        return new GeneralResult<T>(data, success: true);
    }



    public static GeneralResult BadRequest(Error error)
    {
        return new GeneralResult(success: false, error);
    }

    public static GeneralResult Exception(Error error)
    {
        return new GeneralResult(success: false, error);
    }

    public static GeneralResult Fail(Error error)
    {
        return new GeneralResult(success: false, error);
    }



    public static GeneralResult BadRequest(string message = null)
    {
        return new GeneralResult(success: false, error: new Error(400, General.BadRequest + message));
    }

    public static GeneralResult NotFound(string message = null)
    {
        return new GeneralResult(success: false, error: new Error(400, General.NotFound + message));
    }

    public static GeneralResult Exception(string message = null)
    {
        return new GeneralResult(success: false, error: new Error(501, General.Exception + message));
    }

    public static GeneralResult Fail(string message = null)
    {
        return new GeneralResult(success: false, error: new Error(500, General.Failure + message));
    }

    public GeneralResult()
    {
        Success = true;
        Errors = Array.Empty<Error>();
        Data = null;
    }

    public GeneralResult(object data)
    {
        Success = true;
        Errors = Array.Empty<Error>();
        Data = data;
    }

    public GeneralResult(bool success)
    {
        Success = success;
        Errors = Array.Empty<Error>();
        Data = null;
    }

    public GeneralResult(Error error)
    {
        Success = false;
        Errors = new Error[1] { error };
        Data = null;
    }

    public GeneralResult(IEnumerable<Error> errors)
    {
        Success = false;
        Errors = errors;
        Data = null;
    }

    public GeneralResult(bool success, Error error)
    {
        Success = success;
        Errors = new Error[1] { error };
        Data = null;
    }

    public GeneralResult(bool success, IEnumerable<Error> errors)
    {
        Success = success;
        Errors = errors;
        Data = null;
    }

    public GeneralResult(object data, bool success)
    {
        Success = success;
        Errors = Array.Empty<Error>();
        Data = data;
    }

    public GeneralResult(object data, bool success, Error error)
    {
        Success = success;
        Errors = new Error[1] { error };
        Data = data;
    }

    public GeneralResult(object data, bool success, IEnumerable<Error> errors)
    {
        Success = success;
        Errors = errors;
        Data = data;
    }
}
