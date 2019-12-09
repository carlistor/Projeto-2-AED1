using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
public class Funcionario : Pessoa{
  private string id_funcionario;
  private string Cargo;
  private Pessoa MeuFuncionario;


  public Funcionario(){
    this.id_funcionario ="0";
    this.Cargo = " ";
  }
  public Funcionario(string ID, string Funcao, string n, string tel, string em ){
    this.id_funcionario =ID;
    this.Cargo = Funcao;
    MeuFuncionario = new Pessoa(n, tel, em);
    }
    public string getCargo(){
      return Cargo;
    }
    public void setCargo(string Carg){
      this.Cargo = Carg;
    }
    public string getId_funcionario(){
      return this.id_funcionario;
    }
    public Pessoa getMeuFuncionario(){
      return MeuFuncionario;
    }
    public void GravarFuncionario(Funcionario MeuColaborador){
      //gravar aqruivo de texto Como Nome e telefone do Funcionario    
    FileStream arq = new FileStream("FuncionariosBase.txt" ,FileMode.Append, FileAccess.Write);
    StreamWriter sw = new StreamWriter(arq, Encoding.UTF8);
    List<string> dados = new List<string>(){MeuColaborador.getId_funcionario(),"|",MeuColaborador.getMeuFuncionario().getNome() ,"|",MeuColaborador.getMeuFuncionario().getTelefone(),"|",MeuColaborador.getCargo()};

     foreach(var item in dados){
      sw.Write(item);      
    }
    sw.WriteLine(" ");
    sw.Close();
    arq.Close();
    }
}
