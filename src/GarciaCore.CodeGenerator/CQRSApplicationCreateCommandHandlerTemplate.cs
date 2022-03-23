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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSApplicationCreateCommandHandlerTemplate : BaseTemplate
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
            this.Write("\r\nusing GarciaCore.Application;\r\nusing GarciaCore.Application.Contracts.Persisten" +
                    "ce;\r\nusing MediatR;\r\nusing AutoMapper;\r\n");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 16 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    var repositoryString = $"I{GetRepositoryType(Item.Name)} {Item.Name.ToCamelCase()}Repository";
    var properties = Item.Properties.Where(x => x.Type == ItemPropertyType.Class);
    var repositories = new List<string>();

    foreach (var property in properties)
    {
        if (!repositories.Contains(property.InnerType.Name))
        {
            repositories.Add(property.InnerType.Name);
        }
    }

    foreach (var repository in repositories)
    {
        repositoryString += $", I{GetRepositoryType(repository)} {repository.ToCamelCase()}Repository";
    }

    repositoryString = repositoryString.Trim().TrimEnd(',');

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 37 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Create");
            
            #line 39 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler : IRequestHandler<Create");
            
            #line 39 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command, BaseResponse<");
            
            #line 39 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(">>\r\n    {\r\n        private readonly IMapper _mapper;\r\n        private readonly I");
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRepositoryType(Item.Name)));
            
            #line default
            #line hidden
            this.Write(" _");
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 43 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    foreach (var repository in repositories)
    {

            
            #line default
            #line hidden
            this.Write("        private readonly I");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRepositoryType(repository)));
            
            #line default
            #line hidden
            this.Write(" _");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 48 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n        public Create");
            
            #line 52 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler(IMapper mapper, ");
            
            #line 52 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repositoryString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            _mapper = mapper;\r\n            _");
            
            #line 55 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository = ");
            
            #line 55 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    foreach (var repository in repositories)
    {

            
            #line default
            #line hidden
            this.Write("            _");
            
            #line 60 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository = ");
            
            #line 60 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 61 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public async Task<BaseResponse<");
            
            #line 66 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(">> Handle(Create");
            
            #line 66 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command request, CancellationToken cancellationToken)\r\n        {\r\n            var" +
                    " item = _mapper.Map<");
            
            #line 68 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(">(request);\r\n            var result = await _");
            
            #line 69 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository.AddAsync(item);\r\n            \r\n            if (result > 0)\r\n          " +
                    "  {\r\n                return new BaseResponse<");
            
            #line 73 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(">(item.Id, System.Net.HttpStatusCode.Created);\r\n            }\r\n\r\n            retu" +
                    "rn new BaseResponse<");
            
            #line 76 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(">(item.Id, new ApiError(\"Something went wrong!\", \"");
            
            #line 76 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(" cannot be created.\"));\r\n        }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 81 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandHandlerTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSApplicationCreateCommandHandlerGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}