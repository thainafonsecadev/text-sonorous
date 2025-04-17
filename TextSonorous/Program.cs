using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.TextToSpeech.v1;
using IBM.Watson.TextToSpeech.v1.Model;
using Microsoft.AspNetCore.Http.Connections;
using TextSonorous.Services;

var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();


    {
        builder.Services.AddSingleton<TextSonorousService>(provider =>

        {
            var configuration = provider.GetRequiredService<IConfiguration>();
            var apiKey = configuration["IBM:ApiKey"];
            var serviceUrl = configuration["IBM:url"];
            return new TextSonorousService(apiKey, serviceUrl);
        });


    };

    var app = builder.Build();

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();