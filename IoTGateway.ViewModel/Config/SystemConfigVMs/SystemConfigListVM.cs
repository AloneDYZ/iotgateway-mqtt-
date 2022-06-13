using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.Config.SystemConfigVMs
{
    public partial class SystemConfigListVM : BasePagedListVM<SystemConfig_View, SystemConfigSearcher>
    {

        protected override IEnumerable<IGridColumn<SystemConfig_View>> InitGridHeader()
        {
            return new List<GridColumn<SystemConfig_View>>{
                this.MakeGridHeader(x => x.GatewayName),
                this.MakeGridHeader(x => x.MqttIp),
                this.MakeGridHeader(x => x.MqttPort),
                this.MakeGridHeader(x => x.MqttUName),
                this.MakeGridHeader(x => x.MqttUPwd),
                this.MakeGridHeader(x => x.IoTPlatformType),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<SystemConfig_View> GetSearchQuery()
        {
            var query = DC.Set<SystemConfig>()
                .Select(x => new SystemConfig_View
                {
				    ID = x.ID,
                    GatewayName = x.GatewayName,
                    MqttIp = x.MqttIp,
                    MqttPort = x.MqttPort,
                    MqttUName = x.MqttUName,
                    MqttUPwd = x.MqttUPwd,
                    IoTPlatformType = x.IoTPlatformType,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class SystemConfig_View : SystemConfig{

    }
}
