using System;

class MainClass {
  public static void Main (string[] args) {
    /*Console.WriteLine ("Ola Cliente Informe quantidade de Pessoa, Data do Evento e Horario e Tipo de Evento");
    int qtd_pessoa = int.Parse(Console.ReadLine());
    string data_evento = Console.ReadLine();
    string hora_evento = Console.ReadLine();
    string tipo = Console.ReadLine();*/
    //aqui cliente inforarada quantida de pessoa data e tipo de evento
    Eventos meuEvento = new Eventos(29, "12/12/2019",  "12:00" , "Buffet");
    //meuEvento.TipoEvent();
    //---------
    //criando Funcionario
    Funcionario meuFuncionairo = new Funcionario("01", "Assador", "Lucas", "2995178743", "Carlistor@sdasd");

    meuFuncionairo.GravarFuncionario(meuFuncionairo);
    Eventos.Selec_Funcionairo();
    meuEvento.EnderecoDoEvento();
    Console.WriteLine (meuFuncionairo.getMeuFuncionario());
    Console.WriteLine (meuEvento.getEndereco_Evento());
    
  }
}