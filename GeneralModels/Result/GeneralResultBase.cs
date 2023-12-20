namespace Easy.GeneralModels.Result;

public class GeneralResult<T> : IDisposable
{
    public T Data { get; set; }
    public bool Success { get; set; } = true;
    public IEnumerable<Error> Errors { get; set; } = Array.Empty<Error>();

    public GeneralResult()
    {
        Success = true;
        Errors = Array.Empty<Error>();
        Data = default;
    }

    public GeneralResult(T data)
    {
        Success = true;
        Errors = Array.Empty<Error>();
        Data = data;
    }

    public GeneralResult(bool success)
    {
        Success = success;
        Errors = Array.Empty<Error>();
        Data = default;
    }

    public GeneralResult(Error error)
    {
        Success = false;
        Errors = new Error[1] { error };
        Data = default;
    }

    public GeneralResult(IEnumerable<Error> errors)
    {
        Success = false;
        Errors = errors;
        Data = default;
    }

    public GeneralResult(bool success, Error error)
    {
        Success = success;
        Errors = new Error[1] { error };
        Data = default;
    }

    public GeneralResult(bool success, IEnumerable<Error> errors)
    {
        Success = success;
        Errors = errors;
        Data = default;
    }

    public GeneralResult(T data, bool success)
    {
        Success = success;
        Errors = Array.Empty<Error>();
        Data = data;
    }

    public GeneralResult(T data, bool success, Error error)
    {
        Success = success;
        Errors = new Error[1] { error };
        Data = data;
    }

    public GeneralResult(T data, bool success, IEnumerable<Error> errors)
    {
        Success = success;
        Errors = errors;
        Data = data;
    }

    public static implicit operator GeneralResult(GeneralResult<T> result)
    {
        return new GeneralResult(result.Data, result.Success, result.Errors);
    }

    public static implicit operator GeneralResult<T>(GeneralResult result)
    {
        return new GeneralResult<T>((T)result.Data, result.Success, result.Errors);
    }

    public void Dispose()
    {
        if (Data.GetType().GetInterfaces().Contains(typeof(IDisposable)))
        {
            (Data as IDisposable).Dispose();
        }

        GC.SuppressFinalize(this);
    }
}
