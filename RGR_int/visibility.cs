using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_int
{
    class visibility
    {
        public static void setVisible(List <Button> buttons, PictureBox pictureBox6, bool visibility)
        {
            foreach (Button button in buttons)
            {
                button.Visible = !visibility;
            }
            pictureBox6.Visible = !visibility;
        }
        public static void setVisible(List<Button> buttons, PictureBox pictureBox6, Label label1, PictureBox pictureBox3, bool visibility)
        {
            foreach (Button button in buttons)
            {
                button.Visible = !visibility;
            }
            pictureBox6.Visible = !visibility;
            pictureBox3.Visible = !visibility;
            label1.Visible = !visibility;
        }
    }
}
