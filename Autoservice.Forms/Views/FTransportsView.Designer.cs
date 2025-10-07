//namespace Autoservice.Forms.Views
//{
//    partial class FTransportsView
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
//            this.labelModel = new System.Windows.Forms.Label();
//            this.labelMark = new System.Windows.Forms.Label();
//            this.labelNumb = new System.Windows.Forms.Label();
//            this.maskedTextBoxNumb = new System.Windows.Forms.MaskedTextBox();
//            this.labelYear = new System.Windows.Forms.Label();
//            this.labelVlasnik = new System.Windows.Forms.Label();
//            this.textBoxMark = new System.Windows.Forms.TextBox();
//            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
//            this.textBoxModel = new System.Windows.Forms.TextBox();
//            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
//            this.checkBoxVlasnik = new System.Windows.Forms.CheckBox();
//            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
//            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemDataTesting = new System.Windows.Forms.ToolStripMenuItem();
//            this.ToolStripMenuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
//            this.splitContainer1.Panel1.SuspendLayout();
//            this.splitContainer1.Panel2.SuspendLayout();
//            this.splitContainer1.SuspendLayout();
//            this.flowLayoutPanelButtons.SuspendLayout();
//            this.flowLayoutPanelCrudButtons.SuspendLayout();
//            this.flowLayoutPanelResultButtons.SuspendLayout();
//            this.tableLayoutPanelControls.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
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
//            this.splitContainer1.Size = new System.Drawing.Size(871, 400);
//            this.splitContainer1.SplitterDistance = 373;
//            this.splitContainer1.TabIndex = 8;
//            // 
//            // listBoxKeys
//            // 
//            this.listBoxKeys.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.listBoxKeys.FormattingEnabled = true;
//            this.listBoxKeys.ItemHeight = 16;
//            this.listBoxKeys.Location = new System.Drawing.Point(0, 0);
//            this.listBoxKeys.Name = "listBoxKeys";
//            this.listBoxKeys.Size = new System.Drawing.Size(373, 400);
//            this.listBoxKeys.TabIndex = 0;
//            this.listBoxKeys.SelectedIndexChanged += new System.EventHandler(this.listBoxKeys_SelectedIndexChanged);
//            // 
//            // flowLayoutPanelButtons
//            // 
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelCrudButtons);
//            this.flowLayoutPanelButtons.Controls.Add(this.flowLayoutPanelResultButtons);
//            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 334);
//            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
//            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(494, 66);
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
//            this.tableLayoutPanelControls.Controls.Add(this.labelModel, 0, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.labelMark, 0, 1);
//            this.tableLayoutPanelControls.Controls.Add(this.labelNumb, 0, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.maskedTextBoxNumb, 1, 0);
//            this.tableLayoutPanelControls.Controls.Add(this.labelYear, 0, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.labelVlasnik, 0, 4);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxMark, 1, 1);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxVlasnik, 1, 4);
//            this.tableLayoutPanelControls.Controls.Add(this.textBoxModel, 1, 2);
//            this.tableLayoutPanelControls.Controls.Add(this.numericUpDownYear, 1, 3);
//            this.tableLayoutPanelControls.Controls.Add(this.checkBoxVlasnik, 2, 4);
//            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Top;
//            this.tableLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
//            this.tableLayoutPanelControls.Margin = new System.Windows.Forms.Padding(2);
//            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
//            this.tableLayoutPanelControls.RowCount = 5;
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
//            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
//            this.tableLayoutPanelControls.Size = new System.Drawing.Size(494, 333);
//            this.tableLayoutPanelControls.TabIndex = 0;
//            // 
//            // labelModel
//            // 
//            this.labelModel.AutoSize = true;
//            this.labelModel.Location = new System.Drawing.Point(3, 124);
//            this.labelModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelModel.Name = "labelModel";
//            this.labelModel.Size = new System.Drawing.Size(57, 16);
//            this.labelModel.TabIndex = 17;
//            this.labelModel.Text = "Модель";
//            // 
//            // labelMark
//            // 
//            this.labelMark.AutoSize = true;
//            this.labelMark.Location = new System.Drawing.Point(3, 64);
//            this.labelMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelMark.Name = "labelMark";
//            this.labelMark.Size = new System.Drawing.Size(49, 16);
//            this.labelMark.TabIndex = 14;
//            this.labelMark.Text = "Марка";
//            // 
//            // labelNumb
//            // 
//            this.labelNumb.AutoSize = true;
//            this.labelNumb.Location = new System.Drawing.Point(3, 4);
//            this.labelNumb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelNumb.Name = "labelNumb";
//            this.labelNumb.Size = new System.Drawing.Size(103, 16);
//            this.labelNumb.TabIndex = 13;
//            this.labelNumb.Text = "Номер машини";
//            this.labelNumb.Click += new System.EventHandler(this.labelNumb_Click);
//            // 
//            // maskedTextBoxNumb
//            // 
//            this.maskedTextBoxNumb.Location = new System.Drawing.Point(112, 3);
//            this.maskedTextBoxNumb.Mask = "AA 0000 AA";
//            this.maskedTextBoxNumb.Name = "maskedTextBoxNumb";
//            this.maskedTextBoxNumb.Size = new System.Drawing.Size(100, 22);
//            this.maskedTextBoxNumb.TabIndex = 12;
//            // 
//            // labelYear
//            // 
//            this.labelYear.AutoSize = true;
//            this.labelYear.Location = new System.Drawing.Point(3, 204);
//            this.labelYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelYear.Name = "labelYear";
//            this.labelYear.Size = new System.Drawing.Size(26, 16);
//            this.labelYear.TabIndex = 15;
//            this.labelYear.Text = "Рік";
//            // 
//            // labelVlasnik
//            // 
//            this.labelVlasnik.AutoSize = true;
//            this.labelVlasnik.Location = new System.Drawing.Point(3, 283);
//            this.labelVlasnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
//            this.labelVlasnik.Name = "labelVlasnik";
//            this.labelVlasnik.Size = new System.Drawing.Size(62, 16);
//            this.labelVlasnik.TabIndex = 16;
//            this.labelVlasnik.Text = "Власник";
//            // 
//            // textBoxMark
//            // 
//            this.textBoxMark.Location = new System.Drawing.Point(112, 63);
//            this.textBoxMark.Name = "textBoxMark";
//            this.textBoxMark.Size = new System.Drawing.Size(100, 22);
//            this.textBoxMark.TabIndex = 18;
//            // 
//            // textBoxVlasnik
//            // 
//            this.textBoxVlasnik.Location = new System.Drawing.Point(112, 282);
//            this.textBoxVlasnik.Name = "textBoxVlasnik";
//            this.textBoxVlasnik.Size = new System.Drawing.Size(100, 22);
//            this.textBoxVlasnik.TabIndex = 19;
//            // 
//            // textBoxModel
//            // 
//            this.textBoxModel.Location = new System.Drawing.Point(112, 123);
//            this.textBoxModel.Name = "textBoxModel";
//            this.textBoxModel.Size = new System.Drawing.Size(100, 22);
//            this.textBoxModel.TabIndex = 20;
//            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
//            // 
//            // numericUpDownYear
//            // 
//            this.numericUpDownYear.Location = new System.Drawing.Point(112, 203);
//            this.numericUpDownYear.Maximum = new decimal(new int[] {
//            2025,
//            0,
//            0,
//            0});
//            this.numericUpDownYear.Minimum = new decimal(new int[] {
//            1950,
//            0,
//            0,
//            0});
//            this.numericUpDownYear.Name = "numericUpDownYear";
//            this.numericUpDownYear.Size = new System.Drawing.Size(120, 22);
//            this.numericUpDownYear.TabIndex = 21;
//            this.numericUpDownYear.Value = new decimal(new int[] {
//            1950,
//            0,
//            0,
//            0});
//            // 
//            // checkBoxVlasnik
//            // 
//            this.checkBoxVlasnik.Appearance = System.Windows.Forms.Appearance.Button;
//            this.checkBoxVlasnik.AutoSize = true;
//            this.checkBoxVlasnik.Location = new System.Drawing.Point(465, 284);
//            this.checkBoxVlasnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 7);
//            this.checkBoxVlasnik.Name = "checkBoxVlasnik";
//            this.checkBoxVlasnik.Size = new System.Drawing.Size(26, 26);
//            this.checkBoxVlasnik.TabIndex = 8;
//            this.checkBoxVlasnik.Text = "...";
//            this.checkBoxVlasnik.UseVisualStyleBackColor = true;
//            // 
//            // statusStrip1
//            // 
//            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripStatusLabelMessage});
//            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
//            this.statusStrip1.Name = "statusStrip1";
//            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
//            this.statusStrip1.TabIndex = 7;
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
//            this.menuStrip1.Size = new System.Drawing.Size(871, 28);
//            this.menuStrip1.TabIndex = 6;
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
//            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
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
//            // ToolStripMenuItemDeleteAll
//            // 
//            this.ToolStripMenuItemDeleteAll.Name = "ToolStripMenuItemDeleteAll";
//            this.ToolStripMenuItemDeleteAll.Size = new System.Drawing.Size(242, 26);
//            this.ToolStripMenuItemDeleteAll.Text = "Видалити усі дані";
//            this.ToolStripMenuItemDeleteAll.Click += new System.EventHandler(this.ToolStripMenuItemDeleteAll_Click);
//            // 
//            // FTransportsView
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(871, 450);
//            this.Controls.Add(this.splitContainer1);
//            this.Controls.Add(this.statusStrip1);
//            this.Controls.Add(this.menuStrip1);
//            this.Name = "FTransportsView";
//            this.Text = "FTransportsView";
//            this.Load += new System.EventHandler(this.FTransportsView_Load);
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
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
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
//        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumb;
//        private System.Windows.Forms.StatusStrip statusStrip1;
//        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSave;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemData;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTesting;
//        private System.Windows.Forms.Label labelNumb;
//        private System.Windows.Forms.Label labelModel;
//        private System.Windows.Forms.Label labelMark;
//        private System.Windows.Forms.Label labelYear;
//        private System.Windows.Forms.Label labelVlasnik;
//        private System.Windows.Forms.TextBox textBoxMark;
//        private System.Windows.Forms.TextBox textBoxVlasnik;
//        private System.Windows.Forms.TextBox textBoxModel;
//        private System.Windows.Forms.NumericUpDown numericUpDownYear;
//        private System.Windows.Forms.CheckBox checkBoxVlasnik;
//        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteAll;
//    }
//}