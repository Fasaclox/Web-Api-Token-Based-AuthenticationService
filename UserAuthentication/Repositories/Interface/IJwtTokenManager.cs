namespace UserAuthentication.Repositories.Interface
{
    public interface IJwtTokenManager
    {
       string Authenticate(string userName, string passWord); 
    }
}
