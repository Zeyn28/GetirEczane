using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme_2
{
    public partial class Form6 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempindex;
        

        public Form6()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods

        private Color SelectThemeColor()
        {
            int index = random.Next(Colors.ColorList.Count);
            while (tempindex == index)
            {
               index= random.Next(Colors.ColorList.Count);
            }
            tempindex = index;
            string color = Colors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object yeni)
        {
            if (yeni != null)
            {
                if (currentButton != (Button)yeni)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)yeni;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Rockwell", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

       
        private void DisableButton()
        {
            foreach(Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkCyan;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font= new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Application.Exit();
        }
    }
}
