using JWTWebApi.Model;

namespace JWTWebApi.Repositories
{
    public interface IUserDetails
    {
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

        public bool VarifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);

        public string CreateToken(User user);
    }
}
