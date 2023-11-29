

using SampleCRUD.Core.Helper;

namespace SampleCRUD.ViewModel.ViewModels
{
    public class BaseResponse
    {
        public ResponseCodes ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}
