using System;

public class Pessoa{
   private string nome;
   private string Telefone;
   private string email;

   public Pessoa(){
    nome = "Pessoa vazia!";
   }

   //Construtor da classe: método chamado no momento da criação de objetos.
   public Pessoa(string n, string tel, string em ){
     this.nome = n;
     this.Telefone = tel;
     this.email = em;
     
   }
   public string getNome(){
     return this.nome;
   }
   public void setNome(string nome){
     this.nome = nome;
   }
   public string getTelefone(){
     return this.Telefone;
   }
   public void setTelefone(string tel){
     this.Telefone = tel;
   }
   public string getEmail(){
     return this.email;
   }
   public void setEmail(string em){
     this.Telefone = em;
   }
   public override string ToString(){
     return String.Format("{0} ({1}) ",this.nome, this.Telefone);
   }

}

