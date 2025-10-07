//using Autoservice.UI.Models;
//using Common.Proccesing.Events;
//using Common.Processing.Types;
//using Common.Selection;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Autoservice.Forms.Views
//{
//    public partial class FTransportsView : Form
//    {

//        public CrudMode CrudMode { get; private set; }
//        public bool ReadOnly { get; private set; }
//        private void SetCrudMode(CrudMode mode)
//        {
//            CrudMode = mode;
//            ReadOnly = mode == CrudMode.Reading || mode == CrudMode.Deleting;
//        }
//        private void SetControlsState()
//        {
//            bool browsing = CrudMode == CrudMode.Reading;
//            listBoxKeys.Enabled = browsing;
//            flowLayoutPanelCrudButtons.Visible = browsing;
//            flowLayoutPanelResultButtons.Visible = !browsing;
//            buttonUpdate.Enabled = listBoxKeys.SelectedItems.Count == 1;
//            buttonDelete.Enabled = buttonUpdate.Enabled;
            
//            textBoxMark.ReadOnly = ReadOnly;
//            textBoxModel.ReadOnly = ReadOnly;
//            numericUpDownYear.ReadOnly = ReadOnly;
//            maskedTextBoxNumb.ReadOnly = ReadOnly;
//            checkBoxVlasnik.Enabled = !ReadOnly;
//            textBoxVlasnik.ReadOnly = ReadOnly;
//        }

//        public FTransportsView()
//        {
//            InitializeComponent();
//            Title = "Транспорт";
//            ClearData();
//            SetCrudMode(CrudMode.Reading);
//            SetControlsState();
//        }

//        public string Title
//        {
//            get { return this.Text; }
//            set { this.Text = value; }
//        }
//        private void ClearData()
//        {
//            maskedTextBoxNumb.Text = "";
//            numericUpDownYear.Text = "";
//            textBoxMark.Text = "";
//            textBoxVlasnik.Text = "";
//        }

//        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void textBoxModel_TextChanged(object sender, EventArgs e)
//        {

//        }
//        public event EventHandler<EventArgs> TestingDataCreation;
//        private void FTransportsView_Load(object sender, EventArgs e)
//        {

//        }
//        public void UpdateInfo(List<TransportModel> models)
//        {
//            _models = models;
//            ShowKeys();
//            SetControlsState();
//            if (_models.Count == 0)
//            {
//                ShowStatusMessage("Додайте запис");
//            }
//            else
//            {
//                ShowStatusMessage("Виберіть або додайте запис");
//            }
//        }
//        private void buttonCancel_Click(object sender, EventArgs e)
//        {
//            buttonOk.BackColor = SystemColors.ButtonFace;
//            SetCrudMode(CrudMode.Reading);
//            HandleSelection();
//            SetControlsState();
//            ShowStatusMessage("Операцію відмінено");
//        }

//        private void buttonOk_Click(object sender, EventArgs e)
//        {
//            buttonOk.BackColor = SystemColors.ButtonFace;
//            if (!ReadOnly)
//            {
//                //if (!CheckData()) {
//                //    return;
//                //}
//                ChangeSelectedModel();
//            }
//            OnCrudAction(new CrudActionEventArgs(CrudMode, SelectedModel));
//            SetCrudMode(CrudMode.Reading);
//            SetControlsState();
//            ShowStatusMessage("Операцію підтверджено");
//        }

//        private void buttonDelete_Click(object sender, EventArgs e)
//        {
//            SetCrudMode(CrudMode.Deleting);
//            SetControlsState();
//            ShowStatusMessage("Увага! Підтвердіть або відмініть операцію видалення");
//        }

//        private void buttonUpdate_Click(object sender, EventArgs e)
//        {
//            SetCrudMode(CrudMode.Updating);
//            SetControlsState();
//            ShowStatusMessage("Внесіть зміни у значення полів");
//        }

//        private void buttonCreate_Click(object sender, EventArgs e)
//        {
//            listBoxKeys.SelectedIndex = -1;
//            SelectedModel = new TransportModel();
//            SetCrudMode(CrudMode.Creation);
//            SetControlsState();
//            ShowStatusMessage("Введіть або виберіть значення полів");
//        }

//        private void ToolStripMenuItemDataTesting_Click(object sender, EventArgs e)
//        {
//            if (TestingDataCreation != null)
//            {
//                TestingDataCreation(this, EventArgs.Empty);
//                //SetControlsState();
//            }
//            else
//            {
//                ShowStatusMessage("Команда створення тестових даних не підтримується");
//            }
//        }

//        private void ToolStripMenuItemDeleteAll_Click(object sender, EventArgs e)
//        {
//            _models = null; // Повністю обнуляємо список
//            listBoxKeys.Items.Clear();
//            ClearData();
//            SetControlsState();
//            ShowStatusMessage("Всі дані були видалені");
//        }
//        List<TransportModel> _models;
//        private void ShowStatusMessage(string message)
//        {
//            toolStripStatusLabelMessage.Text = message;
//        }

//        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
//        {
//            Close();
//        }
//        private void HandleSelection()
//        {
//            //throw new NotImplementedException();
//            if (listBoxKeys.SelectedIndex == -1)
//            {
//                SelectedModel = null;
//                ClearData();
//            }
//            else
//            {
//                string key = listBoxKeys.SelectedItem.ToString();
//                SelectedModel = KeyableMethods.GetByKey(_models, key);
//                ShowData();
//            }
//            SetControlsState();

//        }
//        public TransportModel SelectedModel { get; private set; }
//        private void ShowData()
//        {
//            textBoxVlasnik.Text = SelectedModel.OwnerKey;
//            maskedTextBoxNumb.Text = SelectedModel.Number;
//            textBoxModel.Text = SelectedModel.Model;
//            textBoxMark.Text = SelectedModel.Make;

//            // Fix: Accessing the correct property "Year" from the TransportModel class  
//            numericUpDownYear.Value = SelectedModel.Year.HasValue ?
//                SelectedModel.Year.Value : numericUpDownYear.Minimum;
//        }

//        private void labelNumb_Click(object sender, EventArgs e)
//        {

//        }
//        private void ChangeSelectedModel()
//        {
//            SelectedModel.Vlasnik = textBoxVlasnik.Text;
//            SelectedModel.Numb = maskedTextBoxNumb.Text;
//            SelectedModel.Model = textBoxModel.Text;
//            SelectedModel.Mark = textBoxMark.Text;
//            SelectedModel.Year = (int)numericUpDownYear.Value;

//        }
//        protected void OnCrudAction(CrudActionEventArgs eventArgs)
//        {
//            if (CrudAction != null)
//            {
//                CrudAction.Invoke(this, eventArgs);
//            }
//        }

//        public event EventHandler<CrudActionEventArgs> CrudAction;
//        private void ShowKeys()
//        {
//            listBoxKeys.Items.Clear();
//            listBoxKeys.Items.AddRange(KeyableMethods.GetKeys(_models));
//        }

//        private void listBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            HandleSelection();
//        }
//    }
//}
