using System;

namespace Aula08Abstracao
{
    public class Pagamento
    {
        //get para permitir que vejam 
        public DateTime data { get; set; }
        public float valor { get; set; }

        //para o pagamento ser execultado
        public string Pagar (float valorPago){
            return "Valor Pago: R$" +valorPago;
        }
        //para o pagamento ser cancelado
        public string Cancelamento (){
            return "Pagamento Cancelado";
        }

        }
}