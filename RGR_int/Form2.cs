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
    public partial class Form2 : Form
    {
        public static List<Button> buttons = new List<Button>();
        public Form2() {
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
                visibility.setVisible(buttons, pictureBox6, label1, pictureBox3,  buttons[0].Visible);            
        }
    }
}
