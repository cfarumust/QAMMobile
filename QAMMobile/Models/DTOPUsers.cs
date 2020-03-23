using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAMMobile.Models
{
    public class DTOPUsers
    {
        public long nUserId { get; set; }
        public string sFirstName { get; set; }
        public string sLastName { get; set; }
        public string sAddress1 { get; set; }
        public string sAddress2 { get; set; }
        public string sAddress3 { get; set; }
        public string sPhoneNumber { get; set; }
        public string sEmailAddress { get; set; }
        public string sGender { get; set; }
        public string sTitle { get; set; }
        public long nCompanyId { get; set; }
        public long nVerified { get; set; }
        public string sLicenseNumber { get; set; }
        public long nLicenseType { get; set; }
        public string sLicenseIssuedOn { get; set; }
        public string sLicenseExpiryDate { get; set; }
        public string sLicenseIssuingAuthority { get; set; }
        public string sInfractions { get; set; }

    }
}
