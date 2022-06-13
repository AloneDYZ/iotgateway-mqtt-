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
    public partial class DeviceVariableBatchVM : BaseBatchVM<DeviceVariable, DeviceVariable_BatchEdit>
    {
        public DeviceVariableBatchVM()
        {
            ListVM = new DeviceVariableListVM();
            LinkedVM = new DeviceVariable_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class DeviceVariable_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
