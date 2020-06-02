namespace Aula08Abstracao
{
    // Essa classe é filha da classe cartão e neta da classe pagamento
    public class CartaoDebito : Cartao 
    {
        public float saldo { get; set; }
        public string Transferir(float valor){
            return "Tranferência Concluída";
        }
        public string PagarTitulo(float valor){
            return "Titulo pago";
        }
    }
}