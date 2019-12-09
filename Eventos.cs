using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
class Eventos{
  private int Id_evento;
  private string Data_Evento;
  private string Hora_Evento;
  private int qtd_Pessoa;
  private string TipoEvento;
  private Endereco Endereco_Evento;
  
  public Eventos(){
    Id_evento = 00;
    Data_Evento = "10/12/2019";
    Hora_Evento = "12:00";
    qtd_Pessoa = 30;
  }
  public Eventos(int qtd_pessoa, string data_evento, string hora_evento, string tipo){
    this.qtd_Pessoa = qtd_pessoa;
    this.Data_Evento = data_evento;
    this.Hora_Evento = hora_evento;
    this.TipoEvento  = tipo;
  }
  public string getTipoEvento(){
    return this.TipoEvento;
  }
  public int getqtd_Pessoa(){
    return this.qtd_Pessoa;
  }
 
  /*public void TipoEvent(){
    if((TipoEvento == "Buffet") && (qtd_Pessoa >= 30)){
      Console.WriteLine("Seu evento ira com um Assador e um Garçom");
    }
    else if(qtd_Pessoa<30)
    {
      Console.WriteLine("Seu evento ira com um Assador ");
    }

  }*/
  public void EnderecoDoEvento(){
    //endereço do evento a ser realizdo 
    Console.WriteLine("Infome Endereço do Evento:");
    Console.WriteLine("Informe nome da Rua: ") ;
    string rua = Console.ReadLine();
    Console.WriteLine("Informe Numero :");
    string numero = Console.ReadLine();
    Console.WriteLine("Informe Bairro :");
    string bair  = Console.ReadLine();
    Console.WriteLine("Informe Municipio :");
    string muni = Console.ReadLine();
    this.Endereco_Evento = new Endereco(rua, numero, bair, muni);

  }
   public Endereco getEndereco_Evento(){
     return Endereco_Evento;
   }
  public static void Selec_Funcionairo(){
    FileStream meuArq = new FileStream("FuncionariosBase.txt", FileMode.Open, FileAccess.Read);
    StreamReader reader = new StreamReader(meuArq, Encoding.UTF8);
    List<string> ID = new List<string>();
    List<string> ColaboradoE = new List<string>();
    List<string> Telefone = new List<string>();
    List<string> Cargo = new List<string>();
    while(!reader.EndOfStream){
        string linha = reader.ReadLine();        
        string[] valores = linha.Split('|');
        ID.Add(valores[0]);
        ColaboradoE.Add(valores[1]);
        Telefone.Add(valores[2]);
        Cargo.Add(valores[3]);


      }      
      for (int i=0; i<ColaboradoE.Count;i++){
        
        
          Console.WriteLine("ID - "+ID[i]+" Nome do Funcioanrio: "+ColaboradoE[i]  +" - Telefone: "+ Telefone[i]+" - Funçao :"+Cargo[i]);
        
      }
      reader.Close();
      meuArq.Close();

  }
  
}