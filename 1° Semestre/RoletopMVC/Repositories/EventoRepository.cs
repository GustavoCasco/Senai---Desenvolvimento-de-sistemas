using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    
        public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Eventos.csv";
        
     
        public EventoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

          public bool Inserir(Evento eventos)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            eventos.Id = (ulong) ++quantidadeEventos;
            var linha = new string[]{PrepararPedidoCSV(eventos)};
            File.AppendAllLines(PATH,linha);
            return true;
        }

           public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var evento = ObterTodos();
            List<Evento> pedidosCliente = new List<Evento>();
            foreach (var item in evento)
            {
                if (item.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(item);
                }
            }
            return pedidosCliente;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> pedidos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                evento.Cliente = new Cliente();
                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                evento.NomeEvento = ExtrairValorDoCampo("nomeevento", linha);
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                evento.DiadoEvento = DateTime.Parse(ExtrairValorDoCampo("dia_evento", linha));
                evento.Serviços.Nome = ExtrairValorDoCampo("serviços_nome", linha);
                evento.TipoEvento = ExtrairValorDoCampo("tipo_evento", linha);
                evento.Serviços.Preco = double.Parse(ExtrairValorDoCampo("serviços_preco", linha));
                evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                evento.Fotodeperfil = ExtrairValorDoCampo("foto_perfil", linha);
                evento.Privacidade = uint.Parse(ExtrairValorDoCampo("privacidade_evento" , linha));
                pedidos.Add(evento);
            }
            return pedidos;
        }


        
        
         public bool Atualizar( Evento evento)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidoCSV = PrepararPedidoCSV(evento);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id" , pedidosTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }

            return resultado;
        }

        public double ObterPrecoDe(string nomeEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeEvento))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Evento> ObterEventoPor(uint statusEvento)
        {
            List<Evento> eventos = new List<Evento>();
            var todosEvento = ObterTodos();
            foreach (var item in todosEvento)
            {
                if (item.Status.Equals(statusEvento))
                {
                    eventos.Add(item);
                }
            }
            return eventos;
        }

    
          public Evento ObterPor (ulong id)
        {
             var pedidosTotais = ObterTodos();
             foreach (var pedido in pedidosTotais)
             {
                 if (id.Equals(pedido.Id))
                 {
                     return pedido;
                 }
             }
             return null;
        }

        public List<Evento> ObterPrivacidade(uint Privacidade)
        {
            List<Evento> eventos = new List<Evento>();
            var todosEvento = ObterTodos();
            foreach (var item in todosEvento)
            {
                if (item.Privacidade.Equals(Privacidade))
                {
                    eventos.Add(item);
                }
            }
            return eventos;
        }

         private string PrepararPedidoCSV(Evento evento)
        {
            Cliente c = evento.Cliente;
            Serviços h = evento.Serviços;
           
            return $"id={evento.Id};status_pedido={evento.Status};nomeevento={evento.NomeEvento};cliente_nome={c.Nome};cliente_telefone={c.Telefone};cliente_email={c.Email};data_pedido={evento.DataDoPedido};dia_evento={evento.DiadoEvento};serviços_nome={h.Nome};tipo_evento={evento.TipoEvento};foto_perfil={evento.Fotodeperfil};privacidade_evento={evento.Privacidade};serviços_preco={h.Preco};preco_total={evento.PrecoTotal}";
        }
    }
}