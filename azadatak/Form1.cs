namespace azadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //gore\
            int brojac = Convert.ToInt32(label7.Text);
            brojac++;
            label7.Text = brojac.ToString();
            
            if (!(label1.Location.Y - 40 < 0))
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 40);
                label5.Text = label1.Location.Y.ToString();
               
            }
            else 
            {
                string poruka = "Greska";
                MessageBox.Show(poruka);
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //levo
            int brojac = Convert.ToInt32(label7.Text);
            brojac++;
            label7.Text = brojac.ToString();
            if (!(label1.Location.X - 40 < 0))
            {
                label1.Location = new Point(label1.Location.X - 40, label1.Location.Y);
                label4.Text = label1.Location.X.ToString();
            }
            else
            {
                string poruka = "Greska";
                MessageBox.Show(poruka);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //desno
            int brojac = Convert.ToInt32(label7.Text);
            brojac++;
            label7.Text = brojac.ToString();
            if (!(label1.Location.X + 80 > panel2.Width))
            {
                label1.Location = new Point(label1.Location.X + 40, label1.Location.Y);
                label4.Text = label1.Location.X.ToString();
            }
            else
            {
                string poruka = "Greska";
                MessageBox.Show(poruka);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dole
            int brojac = Convert.ToInt32(label7.Text);
            brojac++;
            label7.Text = brojac.ToString();
            if (!(label1.Location.Y + 40 > panel2.Height))
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 40);
                label5.Text = label1.Location.Y.ToString();
            }
            else
            {
                string poruka = "Greska";
                MessageBox.Show(poruka);

            }

        }
        private void Resize(object sender, EventArgs e)
        {
            label1.Location = new Point(panel2.Width/2,panel2.Height/2);
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}