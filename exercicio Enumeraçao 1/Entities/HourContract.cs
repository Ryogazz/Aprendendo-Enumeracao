using System;


namespace exercicio_Enumeraçao_1.Entities
{   //classe que armazena dados do contrato e qual valor a ser recebido
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }
        //COnstrutor que salva os dados 
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        //Metodo que retorna o valor do contrato 
        public double TotalValue()
        {
            return Hours * ValuePerHour;

        }
    }
}
