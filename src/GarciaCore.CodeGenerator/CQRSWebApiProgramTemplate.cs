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
                    "iaCore.Application;\r\nusing GarciaCore.Infrastructure.Api.Filters;\r\n");
            
            #line 14 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\nusing ");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 16 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer) 
        || GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL)
        || GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("using Microsoft.EntityFrameworkCore;\r\nusing GarciaCore.Persistence.EntityFramewor" +
                    "k;\r\n");
            
            #line 24 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsGenerator(GeneratorType.WebApiAuthentication))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.Identity;\r\nusing GarciaCore.Infrastructure" +
                    ".Identity;\r\n");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload) || GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.FileUpload;\r\nusing GarciaCore.Application." +
                    "Services;\r\n");
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.SqlServer;\r\n");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.PostgreSql;\r\n");
            
            #line 54 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.EntityFramework.MySql;\r\n");
            
            #line 61 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MongoDB))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.MongoDb;\r\n");
            
            #line 68 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.Redis))
    {

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Persistence.Redis;\r\n");
            
            #line 75 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

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
            
            #line 95 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    if (GeneratorRepository.ContainsGenerator(GeneratorType.WebApiAuthentication))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();\r\nbui" +
                    "lder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();\r\nbuilder.S" +
                    "ervices.AddJwtOptions(builder.Configuration);\r\n");
            
            #line 102 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MongoDB))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddMongoDbSettings(builder.Configuration);\r\nbuilder.Services.Add" +
                    "MongoDbRepository();\r\n");
            
            #line 110 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer) 
        || GeneratorRepository.ContainsIntegration(IntegrationType.PostgreSQL)
        || GeneratorRepository.ContainsIntegration(IntegrationType.MySQL))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddEfCoreInMemory<");
            
            #line 118 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext>(\"");
            
            #line 118 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 119 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddScoped<IFileUploadService, AmazonS3FileUplaodService>();\r\nbui" +
                    "lder.Services.Configure<AmazonS3Settings>(builder.Configuration.GetSection(nameo" +
                    "f(AmazonS3Settings)));\r\n");
            
            #line 127 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("builder.Services.AddScoped<IFileUploadService, LocalFileUplaodService>();\r\nbuilde" +
                    "r.Services.Configure<FileUploadSettings>(builder.Configuration.GetSection(nameof" +
                    "(FileUploadSettings)));\r\n");
            
            #line 135 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
public partial class Program { }


");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 158 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

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
