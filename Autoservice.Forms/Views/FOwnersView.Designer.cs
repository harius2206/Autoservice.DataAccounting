//namespace Autoservice.Forms.Views
//{
//    partial class FOwnersView
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemDataTesting = new System.Windows.Forms.ToolStripMenuItem();
//            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
//            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
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
//            this.labelVlasnik = new System.Windows.Forms.Label();
//            this.labelAdress = new System.Windows.Forms.Label();
//            this.labelEmai = new System.Windows.Forms.Label();
//            this.labelNumber = new System.Windows.Forms.Label();
//            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
//            this.textBoxAdress = new System.Windows.Forms.TextBox();
//            this.textBoxEmail = new System.Windows.Forms.TextBox();
//            this.checkBoxVlasnik = new System.Windows.Forms.CheckBox();
//            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
//            this.ToolStripMenuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
//            this.menuStrip1.SuspendLayout();
//            this.statusStrip1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
//            this.splitContainer1.Panel1.SuspendLayout();
//            this.splitContainer1.Panel2.SuspendLayout();
//            this.splitContainer1.SuspendLayout();
//            this.flowLayoutPanelButtons.SuspendLayout();
//            this.flowLayoutPanelCrudButtons.SuspendLayout();
//            this.flowLayoutPanelResultButtons.SuspendLayout();
//            this.tableLayoutPanelControls.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.ToolStripMenuItemFile,
//            this.ToolStripMenuItemData});
//            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
//            this.menuStrip1.TabIndex = 0;
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
//            this.ToolStripMenuItemFileSave.Size = new System.Drawing.Size(224, 26);
//            this.ToolStripMenuItemFileSave.Text = "&Зберегти";
//            // 
//            // ToolStripMenuItemFileExit
//            // 
//            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
//            this.ToolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
//            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(224, 26);
//            this.ToolStripMenuItemFileExit.Text = "Ви&хід";
//            // 
//            // ToolStripMenuItemData
//            // 
//            this.ToolStripMenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.ToolStripMenuItemDataTesting,
//            this.ToolStripMenuItemDeleteAll});
//            this.ToolStripMenuItemData.Name = "ToolStripMenuItemData";
//            this.ToolStripMenuItemData.Size = new System.Drawing.Size(54, 24);
//            this.ToolStripMenuItemData.Text = "Да&ні";
//            // 
//            // ToolStripMenuItemDataTesting
//            // 
//            this.ToolStripMenuItemDataTesting.Name = "ToolStripMenuItemDataTesting";
//            this.ToolStripMenuItemDataTesting.Size = new System.Drawing.Size(242, 26);
//            this.ToolStripMenuItemDataTesting.Text = "Створити &тестові дані";
//            this.ToolStripMenuItemDataTesting.Click += new System.EventHandler(this.ToolStripMenuItemDataTesting_Click);
//            // 
//            // statusStrip1
//            // 
//            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripStatusLabelMessage});
//            this.statusStrip1.Location = new System.Drawing.Point(3, 438);
//            this.statusStrip1.Name = "statusStrip1";
//            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
//            this.statusStrip1.TabIndex = 1;
//            this.statusStrip1.Text = "statusStrip1";
//            // 
//            // toolStripStatusLabelMessage
//            // 
//            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
//            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 16);
//            // 
//            // splitContainer1
//            // 
//            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.splitContainer1.Location = new System.Drawing.Point(3, 31);
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
//            this.splitContainer1.Size = new System.Drawing.Size(912, 407);
//            this.splitContainer1.SplitterDistance = 393;
//            this.splitContainer1.TabIndex = 2;
//            // 
//            // listBoxKeys
//            // 
//            this.listBoxKeys.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.listBoxKeys.FormattingEnabled = true;
//            this.listBoxKeys.ItemHeight = 16;
//            this.listBoxKeys.Location = new System.Drawing.Point(0, 0);
//            this.listBoxKeys.Name = "listBoxKeys";
//            this.listBoxKeys.Size = new System.Drawing.Size(393, 407);
//            this.listBoxKeys.TabIndex = 0;
//            this.listBoxKeys.SelectedIndexChanged += new System.EventHandler(this.listBoxKeys_SelectedIndexChanged_1);
//            // 
//            // flowLayoutPanelButtons
//            // 
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelCrudButtons);
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelResultButtons);
//            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 341);
//            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
//            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(515, 66);
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
//            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
//            // 
//            // buttonUpdate
//            // 
//            this.buttonUpdate.Location = new System.Drawing.Point(93, 3);
//            this.buttonUpdate.Name = "buttonUpdate";
//            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
//            this.buttonUpdate.TabIndex = 1;
//            this.buttonUpdate.Text = "Редагувати";
//            this.buttonUpdate.UseVisualStyleBackColor = true;
//            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
//            // 
//            // buttonDelete
//            // 
//            this.buttonDelete.Location = new System.Drawing.Point(183, 3);
//            this.buttonDelete.Name = "buttonDelete";
//            this.buttonDelete.Size = new System.Drawing.Size(84, 23);
//            this.buttonDelete.TabIndex = 4;
//            this.buttonDelete.Text = "Видалити";
//            this.buttonDelete.UseVisualStyleBackColor = true;
//            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
//            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
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
//            this.tableLayoutPanelControls.Controls.Add(this.labelVlasnik, 0, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.labelAdress, 0, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.labelEmai, 0, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.labelNumber, 0, 1);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxVlasnik, 1, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxAdress, 1, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxEmail, 1, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.checkBoxVlasnik, 2, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.maskedTextBoxNumber, 1, 1);
//            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Top;
//            this.tableLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
//            this.tableLayoutPanelControls.Margin = new System.Windows.Forms.Padding(2);
//            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
//            this.tableLayoutPanelControls.RowCount = 4;
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
//            this.tableLayoutPanelControls.Size = new System.Drawing.Size(515, 341);
//            this.tableLayoutPanelControls.TabIndex = 0;
//            this.tableLayoutPanelControls.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelControls_Paint);
//            // 
//            // labelVlasnik
//            // 
//            this.labelVlasnik.AutoSize = true;
//            this.labelVlasnik.Location = new System.Drawing.Point(3, 4);
//            this.labelVlasnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelVlasnik.Name = "labelVlasnik";
//            this.labelVlasnik.Size = new System.Drawing.Size(62, 16);
//            this.labelVlasnik.TabIndex = 0;
//            this.labelVlasnik.Text = "Власник";
//            // 
//            // labelAdress
//            // 
//            this.labelAdress.AutoSize = true;
//            this.labelAdress.Location = new System.Drawing.Point(3, 254);
//            this.labelAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelAdress.Name = "labelAdress";
//            this.labelAdress.Size = new System.Drawing.Size(55, 16);
//            this.labelAdress.TabIndex = 3;
//            this.labelAdress.Text = "Адреса";
//            // 
//            // labelEmai
//            // 
//            this.labelEmai.AutoSize = true;
//            this.labelEmai.Location = new System.Drawing.Point(3, 152);
//            this.labelEmai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelEmai.Name = "labelEmai";
//            this.labelEmai.Size = new System.Drawing.Size(41, 16);
//            this.labelEmai.TabIndex = 2;
//            this.labelEmai.Text = "Email";
//            // 
//            // labelNumber
//            // 
//            this.labelNumber.AutoSize = true;
//            this.labelNumber.Location = new System.Drawing.Point(3, 78);
//            this.labelNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelNumber.Name = "labelNumber";
//            this.labelNumber.Size = new System.Drawing.Size(50, 16);
//            this.labelNumber.TabIndex = 1;
//            this.labelNumber.Text = "Номер";
//            // 
//            // textBoxVlasnik
//            // 
//            this.textBoxVlasnik.Location = new System.Drawing.Point(71, 3);
//            this.textBoxVlasnik.Multiline = true;
//            this.textBoxVlasnik.Name = "textBoxVlasnik";
//            this.textBoxVlasnik.Size = new System.Drawing.Size(354, 28);
//            this.textBoxVlasnik.TabIndex = 4;
//            this.textBoxVlasnik.TextChanged += new System.EventHandler(this.textBoxVlasnik_TextChanged);
//            // 
//            // textBoxAdress
//            // 
//            this.textBoxAdress.Dock = System.Windows.Forms.DockStyle.Top;
//            this.textBoxAdress.Location = new System.Drawing.Point(71, 253);
//            this.textBoxAdress.Multiline = true;
//            this.textBoxAdress.Name = "textBoxAdress";
//            this.textBoxAdress.Size = new System.Drawing.Size(409, 22);
//            this.textBoxAdress.TabIndex = 5;
//            // 
//            // textBoxEmail
//            // 
//            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Top;
//            this.textBoxEmail.Location = new System.Drawing.Point(71, 151);
//            this.textBoxEmail.Multiline = true;
//            this.textBoxEmail.Name = "textBoxEmail";
//            this.textBoxEmail.Size = new System.Drawing.Size(409, 22);
//            this.textBoxEmail.TabIndex = 7;
//            // 
//            // checkBoxVlasnik
//            // 
//            this.checkBoxVlasnik.Appearance = System.Windows.Forms.Appearance.Button;
//            this.checkBoxVlasnik.AutoSize = true;
//            this.checkBoxVlasnik.Location = new System.Drawing.Point(486, 5);
//            this.checkBoxVlasnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 7);
//            this.checkBoxVlasnik.Name = "checkBoxVlasnik";
//            this.checkBoxVlasnik.Size = new System.Drawing.Size(26, 26);
//            this.checkBoxVlasnik.TabIndex = 8;
//            this.checkBoxVlasnik.Text = "...";
//            this.checkBoxVlasnik.UseVisualStyleBackColor = true;
//            this.checkBoxVlasnik.CheckedChanged += new System.EventHandler(this.checkBoxVlasnik_CheckedChanged);
//            // 
//            // maskedTextBoxNumber
//            // 
//            this.maskedTextBoxNumber.Location = new System.Drawing.Point(71, 77);
//            this.maskedTextBoxNumber.Mask = "AA 0000 AA";
//            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
//            this.maskedTextBoxNumber.Size = new System.Drawing.Size(100, 22);
//            this.maskedTextBoxNumber.TabIndex = 9;
//            this.maskedTextBoxNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNumber_MaskInputRejected);
//            // 
//            // ToolStripMenuItemDeleteAll
//            // 
//            this.ToolStripMenuItemDeleteAll.Name = "ToolStripMenuItemDeleteAll";
//            this.ToolStripMenuItemDeleteAll.Size = new System.Drawing.Size(242, 26);
//            this.ToolStripMenuItemDeleteAll.Text = "Видалити &усі дані";
//            this.ToolStripMenuItemDeleteAll.Click += new System.EventHandler(this.ToolStripMenuItemDeleteAll_Click);
//            // 
//            // FOwnersView
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(918, 463);
//            this.Controls.Add(this.splitContainer1);
//            this.Controls.Add(this.statusStrip1);
//            this.Controls.Add(this.menuStrip1);
//            this.MainMenuStrip = this.menuStrip1;
//            this.MinimumSize = new System.Drawing.Size(559, 510);
//            this.Name = "FOwnersView";
//            this.Padding = new System.Windows.Forms.Padding(3);
//            this.Text = "FOwnersView";
//            this.Load += new System.EventHandler(this.FOwnersView_Load);
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.statusStrip1.ResumeLayout(false);
//            this.statusStrip1.PerformLayout();
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
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.StatusStrip statusStrip1;
//        private System.Windows.Forms.SplitContainer splitContainer1;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemData;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSave;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
//        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
//        private System.Windows.Forms.ListBox listBoxKeys;
//        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
//        private System.Windows.Forms.Label labelVlasnik;
//        private System.Windows.Forms.Label labelAdress;
//        private System.Windows.Forms.Label labelEmai;
//        private System.Windows.Forms.Label labelNumber;
//        private System.Windows.Forms.TextBox textBoxVlasnik;
//        private System.Windows.Forms.TextBox textBoxAdress;
//        private System.Windows.Forms.TextBox textBoxEmail;
//        private System.Windows.Forms.CheckBox checkBoxVlasnik;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrudButtons;
//        private System.Windows.Forms.Button buttonCreate;
//        private System.Windows.Forms.Button buttonUpdate;
//        private System.Windows.Forms.Button buttonDelete;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResultButtons;
//        private System.Windows.Forms.Button buttonOk;
//        private System.Windows.Forms.Button buttonCancel;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTesting;
//        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteAll;
//    }
//}