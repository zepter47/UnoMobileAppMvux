using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using EstatesUpdated.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstatesUpdated.Services.Respository;

namespace EstatesUpdated.Vm;
public partial record ResidentsListModel
{
    private readonly ITenantService _tenantService;

    public ResidentsListModel() { }

    public ResidentsListModel(ITenantService tenantService)
    {
        _tenantService = tenantService;
    }

    public IListFeed<TenantDetails> TenantsList => ListFeed.Async( _tenantService.RetrieveTenantDetails);
}
