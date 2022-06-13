using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IoTGateway.Model;
using PluginInterface;


namespace IoTGateway.ViewModel.BasicData.DeviceVariableVMs
{
    public partial class DeviceVariableListVM : BasePagedListVM<DeviceVariable_View, DeviceVariableSearcher>
    {

        protected override IEnumerable<IGridColumn<DeviceVariable_View>> InitGridHeader()
        {
            return new List<GridColumn<DeviceVariable_View>>{
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.Method),
                this.MakeGridHeader(x => x.DeviceAddress),
                this.MakeGridHeader(x => x.DataType),
                this.MakeGridHeader(x => x.Expressions),
                this.MakeGridHeader(x => x.ProtectType),
                this.MakeGridHeader(x => x.DeviceName_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<DeviceVariable_View> GetSearchQuery()
        {
            var query = DC.Set<DeviceVariable>()
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckContain(Searcher.Method, x=>x.Method)
                .CheckContain(Searcher.DeviceAddress, x=>x.DeviceAddress)
                .CheckEqual(Searcher.DeviceId, x=>x.DeviceId)
                .Select(x => new DeviceVariable_View
                {
				    ID = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    Method = x.Method,
                    DeviceAddress = x.DeviceAddress,
                    DataType = x.DataType,
                    Expressions = x.Expressions,
                    ProtectType = x.ProtectType,
                    DeviceName_view = x.Device.DeviceName,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class DeviceVariable_View : DeviceVariable{
        [Display(Name = "名称")]
        public String DeviceName_view { get; set; }

    }
}
