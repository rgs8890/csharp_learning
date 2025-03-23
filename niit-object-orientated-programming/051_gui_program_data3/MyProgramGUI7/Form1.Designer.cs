namespace MyProgramGUI7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label dEPARTMENT_IDLabel;
            System.Windows.Forms.Label dEPARTMENT_NAMELabel;
            System.Windows.Forms.Label mANAGER_IDLabel;
            System.Windows.Forms.Label lOCATION_IDLabel;
            this.nIITORADataSet = new MyProgramGUI7.NIITORADataSet();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new MyProgramGUI7.NIITORADataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.tableAdapterManager = new MyProgramGUI7.NIITORADataSetTableAdapters.TableAdapterManager();
            this.dEPARTMENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dEPARTMENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dEPARTMENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.dEPARTMENT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.mANAGER_IDTextBox = new System.Windows.Forms.TextBox();
            this.lOCATION_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new MyProgramGUI7.NIITORADataSetTableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dEPARTMENT_IDLabel = new System.Windows.Forms.Label();
            dEPARTMENT_NAMELabel = new System.Windows.Forms.Label();
            mANAGER_IDLabel = new System.Windows.Forms.Label();
            lOCATION_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nIITORADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingNavigator)).BeginInit();
            this.dEPARTMENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nIITORADataSet
            // 
            this.nIITORADataSet.DataSetName = "NIITORADataSet";
            this.nIITORADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.nIITORADataSet;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEESTableAdapter = this.eMPLOYEESTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyProgramGUI7.NIITORADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dEPARTMENTSBindingNavigator
            // 
            this.dEPARTMENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dEPARTMENTSBindingNavigator.BindingSource = this.dEPARTMENTSBindingSource;
            this.dEPARTMENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dEPARTMENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dEPARTMENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dEPARTMENTSBindingNavigatorSaveItem});
            this.dEPARTMENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dEPARTMENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dEPARTMENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dEPARTMENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dEPARTMENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dEPARTMENTSBindingNavigator.Name = "dEPARTMENTSBindingNavigator";
            this.dEPARTMENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dEPARTMENTSBindingNavigator.Size = new System.Drawing.Size(879, 25);
            this.dEPARTMENTSBindingNavigator.TabIndex = 0;
            this.dEPARTMENTSBindingNavigator.Text = "bindingNavigator1";
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
            // dEPARTMENTSBindingNavigatorSaveItem
            // 
            this.dEPARTMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dEPARTMENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dEPARTMENTSBindingNavigatorSaveItem.Image")));
            this.dEPARTMENTSBindingNavigatorSaveItem.Name = "dEPARTMENTSBindingNavigatorSaveItem";
            this.dEPARTMENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dEPARTMENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.dEPARTMENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.dEPARTMENTSBindingNavigatorSaveItem_Click_1);
            // 
            // dEPARTMENT_IDLabel
            // 
            dEPARTMENT_IDLabel.AutoSize = true;
            dEPARTMENT_IDLabel.Location = new System.Drawing.Point(26, 39);
            dEPARTMENT_IDLabel.Name = "dEPARTMENT_IDLabel";
            dEPARTMENT_IDLabel.Size = new System.Drawing.Size(99, 13);
            dEPARTMENT_IDLabel.TabIndex = 1;
            dEPARTMENT_IDLabel.Text = "DEPARTMENT ID:";
            // 
            // dEPARTMENT_IDTextBox
            // 
            this.dEPARTMENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DEPARTMENT_ID", true));
            this.dEPARTMENT_IDTextBox.Location = new System.Drawing.Point(151, 36);
            this.dEPARTMENT_IDTextBox.Name = "dEPARTMENT_IDTextBox";
            this.dEPARTMENT_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dEPARTMENT_IDTextBox.TabIndex = 2;
            // 
            // dEPARTMENT_NAMELabel
            // 
            dEPARTMENT_NAMELabel.AutoSize = true;
            dEPARTMENT_NAMELabel.Location = new System.Drawing.Point(26, 65);
            dEPARTMENT_NAMELabel.Name = "dEPARTMENT_NAMELabel";
            dEPARTMENT_NAMELabel.Size = new System.Drawing.Size(119, 13);
            dEPARTMENT_NAMELabel.TabIndex = 3;
            dEPARTMENT_NAMELabel.Text = "DEPARTMENT NAME:";
            // 
            // dEPARTMENT_NAMETextBox
            // 
            this.dEPARTMENT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DEPARTMENT_NAME", true));
            this.dEPARTMENT_NAMETextBox.Location = new System.Drawing.Point(151, 62);
            this.dEPARTMENT_NAMETextBox.Name = "dEPARTMENT_NAMETextBox";
            this.dEPARTMENT_NAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.dEPARTMENT_NAMETextBox.TabIndex = 4;
            // 
            // mANAGER_IDLabel
            // 
            mANAGER_IDLabel.AutoSize = true;
            mANAGER_IDLabel.Location = new System.Drawing.Point(26, 91);
            mANAGER_IDLabel.Name = "mANAGER_IDLabel";
            mANAGER_IDLabel.Size = new System.Drawing.Size(78, 13);
            mANAGER_IDLabel.TabIndex = 5;
            mANAGER_IDLabel.Text = "MANAGER ID:";
            // 
            // mANAGER_IDTextBox
            // 
            this.mANAGER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "MANAGER_ID", true));
            this.mANAGER_IDTextBox.Location = new System.Drawing.Point(151, 88);
            this.mANAGER_IDTextBox.Name = "mANAGER_IDTextBox";
            this.mANAGER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.mANAGER_IDTextBox.TabIndex = 6;
            // 
            // lOCATION_IDLabel
            // 
            lOCATION_IDLabel.AutoSize = true;
            lOCATION_IDLabel.Location = new System.Drawing.Point(26, 117);
            lOCATION_IDLabel.Name = "lOCATION_IDLabel";
            lOCATION_IDLabel.Size = new System.Drawing.Size(78, 13);
            lOCATION_IDLabel.TabIndex = 7;
            lOCATION_IDLabel.Text = "LOCATION ID:";
            // 
            // lOCATION_IDTextBox
            // 
            this.lOCATION_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "LOCATION_ID", true));
            this.lOCATION_IDTextBox.Location = new System.Drawing.Point(151, 114);
            this.lOCATION_IDTextBox.Name = "lOCATION_IDTextBox";
            this.lOCATION_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.lOCATION_IDTextBox.TabIndex = 8;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMP_DEPT_FK";
            this.eMPLOYEESBindingSource.DataSource = this.dEPARTMENTSBindingSource;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEESDataGridView
            // 
            this.eMPLOYEESDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.eMPLOYEESDataGridView.DataSource = this.eMPLOYEESBindingSource;
            this.eMPLOYEESDataGridView.Location = new System.Drawing.Point(29, 156);
            this.eMPLOYEESDataGridView.Name = "eMPLOYEESDataGridView";
            this.eMPLOYEESDataGridView.Size = new System.Drawing.Size(838, 220);
            this.eMPLOYEESDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn5.HeaderText = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HIRE_DATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "HIRE_DATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "JOB_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "JOB_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SALARY";
            this.dataGridViewTextBoxColumn8.HeaderText = "SALARY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COMMISSION_PCT";
            this.dataGridViewTextBoxColumn9.HeaderText = "COMMISSION_PCT";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MANAGER_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "MANAGER_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DEPARTMENT_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "DEPARTMENT_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ROWID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ROWID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 404);
            this.Controls.Add(this.eMPLOYEESDataGridView);
            this.Controls.Add(dEPARTMENT_IDLabel);
            this.Controls.Add(this.dEPARTMENT_IDTextBox);
            this.Controls.Add(dEPARTMENT_NAMELabel);
            this.Controls.Add(this.dEPARTMENT_NAMETextBox);
            this.Controls.Add(mANAGER_IDLabel);
            this.Controls.Add(this.mANAGER_IDTextBox);
            this.Controls.Add(lOCATION_IDLabel);
            this.Controls.Add(this.lOCATION_IDTextBox);
            this.Controls.Add(this.dEPARTMENTSBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIITORADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingNavigator)).EndInit();
            this.dEPARTMENTSBindingNavigator.ResumeLayout(false);
            this.dEPARTMENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NIITORADataSet nIITORADataSet;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private NIITORADataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private NIITORADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dEPARTMENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dEPARTMENTSBindingNavigatorSaveItem;
        private NIITORADataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.TextBox dEPARTMENT_IDTextBox;
        private System.Windows.Forms.TextBox dEPARTMENT_NAMETextBox;
        private System.Windows.Forms.TextBox mANAGER_IDTextBox;
        private System.Windows.Forms.TextBox lOCATION_IDTextBox;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private System.Windows.Forms.DataGridView eMPLOYEESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

