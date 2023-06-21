using Postgrest.Attributes;
using Postgrest.Models;

namespace CEMI.Shared
{
    [Table("students")]
    public class CreateStudent : BaseModel
    {
        [Column("level")]
        public ClassLevel ClassLevel { get; set; }

        [Column("firstname")]
        public string? FirstName { get; set; } = string.Empty;

        [Column("lastname")]
        public string? LastName { get; set; } = string.Empty;

        [Column("birthdate")]
        public DateTime? BirthDate { get; set; } = null;

        [Column("phone_1")]
        public string? Phone_1 { get; set; } = string.Empty;

        [Column("phone_2")]
        public string? Phone_2 { get; set; }

        [Column("email_1")]
        public string? Email1 { get; set; } = string.Empty;

        [Column("email_2")]
        public string? Email2 { get; set; }

        [Column("homealone")]
        public bool HomeAlone { get; set; } = false;

        [Column("remarks")]
        public string? Remarks { get; set; }

        [Column("enrolled")]
        public bool Enrolled { get; set; } = false;

        [Column("oldstudent")]
        public bool OldStudent { get; set; } = false;

        [Column("graduated")]
        public bool Graduated { get; set; } = false;

        #region Address 

        [Column("street")]
        public string? Street { get; set; } = string.Empty;

        [Column("housenumber")]
        public string? HouseNumber { get; set; } = string.Empty;

        [Column("postalcode")]
        public string? PostalCode { get; set; } = string.Empty;

        [Column("district")]
        public string? District { get; set; } = string.Empty;

        #endregion
    }
}
