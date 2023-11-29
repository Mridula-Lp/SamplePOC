using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleCRUD.Core.Helper;
using SampleCRUD.Service.Abstract;
using SampleCRUD.ViewModel.ViewModels;
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
        [HttpPost("~/api/Setting")]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddSetting([FromBody] SettingViewModel setting)
        {
            try
            {

                var res = new BaseResponse();
                var result = await _settingService.AddSetting(setting);
                if (result)
                {
                    res.ResponseCode = ResponseCodes.Success;
                    res.ResponseMessage = "Record Saved";
                }
                else
                {
                    res.ResponseCode = ResponseCodes.InvalidModel;
                    res.ResponseMessage = "Invalid";
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
