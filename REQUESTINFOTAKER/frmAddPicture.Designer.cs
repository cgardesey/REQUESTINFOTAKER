namespace REQUESTINFOTAKER
{
    partial class frmAddPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pICTURELabel;
            this.rEQUESTINFOTAKERDataSet = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSet();
            this.pICTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pICTURETableAdapter = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.PICTURETableAdapter();
            this.tableAdapterManager = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager();
            this.pICTUREPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialogPix = new System.Windows.Forms.OpenFileDialog();
            pICTURELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pICTURELabel
            // 
            pICTURELabel.AutoSize = true;
            pICTURELabel.Location = new System.Drawing.Point(9, 9);
            pICTURELabel.Name = "pICTURELabel";
            pICTURELabel.Size = new System.Drawing.Size(57, 13);
            pICTURELabel.TabIndex = 5;
            pICTURELabel.Text = "PICTURE:";
            // 
            // rEQUESTINFOTAKERDataSet
            // 
            this.rEQUESTINFOTAKERDataSet.DataSetName = "REQUESTINFOTAKERDataSet";
            this.rEQUESTINFOTAKERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pICTUREBindingSource
            // 
            this.pICTUREBindingSource.DataMember = "PICTURE";
            this.pICTUREBindingSource.DataSource = this.rEQUESTINFOTAKERDataSet;
            // 
            // pICTURETableAdapter
            // 
            this.pICTURETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISPLAYREQUESTTableAdapter = null;
            this.tableAdapterManager.PICTURETableAdapter = this.pICTURETableAdapter;
            this.tableAdapterManager.REQUESTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pICTUREPictureBox
            // 
            this.pICTUREPictureBox.BackColor = System.Drawing.Color.White;
            this.pICTUREPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pICTUREPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pICTUREBindingSource, "PICTURE", true));
            this.pICTUREPictureBox.Location = new System.Drawing.Point(12, 25);
            this.pICTUREPictureBox.Name = "pICTUREPictureBox";
            this.pICTUREPictureBox.Size = new System.Drawing.Size(286, 230);
            this.pICTUREPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pICTUREPictureBox.TabIndex = 6;
            this.pICTUREPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 48);
            this.panel1.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(135, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "broowse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialogPix
            // 
            this.openFileDialogPix.FileName = "openFileDialog1";
            // 
            // frmAddPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(pICTURELabel);
            this.Controls.Add(this.pICTUREPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPicture";
            this.Load += new System.EventHandler(this.frmAddPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private REQUESTINFOTAKERDataSet rEQUESTINFOTAKERDataSet;
        private System.Windows.Forms.BindingSource pICTUREBindingSource;
        private REQUESTINFOTAKERDataSetTableAdapters.PICTURETableAdapter pICTURETableAdapter;
        private REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pICTUREPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialogPix;
    }
}