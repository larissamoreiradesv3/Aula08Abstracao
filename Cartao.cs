namespace Aula08Abstracao
{
    // A classe cartão está vinculada com a pagamento
    public class Cartao : Pagamento
    {
        public string token = "464sd87a98d7a89d71";
        public string bandeira { get; set; }
        public float numeroCartao { get; set; }
        public string cvv { get; set; }
        public float titular { get; set; }

        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
        
    }
}