using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busnises

{
    public class Produtos
    {
        public int id { get; set; }
        public String nome { get; set; }
        public int quantidade { get; set; }

        public List<Produtos> Retornavalores()
        {
            
            var lista = new List<Produtos>();
            DataTable dados = new Database.ProdutosDao().Buscar();
            foreach(DataRow row in dados.Rows)
            {
                Produtos p = new Produtos();
                p.id = Convert.ToInt32(row["id"]);
                p.nome = row["nome"].ToString();
                p.quantidade = Convert.ToInt32(row["quantidade"]);
                lista.Add(p);
            }
        return lista;
        }

        public void Salvar()
        {
            ProdutosDao p = new ProdutosDao();
            p.Inserir(this.id, this.nome, this.quantidade);
        }

        public Produtos Dados(int id)
        {
            ProdutosDao produto = new ProdutosDao();
            var busca = produto.BuscarId(id);
            Produtos p = new Produtos();
            foreach(DataRow row in busca.Rows)
            {
                p.id = Convert.ToInt32(row["id"]);
                p.nome = row["nome"].ToString();
                p.quantidade = Convert.ToInt32(row["quantidade"]);
            }
            return p;
        }

        public void Atualizar()
        {
            ProdutosDao p = new ProdutosDao();
            p.Update(this.id, this.nome, this.quantidade);
        }
        public void Excluir(int id)
        {
            ProdutosDao p = new ProdutosDao();
            p.Delete(id);
        }
    }
}
