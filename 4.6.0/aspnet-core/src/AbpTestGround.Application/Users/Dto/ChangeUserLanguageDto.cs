using System.ComponentModel.DataAnnotations;

namespace AbpTestGround.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}