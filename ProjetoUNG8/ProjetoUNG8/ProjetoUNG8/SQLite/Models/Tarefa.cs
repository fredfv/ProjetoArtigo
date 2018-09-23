using SQLite;

namespace ProjetoUNG8.SQLite.Models
{
    [Table ("Tarefa")]
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int IdTarefas { get; set; }

        public string Nome { get; set; }
        public int Dificuldade { get; set; }
        public string Acertou { get; set; }
        public int Tentativas { get; set; }
        public string Imagem { get; set; }
        public string Quando { get; set; }
        
        //BlobImg = await WebService.DownloadImageAsync(WebService.EnderecoBase + item.UrlFoto)
        //public byte[] BlobImg { get; set; }
        //public ImageSource ColabImage
        //{
        //    get
        //    {
        //        try
        //        {
        //            if (BlobImg == null)
        //                return ImageSource.FromFile("user.png");

        //            var imageByteArray = BlobImg;

        //            return ImageSource.FromStream(() => new MemoryStream(imageByteArray));
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}
