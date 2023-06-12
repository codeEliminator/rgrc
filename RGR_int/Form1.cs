using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RGR_int
{
    public partial class Form1 : Form
    {
        public static List<Button> buttons = new List<Button>();

        public Form1()
        {
            //Form2 form2 = new Form2();
           // form2.Show();
            InitializeComponent();

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Search search = new Search();
            search.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            visibility.setVisible(buttons, pictureBox6, buttons[0].Visible);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            //ShikimoriApiClient api = new ShikimoriApiClient();
            //api.getDataAsync();

            
            
        }
    }

}
