using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public enum ClaimType
    {
        Car, Home, Theft
    }

    public class Claims
    {
        public int ClaimId { get; set; }
        public string ClaimDescription { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public ClaimType TypeOfClaim { get; set; }

        public Claims() { }
        public Claims(int claimId, string claimDescription, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid , ClaimType typeOfClaim)
        {
            ClaimId = claimId;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            TypeOfClaim = typeOfClaim;

        }

    }
}
