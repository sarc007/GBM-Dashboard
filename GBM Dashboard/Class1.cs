using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GBM_Dashboard
{
    public class DbConnection
    {

        public string getConnection()
        {
            string strDbConnection = "";
            try
            {
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;
                string userName = "";
                string userPass = "";
                string server = "";
                //MessageBox.Show("workingDirectory:" + workingDirectory);
                //MessageBox.Show("projectDirectory:" + projectDirectory);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(workingDirectory + "\\dbconnection\\connection.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/DbConnection/MYSQL");
                //string proID = "", proName = "", price = "";
                foreach (XmlNode node in nodeList)
                {
                    userName = node.SelectSingleNode("user_name").InnerText;
                    userPass = node.SelectSingleNode("password").InnerText;
                    server = node.SelectSingleNode("server").InnerText;
                    //MessageBox.Show(userName + " " + userPass + " " + server);
                }
                strDbConnection = "server=" + server + ";database=dashboard;uid=" + userName + ";pwd=" + userPass + ";";
                //MessageBox.Show(strDbConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("no connnection file");
            }
            return strDbConnection;
        }
    }
}
