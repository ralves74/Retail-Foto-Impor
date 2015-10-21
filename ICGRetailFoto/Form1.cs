using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Xml;
using System.Data.SqlClient;

namespace ICGRetailFoto
{
    
    public partial class Form1 : Form
    {
        public string local;
        public byte[] Content { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private servidor Server()
        {
            servidor dataservidor = new servidor();
            XmlTextReader reader = new XmlTextReader("Config.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Config.xml"); 
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Servidor");
            //Usando foreach para passar valores do ficheiro xml para o Objecto dataservidor
            foreach (XmlNode xn in xnList)
            {
                dataservidor.Instancia = xn["instancia"].InnerText;
                dataservidor.BaseDados = xn["basedados"].InnerText;
                dataservidor.Utilizador = xn["utilizador"].InnerText;
                dataservidor.Password = xn["password"].InnerText;
            }
            return dataservidor;
        }

        /// <summary>
        /// String de conexao ao servidor SQL
        /// </summary>
        /// <returns></returns>
       private string conn()
        {
           
            servidor serverconn = Server();
            string connstring;
            connstring = "Data Source=" + serverconn.Instancia + ";Initial Catalog="+serverconn.BaseDados+";Persist Security Info=True;User ID=" + serverconn.Utilizador + ";Password=" + serverconn.Password;
            return connstring;
        }

       

        public SqlConnection conexao()
       {
           string connect = conn();
           SqlConnection cn = new SqlConnection(connect);
           return cn;
       }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metodo para seleccionar todos os items de uma checkedListBox
        /// </summary>
        private void checkedAll_checkedList()
        {
            if (checkedListBoxFicheiros.Items.Count>0)
            {
                for (int i = 0; i < checkedListBoxFicheiros.Items.Count; i++)
                {
                    checkedListBoxFicheiros.SetItemChecked(i, true);
                }
            }
        }

        private void uncheckedAll_checkedList()
        {
            if (checkedListBoxFicheiros.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBoxFicheiros.Items.Count; i++)
                {
                    checkedListBoxFicheiros.SetItemChecked(i, false);
                }
            } 
        }

        /// <summary>
        /// Metodo Para Abrir Caixa de Selecção de Directorio 
        /// e mostrar todos os ficheiros constantes desse directorio
        /// </summary>
        private void seleccao()
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                //Mostra na textBox o directorio seleccionado
                textBoxDirectorio.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo diretorio = new DirectoryInfo(@textBoxDirectorio.Text);
                FileInfo[] Arquivos = diretorio.GetFiles("*.*");
                checkedListBoxFicheiros.Items.Clear();
                foreach (FileInfo fileinfo in Arquivos)
                {
                    checkedListBoxFicheiros.Items.Add(fileinfo.Name);
                }
                checkedAll_checkedList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seleccao();
        }

        private void buttonSeleccao_Click(object sender, EventArgs e)
        {
            seleccao();
        }

        private void buttonAllCheck_Click(object sender, EventArgs e)
        {
            checkedAll_checkedList();
        }

        private void buttonUnckeckedAll_Click(object sender, EventArgs e)
        {
            uncheckedAll_checkedList();
        }

        private byte[] ConverterImagem(string nomeArquivo, string caminhoArquivo)
        {
            try
            {
                byte[] imagemBytes = null;
                string caminhoCompletoImagem = caminhoArquivo + "\\" + nomeArquivo;
                FileStream fs = new FileStream(caminhoCompletoImagem, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs, Encoding.Unicode);
                //imagemBytes = br.ReadBytes(caminhoCompletoImagem.Length);
                imagemBytes = br.ReadBytes(160000000);
                return imagemBytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        private void gravabd(string nomeficheiro,string caminho)
        {
            servidor dadosServer = Server();
            string refnfich;
            refnfich = Path.GetFileNameWithoutExtension(nomeficheiro);
            string refnfichn = refnfich.Replace("_", "/");
            try 
            {
           
                SqlConnection cn = conexao();
                SqlCommand comm = new SqlCommand();
                comm.Connection = cn;
                comm.CommandText = "Update " + dadosServer.BaseDados + "..Articulos set " + dadosServer.BaseDados + "..Articulos.foto=@FOTO where " + dadosServer.BaseDados + "..Articulos.refproveedor='" + refnfichn + "'";
                comm.Parameters.AddWithValue("@FOTO", ConverterImagem(nomeficheiro,caminho));
                cn.Open();
                int iresultado = comm.ExecuteNonQuery(); 
                cn.Close();
            }
            catch (Exception e)
            {
                throw(e);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            foreach (var item in checkedListBoxFicheiros.CheckedItems)
            {
                gravabd(item.ToString(), textBoxDirectorio.Text);
            }

            MessageBox.Show("Importação Terminada");
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void aPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intro introform = new Intro();
            introform.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config configForm = new Config();
            configForm.Show();
        }

        private void redimensionarBT_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFicheiros.CheckedItems)
            {
                MessageBox.Show(item.ToString());
                //gravabd(item.ToString(), textBoxDirectorio.Text);
            }

            MessageBox.Show("Redimensionamento Efetuado");

        }

       
    }

}
