using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REQUESTINFOTAKER
{
    public partial class frmDisplayRequest : Form
    {
        public frmDisplayRequest()
        {
            InitializeComponent();
        }

        private void dISPLAYREQUESTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dISPLAYREQUESTBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void frmDisplayRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEQUESTINFOTAKERDataSet.PICTURE' table. You can move, or remove it, as needed.
            this.pICTURETableAdapter.Fill(this.rEQUESTINFOTAKERDataSet.PICTURE);
            // TODO: This line of code loads data into the 'rEQUESTINFOTAKERDataSet.DISPLAYREQUEST' table. You can move, or remove it, as needed.
            this.dISPLAYREQUESTTableAdapter.Fill(this.rEQUESTINFOTAKERDataSet.DISPLAYREQUEST);

        }

        private void pICTUREBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pICTUREBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //frmAddPicture addPicture = new frmAddPicture();
            //if (addPicture .ShowDialog() == DialogResult.OK)
            //{
            //    //pICTUREBindingSource.AddNew();
            //    MemoryStream ms = new System.IO.MemoryStream();
            //    addPicture.picture.Save(ms, addPicture.picture.RawFormat);
            //    Byte[] arrImage = ms.GetBuffer();
            //    ms.Close();


            //    ((DataRowView)pICTUREBindingSource.Current)["PICTURE"] =  arrImage;
            //    this.Validate();
            //    this.pICTUREBindingSource.EndEdit();
            //    this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);

             pICTUREBindingSource.AddNew();

            }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pICTUREBindingSource.EndEdit();
            this.pICTURETableAdapter.Update (this.rEQUESTINFOTAKERDataSet.PICTURE);
            MessageBox.Show("Picture Saved succesfully");
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.openFileDialogPix.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialogPix.Title = "Please select a picture";
            this.openFileDialogPix.FileName = "";
            this.openFileDialogPix.Filter = "JPEG|*.jpg|PNG|*.png|All Files|*.*";

            if (openFileDialogPix.ShowDialog() != DialogResult.Cancel)
            {
                string piclocation = openFileDialogPix.FileName;
                this.pICTUREPictureBox.Image = System.Drawing.Image.FromFile(piclocation);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.pICTUREBindingSource.RemoveCurrent();
                    this.pICTURETableAdapter.Update(this.rEQUESTINFOTAKERDataSet.PICTURE);
                }
                catch (Exception ex)
                {
                    this.pICTUREBindingSource.CancelEdit();
                    MessageBox.Show("No item selected." + ("\r\n") + "Please select an item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pICTUREPictureBox.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchstring = tbSearch.Text;
            dISPLAYREQUESTBindingSource.Filter = "CUSTOMERNAME LIKE '%" + searchstring + "%' OR INSCRIPTION LIKE '%" + searchstring + "%'";
        }

        private void frmDisplayRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you like to close?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    frmDisplayRequest request = new frmDisplayRequest();
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Are you really sure you like to delete this?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    this.dISPLAYREQUESTBindingSource.RemoveCurrent();
                    //this.eMPLOYEEPHONETableAdapter.Update(this.dsData.EMPLOYEEPHONE);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dISPLAYREQUESTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            cUSTOMERNAMETextBox.Clear();
            pRIMARYCONTACTTextBox.Clear();
            aUXILIARYCONTACTTextBox.Clear();
            iNSCRIPTIONTextBox.Clear();
            lENGTHNumericUpDown.Text = "0";
            wIDTHNumericUpDown.Text = "0"; ;
            pRICETextBox.Text = null;
            rEQUEST_DATEDateTimePicker.Value = DateTime.Now;
            nUMBEROFLEDSNumericUpDown.Text = "0";
            dELIVERYDATEDateTimePicker.Value = DateTime.Now;
        }

    }
}
