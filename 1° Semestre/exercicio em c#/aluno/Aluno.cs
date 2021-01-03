using System;

namespace Aluno
{
    public class Aluno
    {
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        
        public int[] Notas;

        //construtor
        public Aluno(string Nome, string Cpf)
        {
            this.Nome = Nome;
        
            this.Cpf = Cpf;

            Notas = new int [4];
        }
          public Aluno(string Nome, string Curso, string Cpf)
        {
            this.Nome = Nome;
            this.Curso = Curso;
            this.Cpf = Cpf;
             Notas = new int [4];
        }
        
        //Metedos de Acesso

        public int[] getNotas(){return Notas;}

        public void setNotas(int bi, int nota) {
            int  i = bi - 1;
            if ((i < 0) ||(i >3 )){
                //condição de erro
               throw new ArgumentOutOfRangeException($"{nameof(Notas)} must be"); 
            
            }else if (nota < 0 || nota > 10)
            {
               throw new ArgumentOutOfRangeException ($"{nameof(Notas)} must be");
            }else {
                this.Notas[bi] = nota;
            }
        }
    }
}