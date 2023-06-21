﻿using System.ComponentModel.DataAnnotations;
using Postgrest.Models;
using Postgrest.Attributes;

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

        [Display(Name = "Niveau 3 (deel 1)")]
        LevelThree,

        [Display(Name = "Niveau 3 (deel 2)")]
        LevelThreePartTwo,

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

    [Table("students")]
    public class StudentModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("class")]
        public string? Class { get; set; }

        [Column("level")]
        public ClassLevel Level { get; set; }

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