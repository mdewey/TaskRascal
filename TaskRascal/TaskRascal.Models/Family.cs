using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskRascal.Models
{
    public class Family
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FamilyId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Family name")]
        public string FamilyName { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string Country { get; set; }

         public Family()
        {
             this.FamilyId = Guid.NewGuid();
        }

        public Family(string name,
            string address1 = "", string address2 = "", string city = "", string zipCode = "", string country = "")
         :base()
        {
            this.FamilyName= name;
            this.City = city;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.ZipCode = zipCode;
            this.Country = country;
        }

        public Family(string name, Guid userId)
            : this(name)
        {
            this.FamilyId = userId;
        }


    }
}