using System.ComponentModel.DataAnnotations;

namespace EconomizeAqui.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}