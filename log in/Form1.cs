namespace log_in
{
    public partial class mario : Form
    {
        public mario()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        { // this block makes the transition between form 1 and form2 
            //  hides the form
            this.Hide();
            //  this i think it assign the new main to ss
            Main ss = new Main();
            // shows it 
            ss.Show(); 
        }

        private void Exit_Click(object sender, EventArgs e)
        {   // this means close
            this.Close(); 
        }
    }
}
