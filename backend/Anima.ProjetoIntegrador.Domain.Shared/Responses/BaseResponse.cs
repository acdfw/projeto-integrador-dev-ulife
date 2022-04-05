namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public abstract class BaseResponse
    {
        private Dictionary<int, string> _errors { get; set; } = new Dictionary<int, string>();

        public IReadOnlyDictionary<int, string> Errors => _errors;

        public bool IsSuccess => !_errors.Any();

        public void AddError(int code, string errorMessage)
        {
            _errors.Add(code, errorMessage);
        }
    }
}
