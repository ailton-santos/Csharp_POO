namespace GeradorSenhaApi.Models
{
    public class PasswordRequest
    {
        public int Length { get; set; }
        public bool IncludeUppercase { get; set; }
        public bool IncludeLowercase { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeSpecial { get; set; }
    }
}
