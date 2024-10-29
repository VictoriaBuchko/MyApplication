namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ModalWindowButton.Click += ModalWindowButton_Click;
            Controls.Add(ModalWindowButton);
            NoModalWindowButton.Click += NoModalWindowButton_Click;
            Controls.Add(NoModalWindowButton);
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це інформаційне повідомлення", "Інформація");
        }

        private void NoModalWindowButton_Click(object sender, EventArgs e)
        {
            Form2 NoModalForm = new Form2();
            NoModalForm.Show(); 
        }

        private void ModalWindowButton_Click(object sender, EventArgs e)
        {
            Form3 modalForm = new Form3();
            modalForm.ShowDialog(); 
        }
    }
}
