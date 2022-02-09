using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Lista
{
    class Arquivo
    {
        public string Caminho { get; set; }
        public List<Detalhe> Detalhes = new List<Detalhe>();

        public Arquivo(string caminho)
        {
            Caminho = caminho;
        }
        public void AddDetalhe(Detalhe det)
        {
            Detalhes.Add(det);
        }
        public void RemoveDetalhe(Detalhe det)
        {
            Detalhes.Remove(det);
        }
        public double TotalPasta()
        {
            double total = Detalhes.Sum(x => x.Tamanho);
            return total;

        }
        public int TotalArquivos()
        {
            return Detalhes.Count();
        }
        public void RefatorarListView(ListView lista)
        {
            lista.View = View.Details;
            lista.GridLines = true;

            lista.Columns.Clear();
            lista.Items.Clear();

            ColumnHeader[] colunas =
            {
                new ColumnHeader { Text = "Arquivo", Width = 500},
            };
            lista.Columns.AddRange(colunas);
        }
        public void ListaAdd(ListView lista)
        {
            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(Caminho, "*.*",
                SearchOption.AllDirectories);

                RefatorarListView(lista);

                foreach (var row in files)
                {
                    ListViewItem item = new ListViewItem(row);
                    lista.Items.Add(item);

                    AddDetalhe(new Detalhe { Referencia = row, Tamanho = new FileInfo(row).Length });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
