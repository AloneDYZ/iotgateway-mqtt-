using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.BasicData.DeviceVMs
{
    public partial class DeviceSearcher : BaseSearcher
    {
        [Display(Name = "名称")]
        public String DeviceName { get; set; }
        public Guid? DriverId { get; set; }

        protected override void InitVM()
        {
        }

    }
}
