// ------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod bir ara� taraf�ndan olu�turuldu.
//     �al��ma Zaman� S�r�m�: 17.0.0.0
//  
//     Bu dosyada yap�lacak de�i�iklikler hatal� davran��a neden olabilir ve
//     kod yeniden �retildi�inde kaybolabilir.
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
    
    #line 1 "C:\Users\Se�kin\source\repos\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiUpdateCommandTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSWebApiUpdateCommandTemplate : BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n\tThis file was generated automatically by Garcia Framework. \r\n\tDo not edit ma" +
                    "nually. \r\n\tAdd a new partial class with the same name if you want to add extra f" +
                    "unctionality.\r\n*/");
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
            this.Write("  \r\nusing MediatR;\r\n\r\nnamespace ");
            
            #line 13 "C:\Users\Se�kin\source\repos\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Update");
            
            #line 15 "C:\Users\Se�kin\source\repos\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command : Create");
            
            #line 15 "C:\Users\Se�kin\source\repos\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiUpdateCommandTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command\r\n    {\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 20 "C:\Users\Se�kin\source\repos\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiUpdateCommandTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSWebApiUpdateCommandGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}