  using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MauiAppMinhasCompras.Properties.Models
{
    public class Produto
    {


        string _descricao;
        double _quantidade;
        double _preco;
        double _total;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Descrição não pode ser nula");
                }
                _descricao = value;
            }
        }

        public double Quantidade { 
            get => _quantidade;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Quantidade não pode ser zero");
                }
                _quantidade = value;
            }
        }

        public double Preco
        {
            get => _preco;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Preço não pode ser zero");
                }
                _preco = value;
            }
        }

        public double Total { get => Quantidade * Preco; }

    }
}
