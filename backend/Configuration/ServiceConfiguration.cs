namespace backend.Configuration;

public static class ServiceConfiguration 
{
    public static void RegisterService(this IServiceCollection services) 
    {
        services.AddScoped<ITokenService, TokenService>();
    }
}