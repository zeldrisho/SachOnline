using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmClient : Form
    {
        IPEndPoint IP;
        Socket client;
        private string msg;
        MemoryStream stream;
        BinaryFormatter formatter;
        Thread listen;

        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            ActiveControl = txtMessage;
        }

        private void frmClient_Shown(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMessage.Text);
            txtMessage.Focus();
        }

        private void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void Close()
        {
            client.Close();
        }

        private void Send()
        {
            if (txtMessage.Text != String.Empty)
                client.Send(Serialize(txtMessage.Text));
        }

        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    msg = (string)Deserialize(data);
                    AddMessage(msg);
                }
            }
            catch
            {
                Close();
            }
        }

        private void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
            txtMessage.Focus();
        }

        byte[] Serialize(object obj)
        {
            stream = new MemoryStream();
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            stream = new MemoryStream(data);
            formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void frmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }
    }
}
