
namespace ProgramowanieKurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            int val = 0;
            string dupa = "dupa";
            

            if(checkMinus(tb.Text, out val)) 
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Operacja zakoñczona niepowodzeniem!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkMinus(string value, out int newValue)
        {

            if (value[0] == '-' && int.TryParse(value, out newValue))
            {
                return true;
            }
            else
            {
                newValue = 0;
                return false;

            }
        }
    }
}