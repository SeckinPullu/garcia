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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSApplicationCreateCommandTemplate : BaseTemplate
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
            this.Write("  \r\nusing GarciaCore.Application;\r\nusing MediatR;\r\n");
            
            #line 13 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Create");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command : IRequest<BaseResponse<");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(">>\r\n    {\r\n");
            
            #line 19 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
  
    if (!string.IsNullOrEmpty(IdTypeName))
    {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 23 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(" Id { get; set; }\r\n");
            
            #line 24 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    }

            
            #line default
            #line hidden
            
            #line 27 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    foreach (var property in Item.Properties.Where(x => x.Type != ItemPropertyType.Class || x.MappingType == ItemPropertyMappingType.List))
	{
        string innerTypeName = generator.GetInnerTypeName(property, postfix: GeneratorRepository.ApplicationModelDtoPostfix);

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(innerTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 33 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    }

            
            #line default
            #line hidden
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    foreach (var property in Item.Properties.Where(x => x.Type == ItemPropertyType.Class && x.MappingType != ItemPropertyMappingType.List))
	{
        string innerTypeName = generator.GetInnerTypeName(property, postfix: GeneratorRepository.ApplicationModelDtoPostfix);
        var idPostfix = property.Type == ItemPropertyType.Class && property.MappingType != ItemPropertyMappingType.List ? "Id" : string.Empty;

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToPascalCase()));
            
            #line default
            #line hidden
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(idPostfix));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 43 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 49 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationCreateCommandTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSApplicationCreateCommandGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}