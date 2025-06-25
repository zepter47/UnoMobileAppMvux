using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;

namespace EstatesUpdated.Services.Respository;
public class TenantService : ITenantService
{
    private readonly IAppNative _native;

    //public TenantService() { }

    public TenantService(IAppNative native)
    {
        _native = native;
    }
    public async ValueTask<IImmutableList<TenantDetails>> RetrieveTenantDetails(CancellationToken ct)
    {
        var response = await _native.GetTenantDetails();

        var Tena_Data = response.Content;

        var TenantDatas = Tena_Data.Select(y => new TenantDetails()
        {
            FirstName = y.FirstName,
            LastName = y.LastName,
            TdHouse = y.TdHouse
        }).ToImmutableList(); //?? ImmutableList<TenantDetails>.Empty; ;

        return TenantDatas;

            
    }
}
