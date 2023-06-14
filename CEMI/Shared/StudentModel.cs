using System.ComponentModel.DataAnnotations;

namespace CEMI.Shared
{
    public enum ClassLevel
    {
        [Display(Name = "Tamhiedi")]
        Tamhidi,

        [Display(Name = "Niveau 1")]
        LevelOne,

        [Display(Name = "Niveau 2")]
        LevelTwo,

        [Display(Name = "Niveau 3")]
        LevelThree,

        [Display(Name = "Niveau 4")]
        LevelFour
    }

    /// <summary>
    /// TODO: verify if it's relevant to show the current class..
    /// </summary>
    public enum Time { VM, MD, NM, Wednesday }
    public enum Lecturer { Inas, Amina, Naima, Ikram, Mohamed, Najat, Sanaa, Abdelhakim, Abdelmonaim, Nabil, Assia, Ouafaa, OumZakaria, Layla }

    public class StudentModel
    {
        public int Id { get; set; }
        public ClassLevel? ClassLevel { get; set; }

        [Required(ErrorMessage = "Voornaam is een verplicht veld.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Familienaam is een verplicht veld.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Geboortedatum is een verplicht veld.")]
        public DateTime BirthDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "'Telefoon 1' is een verplicht veld.")]
        public string Phone1 { get; set; } = string.Empty;

        public string? Phone2 { get; set; }

        [Required(ErrorMessage = "'E-mail 1' is een verplicht veld.")]
        public string Email1 { get; set; } = string.Empty;

        public string? Email2 { get; set; }

        public bool HomeAlone { get; set; } = false;

        public string? Remarks { get; set; }

        #region Address1 

        [Required(ErrorMessage = "'Straat 1' is een verplicht veld.")]
        public string Street1 { get; set; } = string.Empty;

        [Required(ErrorMessage = "'Huisnummer 1' is een verplicht veld.")]
        public string HouseNumber1 { get; set; } = string.Empty;


        [Required(ErrorMessage = "'Postcode 1' is een verplicht veld.")]
        public string PostalCode1 { get; set; } = string.Empty;

        [Required(ErrorMessage = "'Gemeente 1' is een verplicht veld.")]
        public string District1 { get; set; } = string.Empty;

        #endregion

        #region Address2

        public string? Street2 { get; set; }
        public string? HouseNumber2 { get; set; }
        public string? PostalCode2 { get; set; }
        public string? District2 { get; set; }

        #endregion
    }
}
