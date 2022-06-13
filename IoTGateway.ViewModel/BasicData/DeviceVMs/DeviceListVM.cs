using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.BasicData.DeviceVMs
{
    public partial class DeviceListVM : BasePagedListVM<Device_View, DeviceSearcher>
    {

        protected override IEnumerable<IGridColumn<Device_View>> InitGridHeader()
        {
            return new List<GridColumn<Device_View>>{
                this.MakeGridHeader(x => x.DeviceName),
                this.MakeGridHeader(x => x.Index),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.AssembleName_view),
                this.MakeGridHeader(x => x.AutoStart),
                this.MakeGridHeader(x => x.CgUpload),
                this.MakeGridHeader(x => x.EnforcePeriod),
                this.MakeGridHeader(x => x.DeviceTypeEnum),
                this.MakeGridHeader(x => x.DeviceName_view),
                this.MakeGridHeader(x=>x.ParentId).SetHide(),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Device_View> GetSearchQuery()
        {
            var query = DC.Set<Device>()
                .CheckContain(Searcher.DeviceName, x=>x.DeviceName)
                .CheckEqual(Searcher.DriverId, x=>x.DriverId)
                .Select(x => new Device_View
                {
				    ID = x.ID,
                    ParentId = x.ParentId,
                    DeviceName = x.DeviceName,
                    Index = x.Index,
                    Description = x.Description,
                    AssembleName_view = x.Driver.AssembleName,
                    AutoStart = x.AutoStart,
                    CgUpload = x.CgUpload,
                    EnforcePeriod = x.EnforcePeriod,
                    DeviceTypeEnum = x.DeviceTypeEnum,
                    DeviceName_view = x.Parent.DeviceName,
                })
                .OrderBy(x => x.Index);
            return query;
        }

    }

    public class Device_View : Device{
        [Display(Name = "程序集名")]
        public String AssembleName_view { get; set; }
        [Display(Name = "名称")]
        public String DeviceName_view { get; set; }

    }
}
