using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR3_Chargen
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creates a new GameSupport Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form supportForm = new GameSupport();
            supportForm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
