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
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            if (cboxPosition.SelectedItem != null)
            {
                onStartConn(cboxPosition.SelectedItem.ToString());

                btnConnect.Enabled = false;
            }
        }
    }
}
