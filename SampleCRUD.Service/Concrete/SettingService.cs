using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using SampleCRUD.DataModel;
using SampleCRUD.Repository.Abstract;
using SampleCRUD.Service.Abstract;
using SampleCRUD.ViewModel;
using SampleCRUD.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.Service.Concrete
{
    public class SettingService: ISettingService
    {
        private readonly ISettingRepository _settingRepository;
        private IMapper Mapper
        {
            get;
        }
        public SettingService(ISettingRepository settingRepository, IMapper mapper)
        {
            _settingRepository = settingRepository;
            Mapper = mapper;
        }
        public async Task<bool> AddSetting(SettingViewModel setting)
        {
            var res = Mapper.Map<SettingViewModel, SettingDataModel>(setting);
            return await _settingRepository.AddSetting(res);
        }

    }
}
