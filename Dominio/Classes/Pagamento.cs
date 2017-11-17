
namespace Dominio.Classes{
    public class Pagamento{
        public int ID { get; set; }
        public int TipoPagto { get; set; }
        public int QtdParcelas { get; set; }
        public double Valor {get; set;}

    public Pagamento(){
    }
    public Pagamento(int id, int tipopagto, int qtdparcelas, double valor){
        this.ID = id;
        this.TipoPagto = tipopagto;
        this.Valor = valor;
        this.QtdParcelas = qtdparcelas;
    }
    }
}