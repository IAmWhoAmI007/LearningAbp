using System.ComponentModel.DataAnnotations;

namespace LearningAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}