using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Ola Cliente Informe quantidade de Pessoa, Data do Evento e Horario ");
    int qtd_pessoa = int.Parse(Console.ReadLine());
    string data_evento = Console.ReadLine();
    string hora_evento = Console.ReadLine();
    Eventos meuEvento = new Eventos(qtd_pessoa, data_evento, hora_evento);
  }
}