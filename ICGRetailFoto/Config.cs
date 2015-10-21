using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Xml;
using System.IO;

namespace ICGRetailFoto
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        public class Instancias
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void Config_Load(object sender, EventArgs e)
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
                dataservidor.Instancia = xn["instancia"].InnerText;
                dataservidor.BaseDados = xn["basedados"].InnerText;
                dataservidor.Utilizador = xn["utilizador"].InnerText;
                dataservidor.Password = xn["password"].InnerText;
            }
            this.instanciaTB.Text = dataservidor.Instancia;
            this.bdTB.Text = dataservidor.BaseDados;
            this.userTB.Text = dataservidor.Utilizador;
            this.passwordTB.Text = dataservidor.Password;
        }

        private void Gravar_Xml(string instanciaTX,string bdTX,string userTX,string passwordTX)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Config.xml");
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Servidor");
            foreach (XmlNode xn in xnList)
            {
                xn["instancia"].InnerText=instanciaTX;
                xn["basedados"].InnerText=bdTX;
                xn["utilizador"].InnerText=userTX;
                xn["password"].InnerText=passwordTX;
            }
            xmlDoc.Save("Config.xml");
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            Gravar_Xml(this.instanciaTB.Text, this.bdTB.Text, this.userTB.Text, this.passwordTB.Text);
            this.Close();
        }
       
    }
}
