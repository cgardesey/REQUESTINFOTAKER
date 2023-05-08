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
    public partial class frmAddPicture : Form
    {
        public frmAddPicture()
        {
            InitializeComponent();
        }

        public Image picture
        {
            get { return pICTUREPictureBox.Image;  }
            set {  pICTUREPictureBox.Image = value; }
        }

        private void pICTUREBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pICTUREBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEQUESTINFOTAKERDataSet);

        }

        private void frmAddPicture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEQUESTINFOTAKERDataSet.PICTURE' table. You can move, or remove it, as needed.
            this.pICTURETableAdapter.Fill(this.rEQUESTINFOTAKERDataSet.PICTURE);

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
