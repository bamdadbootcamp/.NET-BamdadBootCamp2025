namespace AuthApp.Api;

public class AppSettings
{
    public JwtSettings IdentityConfigs { get; set; }
}

public class JwtSettings
{
    public string TokenSecret { get; set; }
    public string EncryptionSecret { get; set; }
    public string TokenExpiration { get; set; }
    public string RefreshTokenExpiration { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Authority { get; set; }
}