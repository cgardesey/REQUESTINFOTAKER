namespace REQUESTINFOTAKER
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rEQUESTINFOTAKERDataSet = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSet();
            this.pICTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pICTURETableAdapter = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.PICTURETableAdapter();
            this.tableAdapterManager = new REQUESTINFOTAKER.REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager();
            this.pICTUREBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pICTUREBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pICTUREDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingNavigator)).BeginInit();
            this.pICTUREBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // pICTUREBindingNavigator
            // 
            this.pICTUREBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pICTUREBindingNavigator.BindingSource = this.pICTUREBindingSource;
            this.pICTUREBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pICTUREBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pICTUREBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pICTUREBindingNavigatorSaveItem});
            this.pICTUREBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pICTUREBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pICTUREBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pICTUREBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pICTUREBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pICTUREBindingNavigator.Name = "pICTUREBindingNavigator";
            this.pICTUREBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pICTUREBindingNavigator.Size = new System.Drawing.Size(392, 25);
            this.pICTUREBindingNavigator.TabIndex = 0;
            this.pICTUREBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pICTUREBindingNavigatorSaveItem
            // 
            this.pICTUREBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pICTUREBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pICTUREBindingNavigatorSaveItem.Image")));
            this.pICTUREBindingNavigatorSaveItem.Name = "pICTUREBindingNavigatorSaveItem";
            this.pICTUREBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pICTUREBindingNavigatorSaveItem.Text = "Save Data";
            this.pICTUREBindingNavigatorSaveItem.Click += new System.EventHandler(this.pICTUREBindingNavigatorSaveItem_Click);
            // 
            // pICTUREDataGridView
            // 
            this.pICTUREDataGridView.AutoGenerateColumns = false;
            this.pICTUREDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pICTUREDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.pICTUREDataGridView.DataSource = this.pICTUREBindingSource;
            this.pICTUREDataGridView.Location = new System.Drawing.Point(72, 73);
            this.pICTUREDataGridView.Name = "pICTUREDataGridView";
            this.pICTUREDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pICTUREDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PICTUREID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PICTUREID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DISPLAYREQUESTID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DISPLAYREQUESTID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PICTURE";
            this.dataGridViewImageColumn1.HeaderText = "PICTURE";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 313);
            this.Controls.Add(this.pICTUREDataGridView);
            this.Controls.Add(this.pICTUREBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTINFOTAKERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREBindingNavigator)).EndInit();
            this.pICTUREBindingNavigator.ResumeLayout(false);
            this.pICTUREBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pICTUREDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private REQUESTINFOTAKERDataSet rEQUESTINFOTAKERDataSet;
        private System.Windows.Forms.BindingSource pICTUREBindingSource;
        private REQUESTINFOTAKERDataSetTableAdapters.PICTURETableAdapter pICTURETableAdapter;
        private REQUESTINFOTAKERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pICTUREBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pICTUREBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pICTUREDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}