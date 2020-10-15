using System;
using StringBuilderPostComment.Entities;

namespace StringBuilderPostComment
{
    //Classe Principal
    class Program
    {
        //Método Principal
        static void Main(string[] args)
        {
            //Declarando e instãnciado variáveis
            //POST 02
            Post p01 = new Post(
                DateTime.Parse("15/10/2020 11:44:00"),
                "Titulo do Post 01",
                "Conteúdo do Post 01 .....",
                10
                );

            //COMENTÁRIO
            Comment c01 = new Comment("Comentário 01");
            Comment c02 = new Comment("Comentário 02");

            //Adicionando o Comentário ao Post
            p01.AddComment(c01);
            p01.AddComment(c02);

            /////////////////////////////////////////
            //POST 01
            Post p02 = new Post(
                DateTime.Parse("15/10/2020 11:55:00"),
                "Titulo do Post 02",
                "Conteúdo do Post 02 .....",
                25
                );

            //COMENTÁRIO
            Comment c03 = new Comment("Comentário 01");
            Comment c04 = new Comment("Comentário 02");

            //Adicionando o Comentário ao Post
            p02.AddComment(c03);
            p02.AddComment(c04);

            //Imprimindo POST 01 e 02
            Console.WriteLine(p01);
            Console.WriteLine(p02);
        }
    }
}