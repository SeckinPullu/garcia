// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GarciaCore.CodeGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using GarciaCore.CodeGenerator;
    using GarciaCore.Infrastructure;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSWebApiProgramTemplate : BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n\tThis file was generated automatically by Garcia Framework.\r\n*/");
            this.Write("\r\n");
            this.Write(@"using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using GarciaCore.Infrastructure;
using GarciaCore.Domain;
using GarciaCore.Persistence;
using System.Threading;
using System.Threading.Tasks;");
            this.Write("\r\nusing FluentValidation.AspNetCore;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing Garc" +
                    "iaCore.Application;\r\nusing GarciaCore.Infrastructure.Api.Filters;\r\nusing Microso" +
                    "ft.Extensions.Options;\r\n");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\nusing ");
            
            #line 16 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer) 
        || GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL)
        || GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("using Microsoft.EntityFrameworkCore;\r\nusing GarciaCore.Persistence.EntityFramewor" +
                    "k;\r\n");
            
            #line 25 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsGenerator(GeneratorType.WebApiAuthentication))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.Identity;\r\nusing GarciaCore.Infrastructure" +
                    ".Identity;\r\n");
            
            #line 33 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.FileUpload;\r\nusing GarciaCore.Infrastructu" +
                    "re.FileUpload.AmazonS3;\r\n");
            
            #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

     if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.FileUpload;\r\nusing GarciaCore.Infrastructu" +
                    "re.FileUpload.Local;\r\n");
            
            #line 49 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.SqlServer;\r\n");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.PostgreSql;\r\n");
            
            #line 63 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.MySql;\r\n");
            
            #line 70 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MongoDB))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.MongoDb;\r\n");
            
            #line 77 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.Redis))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.Redis;\r\n");
            
            #line 84 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MandrillEmail))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.Email;\r\nusing GarciaCore.Infrastructure.Em" +
                    "ail.Mandrill;\r\n");
            
            #line 92 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MailChimpMarketing))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.Marketing;\r\nusing GarciaCore.Infrastructur" +
                    "e.Marketing.MailChimp;\r\n");
            
            #line 100 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.FirebasePushNotification))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.PushNotification;\r\nusing GarciaCore.Infras" +
                    "tructure.PushNotification.Firebase;\r\n");
            
            #line 108 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalImageResize))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.ImageResize;\r\nusing GarciaCore.Infrastruct" +
                    "ure.ImageResize.Local;\r\n");
            
            #line 116 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddControllers(opt =>
    {
        opt.Filters.Add(typeof(ValidationFilter<ApiError>));
    })
    .AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.Configure<ApiBehaviorOptions>(opt =>
{
    opt.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
");
            
            #line 136 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    if (GeneratorRepository.ContainsGenerator(GeneratorType.WebApiAuthentication))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();\r\nbui" +
                    "lder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();\r\nbuilder.S" +
                    "ervices.AddJwtOptions(builder.Configuration);\r\n");
            
            #line 143 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MongoDB))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddMongoDbSettings(builder.Configuration);\r\nbuilder.Services.Add" +
                    "MongoDbRepository();\r\n");
            
            #line 151 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer) 
        || GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL)
        || GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddEfCoreInMemory<");
            
            #line 159 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext>(\"");
            
            #line 159 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\nbuilder.Services.AddEfCoreSqlServer<");
            
            #line 160 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext, EfCoreSettings>(\r\n    new EfCoreSettings\r\n    {\r\n        ConnectionStr" +
                    "ing = builder.Configuration[\"ConnectionStrings:SqlServer\"],\r\n        MigrationsA" +
                    "ssembly = \"");
            
            #line 164 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write(".Api\"\r\n    }\r\n);\r\n");
            
            #line 167 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddAmazonS3FileUploadService(builder.Configuration);\r\n");
            
            #line 174 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddLocalFileUploadService(builder.Configuration);\r\n");
            
            #line 181 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MailChimpMarketing))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddMailChimpMarketingService(builder.Configuration);\r\n");
            
            #line 188 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MandrillEmail))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddMandrillEmailService(builder.Configuration);\r\n");
            
            #line 195 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.FirebasePushNotification))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddFirebasePushNotificationService(builder.Configuration);\r\n");
            
            #line 202 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalImageResize))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddLocalImageResizeService(builder.Configuration);\r\n");
            
            #line 209 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\nvar app = builder.Build();\r\n\r\n// Configure the HTTP request pipeline.\r\nif (app." +
                    "Environment.IsDevelopment())\r\n{\r\n    app.UseSwagger();\r\n    app.UseSwaggerUI();\r" +
                    "\n}\r\n\r\napp.UseHttpsRedirection();\r\napp.UseAuthorization();\r\n");
            
            #line 224 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    if (GeneratorRepository.ContainsGenerator(GeneratorType.WebApiAuthentication))
    {

            
            #line default
            #line hidden
            this.Write("app.UseAuthentication();\r\n");
            
            #line 229 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("app.MapControllers();\r\napp.Run();\r\npublic partial class Program { }\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 237 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new RepositoryGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
