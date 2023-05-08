using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REQUESTINFOTAKER
{
    public partial class frmAddRequest : Form
    {
        public frmAddRequest()
        {
            InitializeComponent();
        }

        private void dISPLAYREQUESTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dISPLAYREQUESTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);

        }

        private void frmAddRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEQUESTINFOTAKERDataSet.DISPLAYREQUEST' table. You can move, or remove it, as needed.
            this.dISPLAYREQUESTTableAdapter.Fill(this.rEQUESTINFOTAKERDataSet.DISPLAYREQUEST);

        }
    }
}
