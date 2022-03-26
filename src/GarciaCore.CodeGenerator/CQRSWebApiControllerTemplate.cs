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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSWebApiControllerTemplate : BaseTemplate
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
            this.Write("\r\nusing Microsoft.Extensions.Options;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing Gar" +
                    "ciaCore.Infrastructure.Api;\r\nusing GarciaCore.Application;\r\nusing MediatR;\r\nusin" +
                    "g Newtonsoft.Json;\r\n");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    var services = $"I{Item.Name}Service {Item.Name.ToCamelCase()}Service";

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload) || GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {
        services += ", IFileUploadService fileUploadService";

            
            #line default
            #line hidden
            this.Write("using GarciaCore.Application.Contracts.FileUpload;\r\n");
            
            #line 26 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Controller : ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseClass));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        private I");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Query _");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Query;\r\n        private I");
            
            #line 35 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Service _");
            
            #line 35 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service;\r\n");
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload) || GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 44 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Controller(IOptions<GarciaCoreInfrastructureApiSettings> settings, I");
            
            #line 44 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Query ");
            
            #line 44 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Query, ");
            
            #line 44 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(services));
            
            #line default
            #line hidden
            this.Write(", IMediator mediator) : base(settings, null, mediator)\r\n        {\r\n            _");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Query = ");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Query;\r\n            _");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service = ");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service;\r\n");
            
            #line 48 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload) || GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("            _fileUploadService = fileUploadService;\r\n");
            
            #line 53 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        [HttpPost(\"api/");
            
            #line 58 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\", Name = \"Create");
            
            #line 58 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public async Task<ActionResult<BaseResponse<Create");
            
            #line 59 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>>> Create");
            
            #line 59 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("([FromBody] Create");
            
            #line 59 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command command)\r\n        {\r\n            var response = await _mediator.Send(comm" +
                    "and);\r\n            return StatusCode(response.StatusCode, response.Result);\r\n   " +
                    "     }\r\n\r\n");
            
            #line 65 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
 
    if (Item.MultipartUpload)
    {

            
            #line default
            #line hidden
            this.Write("        [HttpPost(\"api/");
            
            #line 69 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("/Multipart\", Name = \"Create");
            
            #line 69 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("WithMultipartUpload\")]\r\n        public async Task<ActionResult<BaseResponse<Creat" +
                    "e");
            
            #line 70 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>>> Create");
            
            #line 70 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("WithMultipartUpload([FromForm] string data)\r\n        {\r\n            data = CleanJ" +
                    "son(data);\r\n            var command = JsonConvert.DeserializeObject<Create");
            
            #line 73 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>(data);\r\n            var files = await MultipartUploadAsync();\r\n         " +
                    "   var response = await _mediator.Send(command);\r\n            return Ok(command)" +
                    ";\r\n        }\r\n\r\n        [HttpPut(\"api/");
            
            #line 79 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("/Multipart\", Name = \"Update");
            
            #line 79 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("WithMultipartUpload\")]\r\n        public async Task<ActionResult<BaseResponse<Updat" +
                    "e");
            
            #line 80 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>>> Update");
            
            #line 80 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("WithMultipartUpload([FromForm] string data)\r\n        {\r\n            data = CleanJ" +
                    "son(data);\r\n            var command = JsonConvert.DeserializeObject<Create");
            
            #line 83 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>(data);\r\n            var files = await MultipartUploadAsync();\r\n         " +
                    "   var response = await _mediator.Send(command);\r\n            return Ok(command)" +
                    ";\r\n        }\r\n");
            
            #line 88 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("        \r\n        [HttpPut(\"api/");
            
            #line 92 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\", Name = \"Update");
            
            #line 92 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public async Task<ActionResult<BaseResponse<Update");
            
            #line 93 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>>> Update");
            
            #line 93 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("([FromBody] Update");
            
            #line 93 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command command)\r\n        {\r\n            var response = await _mediator.Send(comm" +
                    "and);\r\n            return StatusCode(response.StatusCode, response.Result);\r\n   " +
                    "     }\r\n\r\n        [HttpDelete(\"api/");
            
            #line 99 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("/{id}\", Name = \"Delete");
            
            #line 99 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public async Task<ActionResult<BaseResponse<Delete");
            
            #line 100 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command>>> Delete");
            
            #line 100 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("(Delete");
            
            #line 100 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command command)\r\n        {\r\n            var response = await _mediator.Send(comm" +
                    "and);\r\n            return StatusCode(response.StatusCode, response.Result);\r\n   " +
                    "     }\r\n\r\n        [HttpGet(\"api/");
            
            #line 106 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\", Name = \"GetAll");
            
            #line 106 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("s\")]\r\n        public async Task<ActionResult<List<");
            
            #line 107 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            
            #line 107 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.ApplicationModelDtoPostfix));
            
            #line default
            #line hidden
            this.Write(">>> GetAll");
            
            #line 107 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("s()\r\n        {\r\n            var items = await _");
            
            #line 109 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service.GetAllAsync();\r\n            return Ok(items);\r\n        }\r\n\r\n        [Http" +
                    "Get(\"api/");
            
            #line 113 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("/{id}\", Name = \"Get");
            
            #line 113 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public async Task<ActionResult<");
            
            #line 114 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            
            #line 114 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.ApplicationModelDtoPostfix));
            
            #line default
            #line hidden
            this.Write(">> Get");
            
            #line 114 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 114 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            var item = await _");
            
            #line 116 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service.GetAsync(id);\r\n\r\n            if (item != null)\r\n            {\r\n          " +
                    "      return Ok(item);\r\n            }\r\n\r\n            return NotFound();\r\n       " +
                    " }\r\n");
            
            #line 125 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

        foreach (var property in Item.Properties.Where(x => x.MappingType == ItemPropertyMappingType.List && x.Type == ItemPropertyType.Class))
	    {
            string innerTypeName = this.generator.GetInnerTypeName(property, postfix: GeneratorRepository.ApplicationModelDtoPostfix);

            
            #line default
            #line hidden
            this.Write("        \r\n        [HttpGet(\"api/");
            
            #line 131 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("/{id}/");
            
            #line 131 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public async Task<ActionResult<");
            
            #line 132 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(innerTypeName));
            
            #line default
            #line hidden
            this.Write(">> Get");
            
            #line 132 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 132 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IdTypeName));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            var item = await _");
            
            #line 134 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service.GetAsync(id);\r\n\r\n            if (item != null)\r\n            {\r\n          " +
                    "      return Ok(item.");
            
            #line 138 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n\r\n            return NotFound();\r\n        }\r\n");
            
            #line 143 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 149 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiControllerTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSWebApiControllerGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
