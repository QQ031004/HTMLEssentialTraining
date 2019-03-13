//* piblic class StartUp
{

    public StartUp(IHostingEnvironment env)
    {
        
    var builder = new ConfigurationBuilder()
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: tr)
    .AddJsonFile($"appsettings.{env.EnvironmentNa")

    if (env.IsDevelopment()) *//