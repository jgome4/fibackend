using Microsoft.Extensions.Configuration;

    public class TokenService : IToken
    {
        public TokenService(IConfiguration configuration)
        {

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        public bool IsValidUser(string user, string password)
        {
            return Configuration["tokenManagement:User"].ToString().Equals(user) && Configuration["tokenManagement:Password"].ToString().Equals(password);
        }


    }

