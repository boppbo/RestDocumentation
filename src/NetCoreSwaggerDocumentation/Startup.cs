using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Microsoft.Extensions.PlatformAbstractions;

namespace NetCoreSwaggerDocumentation
{
    /// <summary>   A startup. </summary>
    public class Startup
    {
        /// <summary>
        ///     Initializes a new instance of the NetCoreSwaggerDocumentation.Startup class.
        /// </summary>
        ///
        /// <param name="configuration">    The configuration. </param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>   Gets the configuration. </summary>
        ///
        /// <value> The configuration. </value>
        public IConfiguration Configuration { get; }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        ///
        /// <param name="services"> The services. </param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new Info
                    {
                        Title = "My fancy API",
                        Version = "v1",
                        Contact = new Contact { Name = "Boris Bopp", Email = "bobo1011@hs-karlsruhe.de" }
                    });
                c.IncludeXmlComments(
                    Path.Combine(
                        PlatformServices.Default.Application.ApplicationBasePath,
                        "NetCoreSwaggerDocumentation.xml"));
            });
        }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to configure the HTTP request
        ///     pipeline.
        /// </summary>
        ///
        /// <param name="app">  The application. </param>
        /// <param name="env">  The environment. </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.ShowJsonEditor();
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My fancy APIv1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
