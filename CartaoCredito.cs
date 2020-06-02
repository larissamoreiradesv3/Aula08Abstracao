namespace Aula08Abstracao
{
    //essa classe é filha da classe cartão é nta da classe pagamento
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public void AumentoLimite (float acrescimo){
            token = "blsablablablablamandabobona";
            limite = limite + acrescimo;
        }
        
    }
}