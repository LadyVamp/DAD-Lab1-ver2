using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using Dll;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
                
        Class1 obj = new Class1();
        
        public void startServer(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToInt32(textBox1.Text);
                double num2 = Convert.ToInt32(textBox2.Text);

                ChannelServices.RegisterChannel(new TcpClientChannel());

                obj = (Class1)Activator.GetObject(typeof(Class1), "tcp://localhost:3128/Hello");

               // label3.Text = obj.add(num1, num2).ToString();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Server is not avalaible");
            }

        }

        public void add_Click(object sender, EventArgs e)
        {
                double num1 = Convert.ToInt32(textBox1.Text);
                double num2 = Convert.ToInt32(textBox2.Text);

               label3.Text = obj.add(num1, num2).ToString();
        }

        public void sub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);

            label3.Text = obj.sub(num1, num2).ToString();
        }

        public void mul_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);

            label3.Text = obj.mul(num1, num2).ToString();
        }

        public void div_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);

            label3.Text = obj.div(num1, num2).ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
