using SampleCRUD.ViewModel;
using SampleCRUD.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.Service.Abstract
{
    public interface ISettingService
    {
        Task<bool> AddSetting(SettingViewModel setting);
    }
}
