using AutoMapper;
using SampleCRUD.DataModel;
using SampleCRUD.ViewModel;
using SampleCRUD.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.Service
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<SettingDataModel, SettingViewModel>().ReverseMap();
        }
    }
}
