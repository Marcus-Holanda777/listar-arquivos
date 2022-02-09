using System;
using System.Windows.Forms;
using System.Globalization;

namespace Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pasta = new FolderBrowserDialog();

            if (pasta.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = pasta.SelectedPath;
                lbTotal.Text = "0";
                lbContar.Text = "0";

                Arquivo arq = new Arquivo(txtPasta.Text);
                arq.ListaAdd(listPasta);

                double total = arq.TotalPasta() / Math.Pow(1024, 2);
                lbTotal.Text = total.ToString("F2", CultureInfo.InvariantCulture) + " MB";
                lbContar.Text = arq.TotalArquivos().ToString();

            }
        }
    }
}
