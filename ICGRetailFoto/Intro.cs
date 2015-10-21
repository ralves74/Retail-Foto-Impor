using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.Xml;


namespace ICGRetailFoto
{
    public partial class Intro : Form
    {
       
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            DiskGetInformation();
            Carrega_licenca();
            string lic = this.licenseTB.Text;
            bool estadoLicenca = Verifica_Licenca(lic);
            if (!estadoLicenca)
            {
                MessageBox.Show("Erro de licença, deve introduzir a licença correcta!");
                this.aplicenciadaLB.Visible = false;
                this.entrarBT.Enabled = false;
            }
            else
            {
                this.licenciarBT.Enabled = false;
                this.licenseTB.ReadOnly = true;
                this.aplicenciadaLB.Visible = true;
                this.entrarBT.Enabled = true;
            }
        }

        [DllImport("kernel32.dll")]
        private static extern long GetVolumeInformation(
            string PathName,
            StringBuilder VolumeNameBuffer,
            UInt32 VolumeNameSize,
            ref UInt32 VolumeSerialNumber,
            ref UInt32 MaximumComponentLength,
            ref UInt32 FileSystemFlags,
            StringBuilder FileSystemNameBuffer,
            UInt32 FileSystemNameSize);

        private void DiskGetInformation()
        {
            string drive_letter = "c:\\";
            //drive_letter = drive_letter.Substring(0, 1) + ":\\";

            uint serial_number = 0;
            uint max_component_length = 0;
            StringBuilder sb_volume_name = new StringBuilder(256);
            UInt32 file_system_flags = new UInt32();
            StringBuilder sb_file_system_name = new StringBuilder(256);

            if (GetVolumeInformation(drive_letter, sb_volume_name,
                (UInt32)sb_volume_name.Capacity, ref serial_number,
                ref max_component_length, ref file_system_flags,
                sb_file_system_name,
                (UInt32)sb_file_system_name.Capacity) == 0)
            {
                MessageBox.Show(
                    "Não é possivel obter dados.",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {

                serialTB.Text = serial_number.ToString();
            }
        }

        bool Verifica_Licenca(string licencaTX)
        {
            string chave = Licenciamento.Cifrar(this.serialTB.Text);
            //licencaTX = this.licenseTB.Text;
            if (licencaTX=="")
            {
                return false;
            }
            if (chave!=licencaTX) 
            { return false; }
            else
            { return true; }
        }

        private void licenciarBT_Click(object sender, EventArgs e)
        {
            string licenca = Licenciamento.Cifrar(serialTB.Text);
            bool estadoLicenca = Verifica_Licenca(this.licenseTB.Text);
            if (!estadoLicenca) 
            { 
                MessageBox.Show("Licença Errada, deve introduzir a licença correcta!");
                this.aplicenciadaLB.Visible = false;
                this.entrarBT.Enabled = false;
            }
            else
            {
                Gravar_Xml(this.licenseTB.Text);
                this.licenciarBT.Enabled = false;
                this.licenseTB.ReadOnly = true;
                this.aplicenciadaLB.Visible = true;
                this.entrarBT.Enabled = true;
            }

        }

        private void Carrega_licenca()
        {
            servidor dataservidor = new servidor();
            XmlTextReader reader = new XmlTextReader("Config.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Config.xml");
            //Pegando elemento pelo nome da TAG
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Servidor");
            //Usando foreach para imprimir na tela
            foreach (XmlNode xn in xnList)
            {
                dataservidor.Licenca = xn["licenca"].InnerText;
            }
            string lic = dataservidor.Licenca.ToString();
            this.licenseTB.Text = lic;
        }

        private void Gravar_Xml(string licencaTX)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Config.xml");
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Servidor");
            foreach (XmlNode xn in xnList)
            {
                xn["licenca"].InnerText = licencaTX;
            }
            xmlDoc.Save("Config.xml");
        }

        private void entrarBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 carregaForm = new Form1();
            carregaForm.Show();
        }

    }
}
