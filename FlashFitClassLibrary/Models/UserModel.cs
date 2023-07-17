using FlashFitClassLibrary.Enumz;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashFitUserManagementService
{
    /// <summary>
    /// Password has generated with the help 
    /// https://juldhais.net/secure-way-to-store-passwords-in-database-using-sha256-asp-net-core-898128d1c4ef
    /// </summary>
    public class UserModel
    {
        
        [Key]
        public string Email { get; set; }
        [Required]
        public string PasswordSalt { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string Name { get; set; }

        [EnumDataType(typeof(GenderTypeEnum))]
        [Column(TypeName = "nvarchar(128)")]
        public GenderTypeEnum Gender { get; set; }
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal WeightInKiloGrams { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal HeightInCentiMeter { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal BodyMassIndex { get; set; }

        [EnumDataType(typeof(HealthStatusEnum))]
        [Column(TypeName = "nvarchar(129)")]
        public HealthStatusEnum HealthStatus { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

       
    }
}
