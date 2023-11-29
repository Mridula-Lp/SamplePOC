using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SampleCRUD.DataModel;
using SampleCRUD.DataModel.Data;
using SampleCRUD.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.Repository.Concrete
{
    public class SettingRepository: ISettingRepository
    {
        private readonly SampleCRUDContext _context;
        public SettingRepository(SampleCRUDContext context)
        {
            _context = context; 
        }
        public async Task<bool> AddSetting(SettingDataModel setting)
        {
            setting.CreatedDate =DateTime.Now;
            setting.LastModifiedDate = DateTime.Now;
            setting.IsDeleted = false;
            await _context.Setting.AddAsync(setting);
            _context.SaveChanges();
            return true;
        }
    }
}
