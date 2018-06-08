using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSerialização
{
    public partial class ListaPersonagem : Form
    {
        public ListaPersonagem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem();
            personagem.SetCla(cbCla.SelectedItem.ToString());
            personagem.SetNome(txtNome.Text);
            personagem.SetNivelChakra(Convert.ToInt32(txtNivelChakra.Text));

            Tudo tudo = new Tudo();
            tudo.AdicionarPersonagem(personagem);
 
            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream("Personagens.bin" ,FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, tudo);
            stream.Close();
            // bin\Debug

        }

        private void ListaPersonagem_Activated(object sender, EventArgs e)
        {
            AtualizarListaPersonagem();
        }

        private void AtualizarListaPersonagem()
        {
            Tudo tudo = new Tudo();
            dataGridView1.Rows.Clear();
            foreach (Personagem personagem in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]{
                    personagem.GetNome(),
                    personagem.GetCla(),
                    personagem.GetNivelChakra()
                });
            }
        }
    }
}
