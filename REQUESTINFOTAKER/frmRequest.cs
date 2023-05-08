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
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
        }

        private void rEQUESTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rEQUESTBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);
                MessageBox.Show("Successfully Saved!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEQUESTINFOTAKERDataSet.REQUEST' table. You can move, or remove it, as needed.
            this.rEQUESTTableAdapter.Fill(this.rEQUESTINFOTAKERDataSet.REQUEST);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browseImage();
        }

        private void browseImage()
        {
            this.openFileDialog1
                .Title = "Select Image";
            openFileDialog1.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pICTUREPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                pICTUREPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pICTUREPictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            cUSTOMER_NAMETextBox.Clear();
            pRIMARY_CONTACTTextBox.Clear();
            aUXILIARY_CONTACTTextBox.Clear();
            iNSCRIPTIONTextBox.Clear();
            lENGTHNumericUpDown.Text = "0";
            wIDTHNumericUpDown.Text = "0"; ;
            pRICETextBox.Text = null;
            rEQUEST_DATEDateTimePicker.Value = DateTime.Now;
            nUMBER_OF_LEDSNumericUpDown.Text = "0";
            pICTUREPictureBox.Image = null;
            dELIVERY_DATEDateTimePicker.Value = DateTime.Now;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Are you really sure you like to delete this?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        this.rEQUESTBindingSource.RemoveCurrent();
                        //this.eMPLOYEEPHONETableAdapter.Update(this.dsData.EMPLOYEEPHONE);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pICTUREPictureBox.Image = null;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchstring = tbSearch.Text;
            rEQUESTBindingSource.Filter = "[CUSTOMER NAME] LIKE '%" + searchstring + "%' OR INSCRIPTION LIKE '%" + searchstring + "%'";
        }

        private void rEQUESTIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void dELIVERY_DATELabel_Click(object sender, EventArgs e)
        {

        }

        private void aUXILIARY_CONTACTLabel_Click(object sender, EventArgs e)
        {

        }

        private void pICTURELabel_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            tbSearch.Clear();
        }

        private void frmRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you like to close?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    frmRequest request = new frmRequest();
                    request.Close();
                }
                else
                    e.Cancel = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
