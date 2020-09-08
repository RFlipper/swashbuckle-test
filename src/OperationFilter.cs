using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace temp
{
    public class OperationalFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var extension = new KeyValuePair<string, IOpenApiExtension>("x-my-test", new OpenApiString("true"));
            operation?.RequestBody?.Extensions.Add(extension);
        }
    }
}