using System.ComponentModel.DataAnnotations;

namespace MyABPTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}