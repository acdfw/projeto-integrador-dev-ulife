namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public abstract class BaseResponse
    {
        private Dictionary<int, List<string>> _errors { get; set; } = new Dictionary<int, List<string>>();

        public IReadOnlyDictionary<int, List<string>> Errors => _errors;

        public bool IsSuccess => !_errors.Any();

        public void AddError(int code, List<string> errorMessage)
        {
            _errors.Add(code, errorMessage);
        }
    }
}
