using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatesUpdated.Services.Respository;
public interface ITenantService
{
    ValueTask<IImmutableList<TenantDetails>> RetrieveTenantDetails(CancellationToken ct);
}
