using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculateur_de_distances
{
    public partial class form : Form
    {
        int dimension = 1;

        public form()
        {
            InitializeComponent();

            panel_y.Visible = false;
            panel_z.Visible = false;
            panel_v.Visible = false;
        }

        private void button_1d_Click(object sender, EventArgs e)
        {
            dimension = 1;

            panel_y.Visible = false;
            panel_z.Visible = false;
            panel_v.Visible = false;
        }

        private void button_2d_Click(object sender, EventArgs e)
        {
            dimension = 2;

            panel_y.Visible = true;
            panel_z.Visible = false;
            panel_v.Visible = false;
        }

        private void button_3d_Click(object sender, EventArgs e)
        {
            dimension = 3;

            panel_y.Visible = true;
            panel_z.Visible = true;
            panel_v.Visible = false;
        }

        private void button_4d_Click(object sender, EventArgs e)
        {
            dimension = 4;

            panel_y.Visible = true;
            panel_z.Visible = true;
            panel_v.Visible = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            label_result.Text = "Valeur : ";

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = String.Empty;
            }
        }

        private void button_compute_Click(object sender, EventArgs e)
        { 
            List<Control> list = new List<Control>();

            int count = 0;

            double distance;

            foreach (Control activControl in Controls)
            {
                if (activControl.Visible && activControl is TextBox && activControl.Text != String.Empty)
                {
                    list.Add(activControl);

                    count++;
                }
            }

            switch (dimension)
            {
                case 1:
                    if (count == 2)
                    {
                        distance = Dimensions.OneD(Convert.ToSingle(textBox_x1.Text), Convert.ToSingle(textBox_x2.Text));
                        label_result.Text = distance.ToString("Valeur : " + "0.###");
                    }

                    else
                    {
                        label_result.Text = "Valeur incorrecte, veuillez entrer des nombres valides.";
                    }

                    break;
                case 2:
                    if (count == 4)
                    {
                        distance = Dimensions.TwoD(Convert.ToSingle(textBox_x1.Text), Convert.ToSingle(textBox_x2.Text), Convert.ToSingle(textBox_y1.Text), Convert.ToSingle(textBox_y2.Text));

                        label_result.Text = distance.ToString("Valeur : " + "0.###");
                    }

                    else
                    {
                        label_result.Text = "Valeur incorrecte, veuillez entrer des nombres valides.";
                    }

                    break;
                case 3:
                    if (count == 6)
                    {
                        distance = Dimensions.ThreeD(Convert.ToSingle(textBox_x1.Text), Convert.ToSingle(textBox_x2.Text), Convert.ToSingle(textBox_y1.Text), Convert.ToSingle(textBox_y2.Text), Convert.ToSingle(textBox_z1.Text), Convert.ToSingle(textBox_z2.Text));

                        label_result.Text = distance.ToString("Valeur : " + "0.###");
                    }

                    else
                    {
                        label_result.Text = "Valeur incorrecte, veuillez entrer des nombres valides.";
                    }

                    break;
                case 4:
                    if (count == 8)
                    {
                        distance = Dimensions.FourD(Convert.ToSingle(textBox_x1.Text), Convert.ToSingle(textBox_x2.Text), Convert.ToSingle(textBox_y1.Text), Convert.ToSingle(textBox_y2.Text), Convert.ToSingle(textBox_z1.Text), Convert.ToSingle(textBox_z2.Text), Convert.ToSingle(textBox_v1.Text), Convert.ToSingle(textBox_v2.Text));

                        label_result.Text = distance.ToString("Valeur : " + "0.###");
                    }
                    else
                    {
                        label_result.Text = "Valeur incorrecte, veuillez entrer des nombres valides.";
                    }

                    break;
            }
        }
    }
}
