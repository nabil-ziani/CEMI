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

        [Display(Name = "Niveau 4 (deel 1)")]
        LevelFour,

        [Display(Name = "Niveau 4 (deel 2)")]
        LevelFourPartTwo,
    }

    /// <summary>
    /// TODO: verify if it's relevant to show the current class..
    /// </summary>
    public enum Time { VM, MD, NM, Wednesday }
    public enum Lecturer { Inas, Amina, Naima, Ikram, Mohamed, Najat, Sanaa, Abdelhakim, Abdelmonaim, Nabil, Assia, Ouafaa, OumZakaria, Layla }

    public class StudentModel
    {
        public int Id { get; set; }
        public ClassLevel ClassLevel { get; set; }

        public string? FirstName { get; set; } = string.Empty;

        public string? LastName { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; } = null;

        public string? Phone_1 { get; set; } = string.Empty;

        public string? Phone_2 { get; set; }

        public string? Email1 { get; set; } = string.Empty;

        public string? Email2 { get; set; }

        public bool HomeAlone { get; set; } = false;

        public string? Remarks { get; set; }

        public bool Enrolled { get; set; } = false;

        public bool OldStudent { get; set; } = false;

        public bool Graduated { get; set; } = false;

        #region Address 

        public string? Street1 { get; set; } = string.Empty;

        public string? HouseNumber1 { get; set; } = string.Empty;

        public string? PostalCode1 { get; set; } = string.Empty;

        public string? District1 { get; set; } = string.Empty;

        #endregion
    }
}