using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskRascal.Models
{

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DisplayName("Email")]
        public string UserName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public bool Active { get; set; }
        public bool ForcePasswordSwitch { get; set; }
        public bool HasAgreedToTermsOfService { get; set; }

        // FKs
        [ForeignKey("Family")]
        public Guid FamilyId { get; set; }
        public virtual Family Family { get; set; }

        public UserProfile()
        {
            this.UserId = Guid.NewGuid();
            this.Active = true;
            this.ForcePasswordSwitch = true;
            this.HasAgreedToTermsOfService = false;
        }

        public UserProfile(string username, string firstName, string lastName,
            string address1 = "", string address2 = "", string city = "", string zipCode = "", string country = "", string phone = "", string job = "", string company = "")
            : base()
        {
            this.UserName = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.ZipCode = zipCode;
            this.Country = country;
            this.PhoneNumber = phone == null ? null : phone.Replace("-", "").Replace(".", "").Trim();
           
        }

        public UserProfile(string username, string firstName, string lastName, Guid userId)
            : this(username, firstName, lastName)
        {
            this.UserId = userId;
        }

        public void Activate()
        {
            this.Active = true;
        }
        public void Deactivate()
        {
            this.Active = false;
        }

        public void ReadTermsOfService()
        {
            this.HasAgreedToTermsOfService = true;
        }

        public void HasChangedPassword()
        {
            this.ForcePasswordSwitch = false;
        }
    }

}