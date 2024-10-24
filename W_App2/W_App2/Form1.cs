namespace W_App2
{
    public partial class Form1 : Form
    {
        int i = 0, j = 0,k=0 , all=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();

            all++;
            label4.Text = all.ToString();

            if (i == 33)
            {
                i = 0;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            j++;
            label2.Text = j.ToString();
           
            all++;
            label4.Text = all.ToString();

            if (j == 33)
            {
                j = 0;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            k++;
            label3.Text = k.ToString();

            all++;
            label4.Text = all.ToString();

            if (k == 33)
            {
                k = 0;
               
            }
        }
    }
}
