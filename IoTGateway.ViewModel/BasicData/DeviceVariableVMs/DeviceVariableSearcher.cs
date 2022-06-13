using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.BasicData.DeviceVariableVMs
{
    public partial class DeviceVariableSearcher : BaseSearcher
    {
        [Display(Name = "变量名")]
        public String Name { get; set; }
        [Display(Name = "方法")]
        public String Method { get; set; }
        [Display(Name = "地址")]
        public String DeviceAddress { get; set; }
        public Guid? DeviceId { get; set; }

        protected override void InitVM()
        {
        }

    }
}
