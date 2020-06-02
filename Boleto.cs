using System;

namespace Aula08Abstracao
{
    // O pagamento do lado da classe boleto é para vincular essa classe a classe principal
    // Boleto é uma classe filha, ela para aqui
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codigoBarras { get; set; }

        // Para mostrar que o pagamento do boleto
        public string Registrado (){
            return "Boleto registrado com sucesso";
        }
    }
}