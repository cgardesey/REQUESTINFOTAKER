namespace REQUESTINFOTAKER
{
    partial class frmAddRequest
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
            System.Windows.Forms.Label cUSTOMERNAMELabel;
            System.Windows.Forms.Label pRIMARYCONTACTLabel;
            System.Windows.Forms.Label aUXILIARYCONTACTLabel;
            System.Windows.Forms.Label iNSCRIPTIONLabel;
            System.Windows.Forms.Label lENGTHLabel;
            System.Windows.Forms.Label wIDTHLabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label rEQUESTDATELabel;
            System.Windows.Forms.Label nUMBEROFLEDSLabel;
            System.Windows.Forms.Label dELIVERYDATELabel;
            this.rEQUESTINFOTAKERDataSet = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSet();
            this.dISPLAYREQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dISPLAYREQUESTTableAdapter = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.DISPLAYREQUESTTableAdapter();
            this.tableAdapterManager = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pRIMARYCONTACTTextBox = new System.Windows.Forms.TextBox();
            this.aUXILIARYCONTACTTextBox = new System.Windows.Forms.TextBox();
            this.iNSCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.lENGTHTextBox = new System.Windows.Forms.TextBox();
            this.wIDTHTextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.rEQUESTDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nUMBEROFLEDSTextBox = new System.Windows.Forms.TextBox();
            this.dELIVERYDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            cUSTOMERNAMELabel = new System.Windows.Forms.Label();
            pRIMARYCONTACTLabel = new System.Windows.Forms.Label();
            aUXILIARYCONTACTLabel = new System.Windows.Forms.Label();
            iNSCRIPTIONLabel = new System.Windows.Forms.Label();
            lENGTHLabel = new System.Windows.Forms.Label();
            wIDTHLabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            rEQUESTDATELabel = new System.Windows.Forms.Label();
            nUMBEROFLEDSLabel = new System.Windows.Forms.Label();
            dELIVERYDATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPLAYREQUESTBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rEQUESTINFOTAKERDataSet
            // 
            this.rEQUESTINFOTAKERDataSet.DataSetName = "REQUESTINFOTAKERDataSet";
            this.rEQUESTINFOTAKERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dISPLAYREQUESTBindingSource
            // 
            this.dISPLAYREQUESTBindingSource.DataMember = "DISPLAYREQUEST";
            this.dISPLAYREQUESTBindingSource.DataSource = this.rEQUESTINFOTAKERDataSet;
            // 
            // dISPLAYREQUESTTableAdapter
            // 
            this.dISPLAYREQUESTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISPLAYREQUESTTableAdapter = this.dISPLAYREQUESTTableAdapter;
            this.tableAdapterManager.PICTURETableAdapter = null;
            this.tableAdapterManager.REQUESTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERNAMELabel
            // 
            cUSTOMERNAMELabel.AutoSize = true;
            cUSTOMERNAMELabel.Location = new System.Drawing.Point(27, 37);
            cUSTOMERNAMELabel.Name = "cUSTOMERNAMELabel";
            cUSTOMERNAMELabel.Size = new System.Drawing.Size(102, 13);
            cUSTOMERNAMELabel.TabIndex = 3;
            cUSTOMERNAMELabel.Text = "CUSTOMERNAME:";
            // 
            // cUSTOMERNAMETextBox
            // 
            this.cUSTOMERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "CUSTOMERNAME", true));
            this.cUSTOMERNAMETextBox.Location = new System.Drawing.Point(153, 34);
            this.cUSTOMERNAMETextBox.Name = "cUSTOMERNAMETextBox";
            this.cUSTOMERNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.cUSTOMERNAMETextBox.TabIndex = 4;
            // 
            // pRIMARYCONTACTLabel
            // 
            pRIMARYCONTACTLabel.AutoSize = true;
            pRIMARYCONTACTLabel.Location = new System.Drawing.Point(27, 66);
            pRIMARYCONTACTLabel.Name = "pRIMARYCONTACTLabel";
            pRIMARYCONTACTLabel.Size = new System.Drawing.Size(110, 13);
            pRIMARYCONTACTLabel.TabIndex = 5;
            pRIMARYCONTACTLabel.Text = "PRIMARYCONTACT:";
            // 
            // pRIMARYCONTACTTextBox
            // 
            this.pRIMARYCONTACTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "PRIMARYCONTACT", true));
            this.pRIMARYCONTACTTextBox.Location = new System.Drawing.Point(153, 63);
            this.pRIMARYCONTACTTextBox.Name = "pRIMARYCONTACTTextBox";
            this.pRIMARYCONTACTTextBox.Size = new System.Drawing.Size(200, 20);
            this.pRIMARYCONTACTTextBox.TabIndex = 6;
            // 
            // aUXILIARYCONTACTLabel
            // 
            aUXILIARYCONTACTLabel.AutoSize = true;
            aUXILIARYCONTACTLabel.Location = new System.Drawing.Point(27, 95);
            aUXILIARYCONTACTLabel.Name = "aUXILIARYCONTACTLabel";
            aUXILIARYCONTACTLabel.Size = new System.Drawing.Size(117, 13);
            aUXILIARYCONTACTLabel.TabIndex = 7;
            aUXILIARYCONTACTLabel.Text = "AUXILIARYCONTACT:";
            // 
            // aUXILIARYCONTACTTextBox
            // 
            this.aUXILIARYCONTACTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "AUXILIARYCONTACT", true));
            this.aUXILIARYCONTACTTextBox.Location = new System.Drawing.Point(153, 92);
            this.aUXILIARYCONTACTTextBox.Name = "aUXILIARYCONTACTTextBox";
            this.aUXILIARYCONTACTTextBox.Size = new System.Drawing.Size(200, 20);
            this.aUXILIARYCONTACTTextBox.TabIndex = 8;
            // 
            // iNSCRIPTIONLabel
            // 
            iNSCRIPTIONLabel.AutoSize = true;
            iNSCRIPTIONLabel.Location = new System.Drawing.Point(27, 121);
            iNSCRIPTIONLabel.Name = "iNSCRIPTIONLabel";
            iNSCRIPTIONLabel.Size = new System.Drawing.Size(79, 13);
            iNSCRIPTIONLabel.TabIndex = 9;
            iNSCRIPTIONLabel.Text = "INSCRIPTION:";
            // 
            // iNSCRIPTIONTextBox
            // 
            this.iNSCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "INSCRIPTION", true));
            this.iNSCRIPTIONTextBox.Location = new System.Drawing.Point(153, 118);
            this.iNSCRIPTIONTextBox.Name = "iNSCRIPTIONTextBox";
            this.iNSCRIPTIONTextBox.Size = new System.Drawing.Size(200, 20);
            this.iNSCRIPTIONTextBox.TabIndex = 10;
            // 
            // lENGTHLabel
            // 
            lENGTHLabel.AutoSize = true;
            lENGTHLabel.Location = new System.Drawing.Point(27, 147);
            lENGTHLabel.Name = "lENGTHLabel";
            lENGTHLabel.Size = new System.Drawing.Size(54, 13);
            lENGTHLabel.TabIndex = 11;
            lENGTHLabel.Text = "LENGTH:";
            // 
            // lENGTHTextBox
            // 
            this.lENGTHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "LENGTH", true));
            this.lENGTHTextBox.Location = new System.Drawing.Point(153, 144);
            this.lENGTHTextBox.Name = "lENGTHTextBox";
            this.lENGTHTextBox.Size = new System.Drawing.Size(200, 20);
            this.lENGTHTextBox.TabIndex = 12;
            // 
            // wIDTHLabel
            // 
            wIDTHLabel.AutoSize = true;
            wIDTHLabel.Location = new System.Drawing.Point(27, 173);
            wIDTHLabel.Name = "wIDTHLabel";
            wIDTHLabel.Size = new System.Drawing.Size(47, 13);
            wIDTHLabel.TabIndex = 13;
            wIDTHLabel.Text = "WIDTH:";
            // 
            // wIDTHTextBox
            // 
            this.wIDTHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "WIDTH", true));
            this.wIDTHTextBox.Location = new System.Drawing.Point(153, 170);
            this.wIDTHTextBox.Name = "wIDTHTextBox";
            this.wIDTHTextBox.Size = new System.Drawing.Size(200, 20);
            this.wIDTHTextBox.TabIndex = 14;
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(27, 199);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(42, 13);
            pRICELabel.TabIndex = 15;
            pRICELabel.Text = "PRICE:";
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(153, 196);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(200, 20);
            this.pRICETextBox.TabIndex = 16;
            // 
            // rEQUESTDATELabel
            // 
            rEQUESTDATELabel.AutoSize = true;
            rEQUESTDATELabel.Location = new System.Drawing.Point(27, 226);
            rEQUESTDATELabel.Name = "rEQUESTDATELabel";
            rEQUESTDATELabel.Size = new System.Drawing.Size(91, 13);
            rEQUESTDATELabel.TabIndex = 17;
            rEQUESTDATELabel.Text = "REQUESTDATE:";
            // 
            // rEQUESTDATEDateTimePicker
            // 
            this.rEQUESTDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dISPLAYREQUESTBindingSource, "REQUESTDATE", true));
            this.rEQUESTDATEDateTimePicker.Location = new System.Drawing.Point(153, 222);
            this.rEQUESTDATEDateTimePicker.Name = "rEQUESTDATEDateTimePicker";
            this.rEQUESTDATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rEQUESTDATEDateTimePicker.TabIndex = 18;
            // 
            // nUMBEROFLEDSLabel
            // 
            nUMBEROFLEDSLabel.AutoSize = true;
            nUMBEROFLEDSLabel.Location = new System.Drawing.Point(27, 251);
            nUMBEROFLEDSLabel.Name = "nUMBEROFLEDSLabel";
            nUMBEROFLEDSLabel.Size = new System.Drawing.Size(99, 13);
            nUMBEROFLEDSLabel.TabIndex = 19;
            nUMBEROFLEDSLabel.Text = "NUMBEROFLEDS:";
            // 
            // nUMBEROFLEDSTextBox
            // 
            this.nUMBEROFLEDSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISPLAYREQUESTBindingSource, "NUMBEROFLEDS", true));
            this.nUMBEROFLEDSTextBox.Location = new System.Drawing.Point(153, 248);
            this.nUMBEROFLEDSTextBox.Name = "nUMBEROFLEDSTextBox";
            this.nUMBEROFLEDSTextBox.Size = new System.Drawing.Size(200, 20);
            this.nUMBEROFLEDSTextBox.TabIndex = 20;
            // 
            // dELIVERYDATELabel
            // 
            dELIVERYDATELabel.AutoSize = true;
            dELIVERYDATELabel.Location = new System.Drawing.Point(27, 280);
            dELIVERYDATELabel.Name = "dELIVERYDATELabel";
            dELIVERYDATELabel.Size = new System.Drawing.Size(92, 13);
            dELIVERYDATELabel.TabIndex = 21;
            dELIVERYDATELabel.Text = "DELIVERYDATE:";
            // 
            // dELIVERYDATEDateTimePicker
            // 
            this.dELIVERYDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dISPLAYREQUESTBindingSource, "DELIVERYDATE", true));
            this.dELIVERYDATEDateTimePicker.Location = new System.Drawing.Point(153, 274);
            this.dELIVERYDATEDateTimePicker.Name = "dELIVERYDATEDateTimePicker";
            this.dELIVERYDATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dELIVERYDATEDateTimePicker.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 48);
            this.panel1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cUSTOMERNAMELabel);
            this.Controls.Add(this.cUSTOMERNAMETextBox);
            this.Controls.Add(pRIMARYCONTACTLabel);
            this.Controls.Add(this.pRIMARYCONTACTTextBox);
            this.Controls.Add(aUXILIARYCONTACTLabel);
            this.Controls.Add(this.aUXILIARYCONTACTTextBox);
            this.Controls.Add(iNSCRIPTIONLabel);
            this.Controls.Add(this.iNSCRIPTIONTextBox);
            this.Controls.Add(lENGTHLabel);
            this.Controls.Add(this.lENGTHTextBox);
            this.Controls.Add(wIDTHLabel);
            this.Controls.Add(this.wIDTHTextBox);
            this.Controls.Add(pRICELabel);
            this.Controls.Add(this.pRICETextBox);
            this.Controls.Add(rEQUESTDATELabel);
            this.Controls.Add(this.rEQUESTDATEDateTimePicker);
            this.Controls.Add(nUMBEROFLEDSLabel);
            this.Controls.Add(this.nUMBEROFLEDSTextBox);
            this.Controls.Add(dELIVERYDATELabel);
            this.Controls.Add(this.dELIVERYDATEDateTimePicker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRequest";
            this.Text = "frmAddRequest";
            this.Load += new System.EventHandler(this.frmAddRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPLAYREQUESTBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private REQUESTINFOTAKERDataSet rEQUESTINFOTAKERDataSet;
        private System.Windows.Forms.BindingSource dISPLAYREQUESTBindingSource;
        private REQUESTINFOTAKERDataSetTableAdapters.DISPLAYREQUESTTableAdapter dISPLAYREQUESTTableAdapter;
        private REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cUSTOMERNAMETextBox;
        private System.Windows.Forms.TextBox pRIMARYCONTACTTextBox;
        private System.Windows.Forms.TextBox aUXILIARYCONTACTTextBox;
        private System.Windows.Forms.TextBox iNSCRIPTIONTextBox;
        private System.Windows.Forms.TextBox lENGTHTextBox;
        private System.Windows.Forms.TextBox wIDTHTextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.DateTimePicker rEQUESTDATEDateTimePicker;
        private System.Windows.Forms.TextBox nUMBEROFLEDSTextBox;
        private System.Windows.Forms.DateTimePicker dELIVERYDATEDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}