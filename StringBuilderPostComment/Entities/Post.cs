using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderPostComment.Entities
{
    //Classe - Entidade Post
    class Post
    {
        //Atributos
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        //Contrutores
        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Método para Adicionar Comentário
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        //Método para Remover Comentário
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Sobrepondo ToString para imprimir POST e COMENTÁRIO - Usando StringBuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Pertence ao nameSpace System.Text
            sb.AppendLine("POST ******************************");
            sb.AppendLine("Horário : " + Moment);
            sb.AppendLine("Título  : " + Title);
            sb.AppendLine("Conteúdo : " + Content);
            sb.AppendLine("Likes : " + Likes);
            sb.AppendLine("COMENTÁRIOS*************************");

            int i = 1;
            foreach (Comment obj in Comments)
            {
                sb.AppendLine($"{i}º Comentário - {obj.Text}");
                i++;
            }
            return sb.ToString();
        }
    }
}