using static MagicVilla_Utility.staticdetails;

namespace MagicVilla_Web.Models.Model
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data {  get; set; }
    }
}
