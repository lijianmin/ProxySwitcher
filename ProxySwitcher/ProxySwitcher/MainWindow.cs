using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class MainWindow : Form
    {
        private AppLogic app;

        public MainWindow()
        {
            InitializeComponent();
            
            this.app = new AppLogic();

            this.comboServers.DataSource = app.LoadServers();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.app.EnableProxy(comboServers.Text);

            String msg = comboServers.Text + " enabled";

            MessageBox.Show(msg, "Done!", MessageBoxButtons.OK);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            this.app.DisableProxy();
            MessageBox.Show("Proxy Disabled", "Done!", MessageBoxButtons.OK);
        }
    }
}
