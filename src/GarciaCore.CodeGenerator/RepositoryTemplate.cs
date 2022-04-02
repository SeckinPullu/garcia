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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class RepositoryTemplate : BaseTemplate
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
            this.Write("\r\nusing Microsoft.EntityFrameworkCore;\r\nusing GarciaCore.Application.Contracts.Pe" +
                    "rsistence;\r\nusing GarciaCore.Persistence.EntityFramework;\r\n");
            
            #line 13 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 15 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public interface I");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository : IAsyncRepository<");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n");
            
            #line 19 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        if (Item.Properties.Count(x => x.InnerType != null) > 0)
	    {

            
            #line default
            #line hidden
            this.Write("        Task<List<");
            
            #line 23 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(">> GetAllWithIncludes();\r\n        Task<");
            
            #line 24 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("> GetByIdWithIncludes(long id);\r\n");
            
            #line 25 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    public partial class ");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository : ");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseClass));
            
            #line default
            #line hidden
            this.Write("<");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(">, I");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository\r\n    {\r\n        public ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository(DbContext dbContext) : base(dbContext) { }\r\n\r\n");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        if (Item.Properties.Count(x => x.InnerType != null) > 0)
	    {

            
            #line default
            #line hidden
            this.Write("        public async Task<List<");
            
            #line 38 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(">> GetAllWithIncludes()\r\n        {\r\n            return await (_dbContext as ");
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext).");
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("s\r\n");
            
            #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        foreach (var property in Item.Properties.Where(x => x.InnerType != null))
	    {
            string innerTypeName = this.generator.GetInnerTypeName(property);

            
            #line default
            #line hidden
            this.Write("                .Include(i => i.");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("                .AsNoTracking()\r\n                .ToListAsync();\r\n        }\r\n\r\n  " +
                    "      public async Task<");
            
            #line 54 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("> GetByIdWithIncludes(");
            
            #line 54 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            return await (_dbContext as ");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("DbContext).");
            
            #line 56 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("s\r\n");
            
            #line 57 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        foreach (var property in Item.Properties.Where(x => x.InnerType != null))
	    {
            string innerTypeName = this.generator.GetInnerTypeName(property);

            
            #line default
            #line hidden
            this.Write("                .Include(i => i.");
            
            #line 62 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 63 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("                .Where(i => i.Id == id)\r\n                .AsNoTracking()\r\n       " +
                    "         .FirstOrDefaultAsync();\r\n        }\r\n");
            
            #line 70 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 76 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\RepositoryTemplate.tt"

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
