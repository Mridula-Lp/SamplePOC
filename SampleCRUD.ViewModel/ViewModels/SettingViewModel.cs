using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.ViewModel.ViewModels
{
    public class SettingViewModel
    {
        public Int64 Id { get; set; }
        public string Key { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Description { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public DateTime? LastModifiedDate { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
