using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//ENDPOINTS - FUNCIONALIDADES

//REQUEST/REQUISIÇÃO - URL
//Metodos HTTP
//GET - Pegar alguma informação
//POST - Enviar alguma informação 
app.MapGet("/", () => "Hello World!");

app.MapGet("/testarurl", () => "Primeira API");

app.MapGet("/parametro/{param1}",
 //parametro vem da rota
 ([FromRoute]string param1) => 
{
    string result = param1 + " " + DateTime.Now;
    return result;
});

app.Run();
