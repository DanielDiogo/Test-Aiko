namespace Test_Aiko.Models.JwtConfiguration
{
    public class JwtConfiguration
    {
        public required string SecretKey { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
    }
}
