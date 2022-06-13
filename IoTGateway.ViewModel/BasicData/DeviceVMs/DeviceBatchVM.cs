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
    public partial class DeviceBatchVM : BaseBatchVM<Device, Device_BatchEdit>
    {
        public DeviceBatchVM()
        {
            ListVM = new DeviceListVM();
            LinkedVM = new Device_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Device_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
