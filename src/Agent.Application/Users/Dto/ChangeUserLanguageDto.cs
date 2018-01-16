using System.ComponentModel.DataAnnotations;

namespace Agent.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}