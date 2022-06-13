using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IoTGateway.Model;


namespace IoTGateway.ViewModel.BasicData.DriverVMs
{
    public partial class DriverListVM : BasePagedListVM<Driver_View, DriverSearcher>
    {

        protected override IEnumerable<IGridColumn<Driver_View>> InitGridHeader()
        {
            return new List<GridColumn<Driver_View>>{
                this.MakeGridHeader(x => x.DriverName),
                this.MakeGridHeader(x => x.FileName),
                this.MakeGridHeader(x => x.AssembleName),
                this.MakeGridHeader(x => x.AuthorizesNum),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Driver_View> GetSearchQuery()
        {
            var query = DC.Set<Driver>()
                .CheckContain(Searcher.DriverName, x=>x.DriverName)
                .CheckContain(Searcher.AssembleName, x=>x.AssembleName)
                .Select(x => new Driver_View
                {
				    ID = x.ID,
                    DriverName = x.DriverName,
                    FileName = x.FileName,
                    AssembleName = x.AssembleName,
                    AuthorizesNum = x.AuthorizesNum,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Driver_View : Driver{

    }
}
