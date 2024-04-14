using System.Net;

namespace MagicVilla_Web.Models.Model
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string>? ErrorsMessage { get; set; }
        public object Result { get; set; }
        public List<string> ErrorMessages { get; internal set; }
    }
}
