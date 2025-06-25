using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;

namespace EstatesUpdated.Models;
public partial record TenantDetails()
{
    public int TenantId { get; init; }

    public string? FirstName { get; init; }

    public string? LastName { get; init; } 

    public string? NinNumber { get; init; } 

    public DateOnly BirthDate { get; init; }

    public string? Gender { get; init; } 

    public string? PhoneNumber { get; init; } 

    public int OccupantsNumber { get; init; }

    public int MaritalstatusId { get; init; }

    public string? NextofkinName { get; init; } 
    public int NokRelationshipId { get; init; }

    public string? NokPhonenumber { get; init; } 

    public int HouseId { get; init; }

    public DateTime AddedOn { get; init; }

    public string? TdMaritalstatus { get; init; }

    public string? TdNokRelationship { get; init; }

    public string? TdHouse { get; init; } 

}


//(int TenantId, string FirstName, string LastName, string NinNumber, DateOnly BirthDate,
//string Gender, string PhoneNumber, int OccupantsNumber, int MaritalstatusId, string NextofkinName, 
//int NokRelationshipId, string NokPhonenumber, int HouseId, DateTime AddedOn, string TdMaritalstatus,
// string TdNokRelationship, string TdHouse);
