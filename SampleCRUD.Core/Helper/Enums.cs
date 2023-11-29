using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SampleCRUD.Core.Helper
{
    public enum ResponseCodes
    {
        [Description("Error")]
        Error = 0,
        [Description("Success")]
        Success = 200,
        [Description("Duplicate")]
        Duplicate = 300,
        [Description("Invalid Model")]
        InvalidModel = 303,
        [Description("Invalid User")]
        Unauthorized = 401,
        [Description("Not Found")]
        NotFound = 404,
        [Description("Error code")]
        ErrorCode = 400,
        NoteNotFound = 405,
        CannedMessageNotFound = 405


    }

}
