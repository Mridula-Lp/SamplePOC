using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleCRUD.Service.Abstract;
using static IdentityModel.OidcConstants;

namespace SampleCRUD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly ISettingService _settingService;
        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        //[HttpPost("~/api/WorkHistory")]
        //[ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        //public async Task<IActionResult> AddSetting([FromBody] SettingViewModel setting)
        //{
        //    try
        //    {

        //        var res = new BaseResponse();
        //        var result = await _workHistoryService.SaveWorkHistory(work, aspNetUser);
        //        if (result)
        //        {
        //            res.ResponseCode = ResponseCodes.Success;
        //            res.ResponseMessage = SystemMessages.RecordsSaved;
        //        }
        //        else
        //        {
        //            res.ResponseCode = ResponseCodes.InvalidModel;
        //            res.ResponseMessage = SystemMessages.InvalidParameter;
        //        }
        //        return Ok(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
    }
}
