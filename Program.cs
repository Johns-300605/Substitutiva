using TarefasPessoais.Models;
using TarefasPessoais.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("PermitirTudo");

app.UseStaticFiles();

ListaTarefas.Dados();

app.MapGetRoutes();
app.MapPostRoutes();
app.MapPatchRoutes();

app.Run();
