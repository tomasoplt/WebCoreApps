#region Using

using System.ComponentModel.DataAnnotations;

#endregion

namespace WebCoreApp.EF.Models.System.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
