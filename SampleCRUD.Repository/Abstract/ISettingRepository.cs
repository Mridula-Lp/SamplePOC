using SampleCRUD.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.Repository.Abstract
{
    public interface ISettingRepository
    {
        public   Task<bool> AddSetting(SettingDataModel setting);
    }
}
