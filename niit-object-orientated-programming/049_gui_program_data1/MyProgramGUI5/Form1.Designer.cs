namespace MyProgramGUI5
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
            System.Windows.Forms.Label pERSONIDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label aGELabel;
            this.dataSet1 = new MyProgramGUI5.DataSet1();
            this.mYPERSONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mYPERSONSTableAdapter = new MyProgramGUI5.DataSet1TableAdapters.MYPERSONSTableAdapter();
            this.tableAdapterManager = new MyProgramGUI5.DataSet1TableAdapters.TableAdapterManager();
            this.mYPERSONSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mYPERSONSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pERSONIDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            pERSONIDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYPERSONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYPERSONSBindingNavigator)).BeginInit();
            this.mYPERSONSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mYPERSONSBindingSource
            // 
            this.mYPERSONSBindingSource.DataMember = "MYPERSONS";
            this.mYPERSONSBindingSource.DataSource = this.dataSet1;
            // 
            // mYPERSONSTableAdapter
            // 
            this.mYPERSONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MYPERSONSTableAdapter = this.mYPERSONSTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyProgramGUI5.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mYPERSONSBindingNavigator
            // 
            this.mYPERSONSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mYPERSONSBindingNavigator.BindingSource = this.mYPERSONSBindingSource;
            this.mYPERSONSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mYPERSONSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mYPERSONSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mYPERSONSBindingNavigatorSaveItem});
            this.mYPERSONSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mYPERSONSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mYPERSONSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mYPERSONSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mYPERSONSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mYPERSONSBindingNavigator.Name = "mYPERSONSBindingNavigator";
            this.mYPERSONSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mYPERSONSBindingNavigator.Size = new System.Drawing.Size(345, 25);
            this.mYPERSONSBindingNavigator.TabIndex = 0;
            this.mYPERSONSBindingNavigator.Text = "bindingNavigator1";
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
            // mYPERSONSBindingNavigatorSaveItem
            // 
            this.mYPERSONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mYPERSONSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mYPERSONSBindingNavigatorSaveItem.Image")));
            this.mYPERSONSBindingNavigatorSaveItem.Name = "mYPERSONSBindingNavigatorSaveItem";
            this.mYPERSONSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mYPERSONSBindingNavigatorSaveItem.Text = "Save Data";
            this.mYPERSONSBindingNavigatorSaveItem.Click += new System.EventHandler(this.mYPERSONSBindingNavigatorSaveItem_Click);
            // 
            // pERSONIDLabel
            // 
            pERSONIDLabel.AutoSize = true;
            pERSONIDLabel.Location = new System.Drawing.Point(16, 44);
            pERSONIDLabel.Name = "pERSONIDLabel";
            pERSONIDLabel.Size = new System.Drawing.Size(66, 13);
            pERSONIDLabel.TabIndex = 1;
            pERSONIDLabel.Text = "PERSONID:";
            // 
            // pERSONIDTextBox
            // 
            this.pERSONIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mYPERSONSBindingSource, "PERSONID", true));
            this.pERSONIDTextBox.Location = new System.Drawing.Point(88, 41);
            this.pERSONIDTextBox.Name = "pERSONIDTextBox";
            this.pERSONIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pERSONIDTextBox.TabIndex = 2;
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(16, 70);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 3;
            nAMELabel.Text = "NAME:";
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mYPERSONSBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(88, 67);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMETextBox.TabIndex = 4;
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(16, 96);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(56, 13);
            gENDERLabel.TabIndex = 5;
            gENDERLabel.Text = "GENDER:";
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mYPERSONSBindingSource, "GENDER", true));
            this.gENDERTextBox.Location = new System.Drawing.Point(88, 93);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(100, 20);
            this.gENDERTextBox.TabIndex = 6;
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(16, 122);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(32, 13);
            aGELabel.TabIndex = 7;
            aGELabel.Text = "AGE:";
            // 
            // aGETextBox
            // 
            this.aGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mYPERSONSBindingSource, "AGE", true));
            this.aGETextBox.Location = new System.Drawing.Point(88, 119);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(100, 20);
            this.aGETextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 182);
            this.Controls.Add(pERSONIDLabel);
            this.Controls.Add(this.pERSONIDTextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(gENDERLabel);
            this.Controls.Add(this.gENDERTextBox);
            this.Controls.Add(aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Controls.Add(this.mYPERSONSBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYPERSONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYPERSONSBindingNavigator)).EndInit();
            this.mYPERSONSBindingNavigator.ResumeLayout(false);
            this.mYPERSONSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mYPERSONSBindingSource;
        private DataSet1TableAdapters.MYPERSONSTableAdapter mYPERSONSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mYPERSONSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mYPERSONSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pERSONIDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.TextBox aGETextBox;
    }
}

