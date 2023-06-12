using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RGR_int
{
    public partial class Search : Form
    {
        public static List<Button> buttons = new List<Button>();
        public Search()
        {
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            visibility.setVisible(buttons, pictureBox6, label1, pictureBox3, buttons[0].Visible);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            async void getData()
            {

                string animeTitle = richTextBox1.Text;
                AnimeData animeData = await ShikimoriApiClient.Main(animeTitle);
                Console.WriteLine("Запрос");
                Console.WriteLine(animeData.Russian);
                Console.WriteLine(animeData.Image);
                ShikimoriApiClient api = new ShikimoriApiClient();
            }
            getData();
        }
    }
}
