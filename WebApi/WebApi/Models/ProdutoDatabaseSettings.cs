namespace WebApi.Models
{
    public class ProdutoDatabaseSettings //faz conexao com o DataBase
    {
        public string ConnectionString { get; set; } 
        public string DatabaseName { get; set; } 
        public string? ProdutoCollectionName { get; set; } //Nome da tabela
    }
}
