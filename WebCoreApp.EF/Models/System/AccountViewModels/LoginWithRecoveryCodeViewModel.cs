#region Using

using System.ComponentModel.DataAnnotations;

#endregion

namespace WebCoreApp.EF.Models.System.AccountViewModels
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
