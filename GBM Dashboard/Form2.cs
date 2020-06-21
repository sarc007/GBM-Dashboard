using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace GBM_Dashboard
{
    public partial class Form2 : UserControl
    {
        Socket socket = null;
        private Thread timerThread;

        public Form2()
        {
            InitializeComponent();
        }
        List<int> applist = new List<int>();
        List<int> sitelist = new List<int>();
        List<int> camlist = new List<int>();
        List<int> vidlist = new List<int>();
        List<int> violist = new List<int>();
        int int_gbm_iva_id = GBM_IVA.id;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_type_tbl' table. You can move, or remove it, as needed.
            this.configuration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuration_type_tbl);
            if (gridView1.RowCount > 0)
            {
                // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
                this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
                // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
                this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
                // TODO: This line of code loads data into the 'dashboardDataSet.videos' table. You can move, or remove it, as needed.
                this.videosTableAdapter.Fill(this.dashboardDataSet.videos);
                // TODO: This line of code loads data into the 'dashboardDataSet.violation_tbl' table. You can move, or remove it, as needed.
                this.violation_tblTableAdapter.Fill(this.dashboardDataSet.violation_tbl);
            }

            gridView1.SelectAll();
            gridView2.SelectAll();
            gridView3.SelectAll();
            gridView4.SelectAll();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            
            string str_config_type_id="";
            getlistofAppID();
            for (int i=0;i<applist.Count;i++)
            {
                if (i == 0)
                {
                    str_config_type_id = applist[i].ToString();
                }
                else
                {
                    str_config_type_id = str_config_type_id + ", " + applist[i].ToString() ;
                }

            }
            
            ColumnView view = gridView2;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_type_id"]);
            }
            view.ActiveFilter.Add(view.Columns["config_type_id"],
              new ColumnFilterInfo("[config_type_id] in ("+ str_config_type_id + ")", ""));
        }
        private void getlistofAppID()
        {
            ArrayList rows = new ArrayList();
            applist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
                    DataRow row = rows[i] as DataRow;
                    applist.Add((int)row[0]);

            }
            
        }
        private void getlistofSiteID()
        {
            ArrayList rows = new ArrayList();
            sitelist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView2.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                sitelist.Add((int)row[0]);

            }

        }

        private void getlistofCameraID()
        {
            ArrayList rows = new ArrayList();
            camlist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView3.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView3.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                camlist.Add((int)row[0]);
                

            }

        }
        private void getlistofVideoID()
        {
            ArrayList rows = new ArrayList();
            vidlist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView4.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView4.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                vidlist.Add((int)row[0]);

            }

        }
        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_config_id = "";
            getlistofSiteID();
            for (int i = 0; i < sitelist.Count; i++)
            {
                if (i == 0)
                {
                    str_config_id = sitelist[i].ToString();
                    
                }
                else
                {
                    str_config_id = str_config_id + ", " + sitelist[i].ToString();
                }

            }

            ColumnView view = gridView3;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_id_fld"]);
            }
            view.ActiveFilter.Add(view.Columns["config_id_fld"],
              new ColumnFilterInfo("[config_id_fld] in (" + str_config_id + ")", ""));

        }
        private void gridView3_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_camera_config_id = "";
            getlistofCameraID();
            for (int i = 0; i < camlist.Count; i++)
            {
                if (i == 0)
                {
                    str_camera_config_id = camlist[i].ToString();
                }
                else
                {
                    str_camera_config_id = str_camera_config_id + ", " + camlist[i].ToString();
                }
            }
           

            ColumnView view = gridView4;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["camera_config_id"]);
            }
            view.ActiveFilter.Add(view.Columns["camera_config_id"],
              new ColumnFilterInfo("[camera_config_id] in (" + str_camera_config_id + ")", ""));

            
        }

        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            string str_fk_video_id = "";
            getlistofVideoID();
            for (int i = 0; i < vidlist.Count; i++)
            {
                if (i == 0)
                {
                    str_fk_video_id = vidlist[i].ToString();
                }
                else
                {
                    str_fk_video_id = str_fk_video_id + ", " + vidlist[i].ToString();
                }

            }

            ColumnView view = gridView5;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["fk_video_id"]);
            }
            view.ActiveFilter.Add(view.Columns["fk_video_id"],
              new ColumnFilterInfo("[fk_video_id] in (" + str_fk_video_id + ")", ""));
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            ColumnView view = gridView1;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["fk_gbm_iva_id"]);
            }
            view.ActiveFilter.Add(view.Columns["config_type_id"],
              new ColumnFilterInfo("[fk_gbm_iva_id] = " + int_gbm_iva_id.ToString(), ""));
             gridView1.SelectAll();

        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
           gridView2.SelectAll();
        }

        private void gridControl3_Load(object sender, EventArgs e)
        {
            gridView3.SelectAll();
        }

        private void gridControl4_Load(object sender, EventArgs e)
        {
            gridView4.SelectAll();
        }

        private void gridControl5_Load(object sender, EventArgs e)
        {
            gridView5.SelectAll();
        }

        private void gridControl5_MouseDown(object sender, MouseEventArgs e)
        {
                    
        }

        private void gridControl5_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
                //ColumnView view =  gridView5;
                //MessageBox.Show(row[2].ToString());
                if (rdBtn_vid.Checked)
                {
                    pictureEdit1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = row[1].ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.settings.setMode("loop", true);
                    //pictureEdit1.Image = Image.FromFile(row[1].ToString());
                }
                if (rdBtn_img.Checked)
                {
                    axWindowsMediaPlayer1.Visible = false;
                    pictureEdit1.Visible = true;
                    //MessageBox.Show(row[2].ToString());
                    pictureEdit1.Image = Image.FromFile(row[2].ToString());

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Data");
            }
            

        }

        private void rdBtn_img_CheckedChanged(object sender, EventArgs e)
        {
            DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            if (!(row == null))
            {

                //ColumnView view =  gridView5;
                //MessageBox.Show(row[2].ToString());
                if (rdBtn_vid.Checked)
                {
                    pictureEdit1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = row[1].ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.settings.setMode("loop", true);
                    //pictureEdit1.Image = Image.FromFile(row[1].ToString());
                }
                if (rdBtn_img.Checked)
                {
                    axWindowsMediaPlayer1.Visible = false;
                    pictureEdit1.Visible = true;

                    pictureEdit1.Image = Image.FromFile(row[2].ToString());

                }
            }
        }

        private void rdBtn_vid_CheckedChanged(object sender, EventArgs e)
        {
            DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            if (!(row == null))
            {

                if (rdBtn_vid.Checked)
                {
                    pictureEdit1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = row[1].ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.settings.setMode("loop", true);
                    //pictureEdit1.Image = Image.FromFile(row[1].ToString());
                }
                if (rdBtn_img.Checked)
                {
                    axWindowsMediaPlayer1.Visible = false;
                    pictureEdit1.Visible = true;

                    pictureEdit1.Image = Image.FromFile(row[2].ToString());

                }
            }
        }

        private void pictureEdit1_Layout(object sender, LayoutEventArgs e)
        {
            DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            if (!(row == null))
            {
                //ColumnView view =  gridView5;
                //MessageBox.Show(row[2].ToString());
                if (rdBtn_vid.Checked)
                {
                    pictureEdit1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = row[1].ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.settings.setMode("loop", true);
                    //pictureEdit1.Image = Image.FromFile(row[1].ToString());
                }
                if (rdBtn_img.Checked)
                {
                    axWindowsMediaPlayer1.Visible = false;
                    pictureEdit1.Visible = true;

                    pictureEdit1.Image = Image.FromFile(row[2].ToString());

                }
            }
        }

        private void gridControl5_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
                if (!(row == null))
                {

                    //ColumnView view =  gridView5;
                    //MessageBox.Show(row[2].ToString());
                    if (rdBtn_vid.Checked)
                    {
                        pictureEdit1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = row[1].ToString();
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        axWindowsMediaPlayer1.settings.setMode("loop", true);
                        //pictureEdit1.Image = Image.FromFile(row[1].ToString());
                    }
                    if (rdBtn_img.Checked)
                    {
                        axWindowsMediaPlayer1.Visible = false;
                        pictureEdit1.Visible = true;
                        pictureEdit1.Image = Image.FromFile(row[2].ToString());

                    }
                }
            }
        }

        private void rdbtn_online_CheckedChanged(object sender, EventArgs e)
        {
            gridControl4.Visible = false;
            gridControl5.Visible = false;
            pictureEdit1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            groupBox2.Visible = false;
            online_panel.Visible = true;
            gridView3.OptionsSelection.MultiSelect = false;

        }

        private void rdbtn_offline_CheckedChanged(object sender, EventArgs e)
        {
            gridControl4.Visible = true;
            gridControl5.Visible = true;
            pictureEdit1.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            groupBox2.Visible = true;
            online_panel.Visible = false;
        }

        private void gridView3_RowClick(object sender, RowClickEventArgs e)
        {
            if (rdbtn_online.Checked)
            {
                ArrayList rows = new ArrayList();
                string ip = "", port = "", user = "", pwd = "";
                Int32[] selectedRowHandles = gridView3.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    rows.Add(gridView3.GetDataRow(selectedRowHandle));
                    DataRow row = rows[i] as DataRow;
                    ip = row[2].ToString();
                    user = row[3].ToString();
                    pwd = row[4].ToString();
                    port = row[5].ToString();
                    //MessageBox.Show(ip + ":" + port + ":"+user+":"+pwd);
                }

                try
                {
                    startThread(ip, user, pwd, port);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void startThread(string ip, string user, string pwd, string port)
        {
            stopThread();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timerThread = new Thread(() => StartClient(ip, user, pwd, port));
            timerThread.IsBackground = true;
            timerThread.Start();
        }

        private void stopThread()
        {
            btnStart.Enabled = true;
            //pictureBox1.Image.Dispose();
            btnStop.Enabled = false;
            if (timerThread != null)
            {
                timerThread.Interrupt();
                timerThread = null;
            }
        }

        public void StartClient(string ip, string user, string pwd, string port)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[9048];

            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[1];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5005);

                // Create a TCP/IP  socket.  
                socket = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    socket.Connect(remoteEP);

                    string cam_url = "0";
                    cam_url = "rtsp://"+user+":"+pwd+"@"+ip+":"+port+"/H264?ch=1&subtype=0";
                    //cam_url = "rtspsrc location=rtsp://admin:India12345@195.229.90.117:4444 latency=2000 ! rtph264depay ! h264parse ! decodebin ! videoconvert ! appsink";
                    Console.WriteLine("Socket connected to {0}",
                        socket.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(cam_url);

                    // Send the data through the socket.  
                    int bytesSent = socket.Send(msg);
                    string dataStr = "";
                    // Receive the response from the remote device.  
                    while (true)
                    {
                        int bytesRec = socket.Receive(bytes);
                        //Console.WriteLine("Echoed test = {0}",bytesRec);
                        dataStr += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        //Console.WriteLine(dataStr);
                        /*if (bytes[bytesRec - 4] == 'E' & bytes[bytesRec - 3] == 'N' & bytes[bytesRec - 2] == 'D' & bytes[bytesRec - 1] == '!')
                        {
                            Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                            Console.WriteLine("end found " + bytesRec);
                            break;
                        }*/
                        if (dataStr.Contains("END!"))
                        {
                            int index2 = dataStr.IndexOf("END!");
                            //Console.WriteLine("End found at::::" + index2);
                            int totLen = dataStr.Length;
                            //Console.WriteLine("length::::" + dataStr.Length);
                            //string mainData = dataStr.Substring(0, index2);
                            //if (index2 == mainData.Length)
                            //{
                            //    dataStr = dataStr.Substring(0, index2);
                            //}
                            //else
                            //{
                            string mainData = dataStr.Substring(0, index2);
                            //Console.WriteLine("main data length::::" + mainData.Length);
                            Image image = byteArrayToImage(mainData);
                            //pictureBox1.Image = image;
                            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
                            pictureBox1.Image = (Image)image.Clone();
                            pictureBox1.Update();
                            //image.Dispose();
                            if (dataStr.Length == index2 + 4)
                            {
                                dataStr = "";
                            }
                            else if (dataStr.Length > (index2 + 4))
                            {
                                //Console.WriteLine("TEST TEST");
                                //Console.WriteLine("TEST TEST" + (index2 + 4));
                                string dataStr1 = dataStr.Substring(index2 + 4, (totLen - (index2 + 4)));
                                dataStr = dataStr1;
                            }
                            else
                            {

                            }
                            //}
                            //Console.WriteLine("remaining string::" + dataStr);
                        }

                    }

                    // Release the socket.  
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());

                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public Image byteArrayToImage(string strDataImage)
        {

            byte[] bytedata = GetBytes(strDataImage);
            return Base64StringToBitmap(strDataImage);
            //return Image.FromStream(new MemoryStream(Convert.FromBase64String(strDataImage)));
            //return ConvertByteArrayToImage(bytedata);
        }

        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;
            //Convert Base64 string to byte[]
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
        }
    }
}
