using System.Collections;
using System.Collections.Generic;
using System.Linq;
using bibliotecaApi;
using bibliotecaApi.database;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


//Inicio da api
app.MapGet("/livros/get/all", () =>
{
    //Retorna todos os livros registrados
    dynamic db = new Pesquisa();
    dynamic livros = db.GetAllBooks();
    return livros;
})
.WithName("get-livros");

app.MapGet("/livros/get/{title}", (string title) =>
{
    //Retorna um livro especifico
    dynamic db = new Pesquisa();
    dynamic livro = db.GetLivro(title);
    return livro;
})
.WithName("get-livro");

app.MapGet("/avaliacoes/get/{username}", (string username) =>
{
    //Consulta as avaliacoes de um usuario
    //Primeiro retorna o usuario
    //do usuario pega o id
    //usando o id retorna as avaliacoes

    dynamic db = new Pesquisa();
    dynamic user = db.GetUsuario(username);
    dynamic avaliacoes = db.GetAvaliacao(user[0].Id);
    return avaliacoes;
})
.WithName("get-rating");



app.Run();
