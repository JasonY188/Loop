npx create-react-app frontend 
inside the frontend folder
npm i axios react-redux redux redux-thunk react-router-dom
npm i @material-ui/core
npm i @material-ui/icons


----------------------------------------------------------------------------------------------------------
in psql
createdb loop
create a new sql script - loop.sql
then run: psql loop < loop.sql

----------------------------------------------------------------------------------------------------------
mkdir backend
dotnet new webapi
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL -v 2.0.0
dotnet watch run 

- in appsettings.json add the following 
"ConnectionStrings":{
    "YourProjectNameContext": "Server=localhost;Database=your_database_name;Username=postgres;Password=redwood2016"
}, 


- startup.cs

need to comment this line out app.UseHttpsRedirection();

change to this:

 public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connectionString = Configuration.GetConnectionString("ApiContext");
            services.AddEntityFrameworkNpgsql().AddDbContext<ApiContext>(options => options.UseNpgsql(connectionString));

             services.AddCors();
        }


 public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors(builder =>
                   builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod());

           // app.UseHttpsRedirection();
            app.UseMvc();
        }

if necessary also add this at the top startup.cs and add this to most files:
using Microsoft.EntityFrameworkCore;

------------------------------------------------------------------------------------------------------------------
create a Model folder in root folder, inside Model folder
create apicontext.cs file
create jobapply.cs
create joblist.cs
create loopuser.cs

to use foreign key in model jobapply, use the follow line:
using System.ComponentModel.DataAnnotations.Schema;


need to create controllers
joblistcontroller.cs
loopuser.cs
jobapplycontroller.cs