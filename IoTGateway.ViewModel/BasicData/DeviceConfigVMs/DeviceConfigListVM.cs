using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.BasicData.DeviceConfigVMs
{
    public partial class DeviceConfigListVM : BasePagedListVM<DeviceConfig_View, DeviceConfigSearcher>
    {

        protected override IEnumerable<IGridColumn<DeviceConfig_View>> InitGridHeader()
        {
            return new List<GridColumn<DeviceConfig_View>>{
                this.MakeGridHeader(x => x.DeviceConfigName),
                this.MakeGridHeader(x => x.DataSide),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.Value),
                this.MakeGridHeader(x => x.EnumInfo),
                this.MakeGridHeader(x => x.DeviceName_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<DeviceConfig_View> GetSearchQuery()
        {
            var query = DC.Set<DeviceConfig>()
                .CheckContain(Searcher.DeviceConfigName, x=>x.DeviceConfigName)
                .CheckEqual(Searcher.DataSide, x=>x.DataSide)
                .CheckContain(Searcher.Value, x=>x.Value)
                .CheckEqual(Searcher.DeviceId, x=>x.DeviceId)
                .Select(x => new DeviceConfig_View
                {
				    ID = x.ID,
                    DeviceConfigName = x.DeviceConfigName,
                    DataSide = x.DataSide,
                    Description = x.Description,
                    Value = x.Value,
                    EnumInfo = x.EnumInfo,
                    DeviceName_view = x.Device.DeviceName,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class DeviceConfig_View : DeviceConfig{
        [Display(Name = "名称")]
        public String DeviceName_view { get; set; }

    }
}
