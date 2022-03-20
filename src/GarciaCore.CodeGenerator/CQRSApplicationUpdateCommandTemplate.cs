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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSApplicationUpdateCommandTemplate : BaseTemplate
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
            this.Write("\r\nusing GarciaCore.Application;\r\nusing MediatR;\r\n");
            
            #line 13 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Update");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command : Create");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command\r\n    {\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 22 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationUpdateCommandTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSApplicationUpdateCommandGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
