using System.Windows.Forms;

namespace VATSIM_ATC_Assistent
{
    public partial class ConnFrm : Form
    {
        public delegate void OnStartConnected(string position);
        public event OnStartConnected onStartConn;

        public ConnFrm()
        {
            InitializeComponent();

            cboxESVersion.SelectedIndex = 0;

            cboxPosition.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            if (cboxPosition.SelectedItem != null)
            {
                App.ESVersion = cboxESVersion.SelectedItem.ToString();

                onStartConn(cboxPosition.SelectedItem.ToString());

                btnConnect.Enabled = false;
            }
        }

        private void ConnFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
