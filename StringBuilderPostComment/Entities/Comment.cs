namespace StringBuilderPostComment.Entities
{
    //Classe - Entidade Comentário
    class Comment
    {
        //Atributos
        public string Text { get; set; }

        //Construtores
        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}