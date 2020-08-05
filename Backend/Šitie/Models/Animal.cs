using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Šitie.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public DateTime ArivalDate { get; set; }
        public DateTime ChipDate { get; set; }
        public DateTime VaccineDate { get; set; }
        public string ArrivedFrom { get; set; }
        public AnimalType Type { get; set; }
        public Gender Gender { get; set; }
        public DateTime BornDate { get; set; }
        public FurType FurType { get; set; }
        public string FurColor { get; set; }
        public string Description { get; set; }
        public string HealthCondition { get; set; }
        public string OrganizationData { get; set; }
        public AnimalStatus Status { get; set; }
        public DateTime DepartureDate { get; set; }
    }
    public enum AnimalType
    {
        Cat,
        Dog,
        Other
    }

    public enum Gender
    {
        Male,
        Female,
        None
    }

    public enum FurType
    {
        Shorthair,
        Roughhair,
        Mediumhair,
        Longhair
    }

    public enum AnimalStatus
    {
        Shelter,
        Dead,
        Adopted
    }
}
