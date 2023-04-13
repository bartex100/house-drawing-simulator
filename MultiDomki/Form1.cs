namespace MultiDomki
{
    public partial class Form1 : Form
    {
        int x, y, width, height,dach;
        Graphics rysunek;
        Pen Kolor;
        Pen Kolor2;
        Pen Kolor3;
        Pen Kolor4;

        private void button2_Click(object sender, EventArgs e)
        {
            rysunek.Clear(Color.White);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Kolor.Width = (float)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Kolor2.Width = (float)numericUpDown2.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
                Kolor2.Color = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                Kolor3.Color = colorDialog1.Color;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Kolor3.Width = (float)numericUpDown3.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button6.BackColor = colorDialog1.Color;
                Kolor4.Color = colorDialog1.Color;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Kolor4.Width = (float)numericUpDown4.Value;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
                Kolor.Color = colorDialog1.Color;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = checkBox1.Checked;
            button4.Enabled = checkBox1.Checked;
        }

        
        public Form1()
        {
            InitializeComponent();
            rysunek= pictureBox1.CreateGraphics();
            Kolor = new Pen(Color.Red, 5);
            Kolor2 = new Pen(Color.Red, 5);
            Kolor3 = new Pen(Color.Aqua, 2);
            Kolor4 = new Pen(Color.Brown, 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            width = Convert.ToInt32(textBox3.Text);
            height = Convert.ToInt32(textBox4.Text);
            dach= Convert.ToInt32(textBox5.Text);
            rysunek.DrawLine(Kolor, x, y, x+width, y);
            rysunek.DrawLine(Kolor, x, y, x, y+height);
            rysunek.DrawLine(Kolor, x+width, y, x+width, y+height);
            rysunek.DrawLine(Kolor, x, y+height, x+width, y+height);
            if(checkBox1.Checked==true)
            {
                if(comboBox2.Text=="Trójk¹tny"||comboBox2.Text=="")
                {
                    rysunek.DrawLine(Kolor2, x, y, x + (width / 2), y - dach);
                    rysunek.DrawLine(Kolor2, x+width, y, x + (width / 2), y - dach);
                }
                if (comboBox2.Text == "Trapezowy")
                {
                    rysunek.DrawLine(Kolor2, x, y, x + (width / 4), y - dach);
                    rysunek.DrawLine(Kolor2, x + width, y,x+((width/4)*3) , y - dach);
                    rysunek.DrawLine(Kolor2,x+(width/4)*3,y-dach, x+(width/4), y-dach);
                }
            }
            if(checkBox2.Checked==true)
            {
                rysunek.DrawLine(Kolor3, x + (width / 5), y + (height / 5), x + ((width / 5) * 2), y + (height / 5));
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 3), y + (height / 5), x + ((width / 5) * 4), y + (height / 5));
                //
                rysunek.DrawLine(Kolor3, x + (width / 5), y + (height / 5)*2, x + ((width / 5) * 2), y + (height / 5)*2);
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 3), y + (height / 5)*2, x + ((width / 5) * 4), y + (height / 5)*2);
                //
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 2), y + (height / 5), x + ((width / 5) * 2), y + (height / 5) * 2);
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 3), y + (height / 5), x + ((width / 5) * 3), y + (height / 5) * 2);
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 4), y + (height / 5), x + ((width / 5) * 4), y + (height / 5) * 2);
                rysunek.DrawLine(Kolor3, x + ((width / 5) * 1), y + (height / 5), x + ((width / 5) * 1), y + (height / 5) * 2);
                if (comboBox1.Text == "Dwuczêœciowe" || comboBox1.Text == "Czteroczêœciowe")
                {
                    rysunek.DrawLine(Kolor3, x + ((width / 5) * 1), y + ((height / 5) + (height / 10)), x + (width / 5) * 2, y + (height / 5) + (height / 10));
                    rysunek.DrawLine(Kolor3, x + ((width / 5) * 3), y + ((height / 5) + (height / 10)), x + (width / 5) * 4, y + (height / 5) + (height / 10));
                    if (comboBox1.Text == "Czteroczêœciowe")
                    {
                        rysunek.DrawLine(Kolor3, (x + (width / 5) * 1) + width / 10, y + height / 5, (x + (width / 5)) + width / 10, y + (height / 5) * 2);
                        rysunek.DrawLine(Kolor3, (x + (width / 5) * 3) + width / 10, y + height / 5, (x + (width / 5) * 3) + width / 10, y + (height / 5) * 2);
                    }
                }
            }
            if(checkBox3.Checked==true)
            {
                rysunek.DrawLine(Kolor4, x + ((width / 5) * 2), y + (height / 5)*3, x+((width/5)*2),y+height);
                rysunek.DrawLine(Kolor4, x+ ((width/5) * 3), y+ (height/5)*3,x+((width/5)*3),y+height);
                rysunek.DrawLine(Kolor4, x + ((width/5)*2), y+ (height/5)*3,x+((width/5)*3),y+(height/5)*3);
                rysunek.DrawLine(Kolor4, x + ((width/5)*2), y+ (height/5)*3,x+((width/5)*3),y+(height/5)*3);
            }
            if(comboBox3.Text=="Ceg³y")
            {

                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 6), x + ((width / 5) * 2), y + ((height / 7) * 6));
                rysunek.DrawLine(Kolor, x + ((width / 5) * 3), y + (height / 7) * 6, x + width, y + (height / 7) * 6);
                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 5), x + ((width / 5) * 2), y + ((height / 7) * 5));
                rysunek.DrawLine(Kolor, x + ((width / 5) * 3), y + (height / 7) * 5, x + width, y + (height / 7) * 5);
                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 4), x + width, y + ((height / 7) * 4));
                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 3), x + width, y + ((height / 7) * 3));
                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 1), x + width, y + ((height / 7) * 1));
                rysunek.DrawLine(Kolor, x, y + ((height / 7) * 2), x + (width/5)*1, y + ((height / 7) * 2));
                rysunek.DrawLine(Kolor, x+(width/5)*2, y + ((height / 7) * 2), x + (width/5)*3, y + ((height / 7) * 2));
                rysunek.DrawLine(Kolor, x+(width/5)*4, y + ((height / 7) * 2), x + (width/5)*5, y + ((height / 7) * 2));
                rysunek.DrawLine(Kolor, x + (width/5)*1, y + height,x+(width/5)*1, y+(height/7)*6);
                rysunek.DrawLine(Kolor, x + (width/5)*4, y + height,x+(width/5)*4, y+(height/7)*6);  
                rysunek.DrawLine(Kolor, x + (width/5)*4, y + (height/7)*4,x+(width/5)*4, y+(height/7)*5);  
                rysunek.DrawLine(Kolor, x + (width/5)*1, y + (height/7)*4,x+(width/5)*1, y+(height/7)*5);  
                //pdb
                rysunek.DrawLine(Kolor, x + (width/5)*1, y + (height/7)*2,x+(width/5)*1, y+(height/7)*3);  
                rysunek.DrawLine(Kolor, x + (width/5)*4, y + (height/7)*2,x+(width/5)*4, y+(height/7)*3);
                //pde
                rysunek.DrawLine(Kolor, x + (width / 5) * 1, y + height / 7, x + (width / 5) * 1, y );
                rysunek.DrawLine(Kolor, x + (width / 5) * 4, y + height / 7, x + (width / 5) * 4, y );

                rysunek.DrawLine(Kolor, x + (width/10)*5, y + (height/7)*3,x+(width/10)*5, y+(height/7)*4);  
                rysunek.DrawLine(Kolor, x + (width/10)*5, y + (height/7)*1,x+(width/10)*5, y+(height/7)*2);  
            }
        }
    }
}