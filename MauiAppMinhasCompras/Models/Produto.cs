using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string descricao;

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Descricao
        {
            get => descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }
                descricao = value;
            }
        }
    }
    public double Quantidade {  get; set; }
    public double Preco {  get; set; }
    public double Total { get => Quantidade * Preco; }
}
