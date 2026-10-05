using System;
using System.Windows.Forms;

namespace kafe_sistemi
{
    public partial class Form1 : Form
    {
        int index = 0;
        float mebleg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear(); 
            textBox3.Clear(); 
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult netice = MessageBox.Show("Xanalar və səbət sıfırlansınmı?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (netice == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                index = 0;
                mebleg = 0;
            }
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Tort");
            mebleg += 2.5f;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Cola");
            mebleg += 1.5f;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Meyve siresi");
            mebleg += 3.5f;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Burger");
            mebleg += 8.8f;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Sandivic");
            mebleg += 5.75f;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Pizza");
            mebleg += 12.0f;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Balatort");
            mebleg += 1.0f;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Hotdog");
            mebleg += 2.89f;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            index += 1;
            listBox1.Items.Add(index + ". Qogal");
            mebleg += 0.5f;
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = mebleg.ToString() + " AZN";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult netice = MessageBox.Show("Seçilmiş məhsul səbətdən silinsinmi?", "Silinmə təsdiqi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (netice == DialogResult.Yes)
                {
                    string secilen = listBox1.SelectedItem.ToString();

                    if (secilen.Contains("Tort")) mebleg -= 2.5f;
                    else if (secilen.Contains("Cola")) mebleg -= 1.5f;
                    else if (secilen.Contains("Meyve siresi")) mebleg -= 3.5f;
                    else if (secilen.Contains("Burger")) mebleg -= 8.8f;
                    else if (secilen.Contains("Sandivic")) mebleg -= 5.75f;
                    else if (secilen.Contains("Pizza")) mebleg -= 12.0f;
                    else if (secilen.Contains("Balatort")) mebleg -= 1.0f;
                    else if (secilen.Contains("Hotdog")) mebleg -= 2.89f;
                    else if (secilen.Contains("Qogal")) mebleg -= 0.5f;

                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        string itemText = listBox1.Items[i].ToString();
                        int noktaIndex = itemText.IndexOf(". ");
                        if (noktaIndex != -1)
                        {
                            string mehsulAdi = itemText.Substring(noktaIndex);
                            listBox1.Items[i] = (i + 1) + mehsulAdi;
                        }
                    }

                    index = listBox1.Items.Count;
                    textBox4.Text = mebleg.ToString() + " AZN";
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa silmək üçün siyahıdan bir məhsul seçin!");
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            float verilenPul;

            if (float.TryParse(textBox2.Text, out verilenPul))
            {
                if (verilenPul >= mebleg)
                {
                    float qaliq = verilenPul - mebleg;
                    textBox3.Text = qaliq.ToString() + " AZN";
                }
                else
                {
                    textBox3.Text = "Yetersiz məbləğ";
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa düzgün məbləğ daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}