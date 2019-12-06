using System;
class Eventos{
  private int Id_evento;
  private string Data_Evento;
  private string Hora_Evento;
  private int qtd_Pessoa;
  private Endereco Endereco_Evento;
  
  public Eventos(){
    Id_evento = 00;
    Data_Evento = "10/12/2019";
    Hora_Evento = "12:00";
    qtd_Pessoa = 30;
  }
  public Eventos(int qtd_pessoa, string data_evento, string hora_evento){
    this.qtd_Pessoa = qtd_pessoa;
    this.Data_Evento = data_evento;
    this.Hora_Evento = hora_evento;
    Console.WriteLine("Infome Endereço do Evento Rua; Numero; Bairro; Municipio");
    string rua = Console.ReadLine();
    string numero = Console.ReadLine();
    string bair  = Console.ReadLine();
    string muni = Console.ReadLine();
    this.Endereco_Evento = new Endereco(rua, numero, bair, muni);

  }
  
}