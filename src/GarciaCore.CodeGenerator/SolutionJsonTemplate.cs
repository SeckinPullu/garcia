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
    using GarciaCore.Application;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class SolutionJsonTemplate : BaseTemplate
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
            this.Write(@"
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using GarciaCore.Application.Contracts.Persistence;
using GarciaCore.Persistence.EntityFramework;
using GarciaCore.Application;
using Microsoft.EntityFrameworkCore;
using GarciaCore.Application.Contracts.Identity;
using GarciaCore.Infrastructure.Identity;
");
            
            #line 20 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 22 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EntityFrameworkRepository<>));
            services.AddScoped<IJwtService, JwtService>();
");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    if (GeneratorRepository.ContainsGenerator(GeneratorType.EntityFrameworkDbContext))
    {

            
            #line default
            #line hidden
            this.Write("            services.AddScoped<DbContext, ");
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext>();\r\n");
            
            #line 37 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    }

    if (GeneratorRepository.ContainsGenerator(GeneratorType.Repository))
    {
        foreach (var item in GeneratorRepository.Items)
        {

            
            #line default
            #line hidden
            this.Write("            services.AddScoped<I");
            
            #line 45 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRepositoryType(item.Name)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 45 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRepositoryType(item.Name)));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 49 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    }
    if (GeneratorRepository.ContainsGenerator(GeneratorType.Service))
    {
        foreach (var item in GeneratorRepository.Items.Where(x => x.AddApplication))
        {

            
            #line default
            #line hidden
            this.Write("            services.AddScoped<I");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("Service, ");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("Service>();\r\n");
            
            #line 57 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 60 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    }
    if (GeneratorRepository.ContainsGenerator(GeneratorType.Query))
    {
        foreach (var item in GeneratorRepository.Items.Where(x => x.AddApplication))
        {

            
            #line default
            #line hidden
            this.Write("            services.AddScoped<I");
            
            #line 67 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("Query, ");
            
            #line 67 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("Query>();\r\n");
            
            #line 68 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 71 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("            return services;\r\n        }\r\n    }\r\n");
            
            #line 77 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.Authentication))
    {

            
            #line default
            #line hidden
            
            #line 81 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 86 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\SolutionJsonTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new SolutionJsonGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}