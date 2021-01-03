using System;
namespace Senaizinho
{
    public class Sala
    {

        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal;
        public int NumeroSala { get; set; }
        public string[] Aluno { get; set; }

        public Sala(int numerosala, int capacidadetotal)
        {
            this.NumeroSala = numerosala;
            this.CapacidadeAtual = capacidadetotal;
            this.CapacidadeAtual = this.CapacidadeTotal;
            this.Aluno = new string[CapacidadeTotal];


        }

        public string AlocarAluno(string nome1)
        {
            int index = 0;
            if (this.CapacidadeAtual > 0)
            {
                foreach (string aluno in this.Aluno)
                {
                    if (aluno == "")
                    {
                        this.Aluno[index] = nome1;
                        break;
                    }
                    index++;
                }
                this.CapacidadeAtual--;
                return "ok";
            }
            else
            {
                return "Lotado, tente novamente mais tarde";
            }
        }

        public string RemoverAluno(string nome1)
        {
            int index = 0;

            if (this.CapacidadeAtual == this.CapacidadeTotal)
            {
                return "Sala vazia";
            }

            foreach (string aluno in this.Aluno)
            {
                if (nome1 == aluno)
                {
                    this.Aluno[index] = "";
                    return "Aluno removido";
                }
                index++;

            }
            return "Nao encontrado";
        }

        public string MostarAluno()
        {
            string ListaAlunos = "";
            foreach (string aluno in this.Aluno)
            {
                if (aluno != "")
                {
                    ListaAlunos = ListaAlunos + aluno+ " ";
                }
            }
            ListaAlunos.TrimEnd();
            return ListaAlunos;
        }
    }
}