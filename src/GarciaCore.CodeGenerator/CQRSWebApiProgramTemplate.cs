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
                    "iaCore.Application;\r\nusing GarciaCore.Persistence.MongoDb;\r\nusing GarciaCore.Per" +
                    "sistence.EntityFramework;\r\nusing GarciaCore.Infrastructure.Api.Filters;\r\n");
            
            #line 16 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write(@"

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddControllers(opt =>
    {
        opt.Filters.Add(typeof(ValidationFilter<ApiError>));
    })
    .AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<CreateProductCommand>())
    .AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.Configure<ApiBehaviorOptions>(opt =>
{
    opt.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
builder.Services.AddMongoDbSettings(builder.Configuration);
builder.Services.AddMongoDbRepository();

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
        
        #line 57 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiProgramTemplate.tt"

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
