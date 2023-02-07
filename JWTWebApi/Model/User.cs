using System.ComponentModel.DataAnnotations;

namespace JWTWebApi.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = null!;

        public byte[] PasswordSalt { get; set; } = null!;
    }

    //public class Jwt
    //{
    //    public string key { get; set; }
    //    public string Issuer { get; set; }
    //    public string Audience { get; set; }
    //    public string Subject { get; set; }
    //}
}
