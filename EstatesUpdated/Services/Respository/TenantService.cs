using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Windows.Networking;

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

        var TenantDatas = Tena_Data.Select(y => new TenantDetails(
             y.FirstName,
            y.LastName,
            y.NinNumber,
            y.BirthDate,
            y.Gender,
            y.PhoneNumber,
            y.OccupantsNumber,
            y.MaritalstatusId,
            y.NextofkinName,
            y.NokRelationshipId,
            y.NokPhonenumber,
            y.HouseId,
            y.AddedOn,
            y.TdMaritalstatus,
            y.TdNokRelationship,
            y.TdHouse
            )).ToImmutableList(); //?? ImmutableList<TenantDetails>.Empty; ;

        //var TenantDatas = Tena_Data.Select(y => new TenantDetails(y)).ToImmutableList(); //?? ImmutableList<TenantDetails>.Empty; ;

        //var TenantDatas = Tena_Data.ToImmutableList();


        return TenantDatas;

            
    }
}
