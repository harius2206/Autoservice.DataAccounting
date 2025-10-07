//namespace Autoservice.Forms.Views
//{
//    partial class FServicesView
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
//            this.listBoxKeys = new System.Windows.Forms.ListBox();
//            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
//            this.flowLayoutPanelCrudButtons = new System.Windows.Forms.FlowLayoutPanel();
//            this.buttonCreate = new System.Windows.Forms.Button();
//            this.buttonUpdate = new System.Windows.Forms.Button();
//            this.buttonDelete = new System.Windows.Forms.Button();
//            this.flowLayoutPanelResultButtons = new System.Windows.Forms.FlowLayoutPanel();
//            this.buttonOk = new System.Windows.Forms.Button();
//            this.buttonCancel = new System.Windows.Forms.Button();
//            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
//            this.labelName = new System.Windows.Forms.Label();
//            this.labelWarranty = new System.Windows.Forms.Label();
//            this.labelTime = new System.Windows.Forms.Label();
//            this.labelPrice = new System.Windows.Forms.Label();
//            this.textBoxName = new System.Windows.Forms.TextBox();
//            this.checkBoxName = new System.Windows.Forms.CheckBox();
//            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
//            this.numericUpDownWarranty = new System.Windows.Forms.NumericUpDown();
//            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
//            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
//            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemDataTesting = new System.Windows.Forms.ToolStripMenuItem();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
//            this.splitContainer1.Panel1.SuspendLayout();
//            this.splitContainer1.Panel2.SuspendLayout();
//            this.splitContainer1.SuspendLayout();
//            this.flowLayoutPanelButtons.SuspendLayout();
//            this.flowLayoutPanelCrudButtons.SuspendLayout();
//            this.flowLayoutPanelResultButtons.SuspendLayout();
//            this.tableLayoutPanelControls.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWarranty)).BeginInit();
//            this.statusStrip1.SuspendLayout();
//            this.menuStrip1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // splitContainer1
//            // 
//            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
//            this.splitContainer1.Name = "splitContainer1";
//            // 
//            // splitContainer1.Panel1
//            // 
//            this.splitContainer1.Panel1.Controls.Add(this.listBoxKeys);
//            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
//            // 
//            // splitContainer1.Panel2
//            // 
//            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelButtons);
//            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelControls);
//            this.splitContainer1.Size = new System.Drawing.Size(870, 400);
//            this.splitContainer1.SplitterDistance = 374;
//            this.splitContainer1.TabIndex = 5;
//            // 
//            // listBoxKeys
//            // 
//            this.listBoxKeys.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.listBoxKeys.FormattingEnabled = true;
//            this.listBoxKeys.ItemHeight = 16;
//            this.listBoxKeys.Location = new System.Drawing.Point(0, 0);
//            this.listBoxKeys.Name = "listBoxKeys";
//            this.listBoxKeys.Size = new System.Drawing.Size(374, 400);
//            this.listBoxKeys.TabIndex = 0;
//            // 
//            // flowLayoutPanelButtons
//            // 
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelCrudButtons);
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelResultButtons);
//            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 334);
//            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
//            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(492, 66);
//            this.flowLayoutPanelButtons.TabIndex = 1;
//            // 
//            // flowLayoutPanelCrudButtons
//            // 
//            this.flowLayoutPanelCrudButtons.AutoSize = true;
//            this.flowLayoutPanelCrudButtons.Controls.Add(this.buttonCreate);
//            this.flowLayoutPanelCrudButtons.Controls.Add(this.buttonUpdate);
//            this.flowLayoutPanelCrudButtons.Controls.Add(this.buttonDelete);
//            this.flowLayoutPanelCrudButtons.Location = new System.Drawing.Point(3, 3);
//            this.flowLayoutPanelCrudButtons.Name = "flowLayoutPanelCrudButtons";
//            this.flowLayoutPanelCrudButtons.Size = new System.Drawing.Size(270, 29);
//            this.flowLayoutPanelCrudButtons.TabIndex = 0;
//            // 
//            // buttonCreate
//            // 
//            this.buttonCreate.Location = new System.Drawing.Point(3, 3);
//            this.buttonCreate.Name = "buttonCreate";
//            this.buttonCreate.Size = new System.Drawing.Size(84, 23);
//            this.buttonCreate.TabIndex = 0;
//            this.buttonCreate.Text = "Додати";
//            this.buttonCreate.UseVisualStyleBackColor = true;
//            // 
//            // buttonUpdate
//            // 
//            this.buttonUpdate.Location = new System.Drawing.Point(93, 3);
//            this.buttonUpdate.Name = "buttonUpdate";
//            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
//            this.buttonUpdate.TabIndex = 1;
//            this.buttonUpdate.Text = "Редагувати";
//            this.buttonUpdate.UseVisualStyleBackColor = true;
//            // 
//            // buttonDelete
//            // 
//            this.buttonDelete.Location = new System.Drawing.Point(183, 3);
//            this.buttonDelete.Name = "buttonDelete";
//            this.buttonDelete.Size = new System.Drawing.Size(84, 23);
//            this.buttonDelete.TabIndex = 4;
//            this.buttonDelete.Text = "Видалити";
//            this.buttonDelete.UseVisualStyleBackColor = true;
//            // 
//            // flowLayoutPanelResultButtons
//            // 
//            this.flowLayoutPanelResultButtons.AutoSize = true;
//            this.flowLayoutPanelResultButtons.Controls.Add(this.buttonOk);
//            this.flowLayoutPanelResultButtons.Controls.Add(this.buttonCancel);
//            this.flowLayoutPanelResultButtons.Location = new System.Drawing.Point(279, 3);
//            this.flowLayoutPanelResultButtons.Name = "flowLayoutPanelResultButtons";
//            this.flowLayoutPanelResultButtons.Size = new System.Drawing.Size(194, 29);
//            this.flowLayoutPanelResultButtons.TabIndex = 1;
//            // 
//            // buttonOk
//            // 
//            this.buttonOk.Location = new System.Drawing.Point(3, 3);
//            this.buttonOk.Name = "buttonOk";
//            this.buttonOk.Size = new System.Drawing.Size(98, 23);
//            this.buttonOk.TabIndex = 2;
//            this.buttonOk.Text = "Підтвердити";
//            this.buttonOk.UseVisualStyleBackColor = true;
//            // 
//            // buttonCancel
//            // 
//            this.buttonCancel.Location = new System.Drawing.Point(107, 3);
//            this.buttonCancel.Name = "buttonCancel";
//            this.buttonCancel.Size = new System.Drawing.Size(84, 23);
//            this.buttonCancel.TabIndex = 3;
//            this.buttonCancel.Text = "Відмінити";
//            this.buttonCancel.UseVisualStyleBackColor = true;
//            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
//            // 
//            // tableLayoutPanelControls
//            // 
//            this.tableLayoutPanelControls.ColumnCount = 3;
//            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
//            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
//            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
//            this.tableLayoutPanelControls.Controls.Add(this.labelName, 0, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.labelWarranty, 0, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.labelTime, 0, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.labelPrice, 0, 1);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxName, 1, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.checkBoxName, 2, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.numericUpDownTime, 1, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.numericUpDownWarranty, 1, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.maskedTextBoxPrice, 1, 1);
//            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Top;
//            this.tableLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
//            this.tableLayoutPanelControls.Margin = new System.Windows.Forms.Padding(2);
//            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
//            this.tableLayoutPanelControls.RowCount = 4;
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
//            this.tableLayoutPanelControls.Size = new System.Drawing.Size(492, 341);
//            this.tableLayoutPanelControls.TabIndex = 0;
//            // 
//            // labelName
//            // 
//            this.labelName.AutoSize = true;
//            this.labelName.Location = new System.Drawing.Point(3, 4);
//            this.labelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelName.Name = "labelName";
//            this.labelName.Size = new System.Drawing.Size(49, 16);
//            this.labelName.TabIndex = 9;
//            this.labelName.Text = "Назва";
//            // 
//            // labelWarranty
//            // 
//            this.labelWarranty.AutoSize = true;
//            this.labelWarranty.Location = new System.Drawing.Point(3, 254);
//            this.labelWarranty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelWarranty.Name = "labelWarranty";
//            this.labelWarranty.Size = new System.Drawing.Size(134, 16);
//            this.labelWarranty.TabIndex = 3;
//            this.labelWarranty.Text = "Гарантійний термін";
//            // 
//            // labelTime
//            // 
//            this.labelTime.AutoSize = true;
//            this.labelTime.Location = new System.Drawing.Point(3, 152);
//            this.labelTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelTime.Name = "labelTime";
//            this.labelTime.Size = new System.Drawing.Size(104, 16);
//            this.labelTime.TabIndex = 2;
//            this.labelTime.Text = "Час виконання";
//            // 
//            // labelPrice
//            // 
//            this.labelPrice.AutoSize = true;
//            this.labelPrice.Location = new System.Drawing.Point(3, 78);
//            this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelPrice.Name = "labelPrice";
//            this.labelPrice.Size = new System.Drawing.Size(35, 16);
//            this.labelPrice.TabIndex = 1;
//            this.labelPrice.Text = "Ціна";
//            // 
//            // textBoxName
//            // 
//            this.textBoxName.Location = new System.Drawing.Point(143, 3);
//            this.textBoxName.Multiline = true;
//            this.textBoxName.Name = "textBoxName";
//            this.textBoxName.Size = new System.Drawing.Size(314, 28);
//            this.textBoxName.TabIndex = 4;
//            // 
//            // checkBoxName
//            // 
//            this.checkBoxName.Appearance = System.Windows.Forms.Appearance.Button;
//            this.checkBoxName.AutoSize = true;
//            this.checkBoxName.Location = new System.Drawing.Point(463, 5);
//            this.checkBoxName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 7);
//            this.checkBoxName.Name = "checkBoxName";
//            this.checkBoxName.Size = new System.Drawing.Size(26, 26);
//            this.checkBoxName.TabIndex = 8;
//            this.checkBoxName.Text = "...";
//            this.checkBoxName.UseVisualStyleBackColor = true;
//            // 
//            // numericUpDownTime
//            // 
//            this.numericUpDownTime.Location = new System.Drawing.Point(143, 151);
//            this.numericUpDownTime.Name = "numericUpDownTime";
//            this.numericUpDownTime.Size = new System.Drawing.Size(120, 22);
//            this.numericUpDownTime.TabIndex = 10;
//            // 
//            // numericUpDownWarranty
//            // 
//            this.numericUpDownWarranty.Location = new System.Drawing.Point(143, 253);
//            this.numericUpDownWarranty.Name = "numericUpDownWarranty";
//            this.numericUpDownWarranty.Size = new System.Drawing.Size(120, 22);
//            this.numericUpDownWarranty.TabIndex = 11;
//            // 
//            // maskedTextBoxPrice
//            // 
//            this.maskedTextBoxPrice.Location = new System.Drawing.Point(143, 77);
//            this.maskedTextBoxPrice.Mask = "00000.00";
//            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
//            this.maskedTextBoxPrice.Size = new System.Drawing.Size(100, 22);
//            this.maskedTextBoxPrice.TabIndex = 12;
//            // 
//            // statusStrip1
//            // 
//            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripStatusLabelMessage});
//            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
//            this.statusStrip1.Name = "statusStrip1";
//            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
//            this.statusStrip1.TabIndex = 4;
//            this.statusStrip1.Text = "statusStrip1";
//            // 
//            // toolStripStatusLabelMessage
//            // 
//            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
//            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 16);
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.ToolStripMenuItemFile,
//            this.ToolStripMenuItemData});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(870, 28);
//            this.menuStrip1.TabIndex = 3;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // ToolStripMenuItemFile
//            // 
//            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.ToolStripMenuItemFileSave,
//            this.ToolStripMenuItemFileExit});
//            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
//            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(59, 24);
//            this.ToolStripMenuItemFile.Text = "&Файл";
//            // 
//            // ToolStripMenuItemFileSave
//            // 
//            this.ToolStripMenuItemFileSave.Name = "ToolStripMenuItemFileSave";
//            this.ToolStripMenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
//            this.ToolStripMenuItemFileSave.Size = new System.Drawing.Size(215, 26);
//            this.ToolStripMenuItemFileSave.Text = "&Зберегти";
//            // 
//            // ToolStripMenuItemFileExit
//            // 
//            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
//            this.ToolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
//            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(215, 26);
//            this.ToolStripMenuItemFileExit.Text = "Ви&хід";
//            // 
//            // ToolStripMenuItemData
//            // 
//            this.ToolStripMenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.ToolStripMenuItemDataTesting});
//            this.ToolStripMenuItemData.Name = "ToolStripMenuItemData";
//            this.ToolStripMenuItemData.Size = new System.Drawing.Size(54, 24);
//            this.ToolStripMenuItemData.Text = "Да&ні";
//            // 
//            // ToolStripMenuItemDataTesting
//            // 
//            this.ToolStripMenuItemDataTesting.Name = "ToolStripMenuItemDataTesting";
//            this.ToolStripMenuItemDataTesting.Size = new System.Drawing.Size(242, 26);
//            this.ToolStripMenuItemDataTesting.Text = "Створити &тестові дані";
//            // 
//            // FServicesView
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(870, 450);
//            this.Controls.Add(this.splitContainer1);
//            this.Controls.Add(this.statusStrip1);
//            this.Controls.Add(this.menuStrip1);
//            this.Name = "FServicesView";
//            this.Text = "FServicesView";
//            this.Load += new System.EventHandler(this.FServicesView_Load);
//            this.splitContainer1.Panel1.ResumeLayout(false);
//            this.splitContainer1.Panel2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
//            this.splitContainer1.ResumeLayout(false);
//            this.flowLayoutPanelButtons.ResumeLayout(false);
//            this.flowLayoutPanelButtons.PerformLayout();
//            this.flowLayoutPanelCrudButtons.ResumeLayout(false);
//            this.flowLayoutPanelResultButtons.ResumeLayout(false);
//            this.tableLayoutPanelControls.ResumeLayout(false);
//            this.tableLayoutPanelControls.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWarranty)).EndInit();
//            this.statusStrip1.ResumeLayout(false);
//            this.statusStrip1.PerformLayout();
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.SplitContainer splitContainer1;
//        private System.Windows.Forms.ListBox listBoxKeys;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrudButtons;
//        private System.Windows.Forms.Button buttonCreate;
//        private System.Windows.Forms.Button buttonUpdate;
//        private System.Windows.Forms.Button buttonDelete;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResultButtons;
//        private System.Windows.Forms.Button buttonOk;
//        private System.Windows.Forms.Button buttonCancel;
//        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
//        private System.Windows.Forms.Label labelWarranty;
//        private System.Windows.Forms.Label labelTime;
//        private System.Windows.Forms.Label labelPrice;
//        private System.Windows.Forms.TextBox textBoxName;
//        private System.Windows.Forms.CheckBox checkBoxName;
//        private System.Windows.Forms.StatusStrip statusStrip1;
//        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSave;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemData;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTesting;
//        private System.Windows.Forms.Label labelName;
//        private System.Windows.Forms.NumericUpDown numericUpDownTime;
//        private System.Windows.Forms.NumericUpDown numericUpDownWarranty;
//        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
//    }
//}