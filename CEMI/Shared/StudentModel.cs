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

        //[Required(ErrorMessage = "Voornaam is een verplicht veld.")]
        public string? FirstName { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Familienaam is een verplicht veld.")]
        public string? LastName { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Geboortedatum is een verplicht veld.")]
        public DateTime? BirthDate { get; set; } = DateTime.Now;

        //[Required(ErrorMessage = "'Telefoon 1' is een verplicht veld.")]
        public string? Phone_1 { get; set; } = string.Empty;

        public string? Phone_2 { get; set; }

        //[Required(ErrorMessage = "'E-mail 1' is een verplicht veld.")]
        public string? Email1 { get; set; } = string.Empty;

        public string? Email2 { get; set; }

        public bool HomeAlone { get; set; } = false;

        public string? Remarks { get; set; }

        public bool Enrolled { get; set; } = false;

        #region Address 

        //[Required(ErrorMessage = "Straat is een verplicht veld.")]
        public string? Street1 { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Huisnummer is een verplicht veld.")]
        public string? HouseNumber1 { get; set; } = string.Empty;


        //[Required(ErrorMessage = "Postcode is een verplicht veld.")]
        public string? PostalCode1 { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Gemeente is een verplicht veld.")]
        public string? District1 { get; set; } = string.Empty;

        #endregion
    }
}
