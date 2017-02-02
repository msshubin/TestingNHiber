using System;

namespace TestingNHiber.Domain
{
    public class Document
    {
        private int Id { get; set; }                // Уникальный идентификатор
        private string Name { get; set; }            // Название документа
        private DateTime CreationDate { get; set; }  // Дата создания документа
        private User Author { get; set; }            // Автор документа, объект пользователь
        private string FileName { get; set; }        // Имя файла

        public virtual int ID
        {
            get { return Id; }
            protected set { Id = value; }
        }

        public virtual string NAME
        {
            get { return Name; }
            protected set { Name = value; }
        }

        public virtual DateTime CREATIONDATE
        {
            get { return CreationDate; }
            protected set { CreationDate = value; }
        }

        public virtual User AUTHOR
        {
            get { return Author; }
            protected set { Author = value; }
        }

        public virtual string FILENAME
        {
            get { return FileName; }
            protected set { FileName = value; }
        }

        public Document(string setName, DateTime setCreationDate, User setAuthor, string setFileName)
        {
            Name = setName;
            CreationDate = setCreationDate;
            Author = setAuthor;
            FileName = setFileName;
        }
            
    }
}
