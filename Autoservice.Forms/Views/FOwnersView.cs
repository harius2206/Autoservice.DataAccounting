//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Common.Processing.Types;
//using Autoservice.UI.Models;
//using Common.Selection;
//using Common.Proccesing.Events;

//namespace Autoservice.Forms.Views
//{
//    public partial class FOwnersView : Form
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
//            checkBoxVlasnik.Enabled = !ReadOnly;
//            textBoxVlasnik.ReadOnly = ReadOnly;
//            maskedTextBoxNumber.ReadOnly = ReadOnly;
//            textBoxEmail.ReadOnly = ReadOnly;
//            textBoxAdress.ReadOnly = ReadOnly;
//            ToolStripMenuItemDataTesting.Enabled = _models == null || _models.Count == 0;
//        }
//        List<OwnerModel> _models;
//        public OwnerModel SelectedModel { get; private set; }
//        private void ShowData()
//        {
//            //throw new NotImplementedException();
//            textBoxVlasnik.Text = SelectedModel.Vlasnik;
//            maskedTextBoxNumber.Text = SelectedModel.Number;
//            textBoxEmail.Text = SelectedModel.Email;
//            textBoxAdress.Text = SelectedModel.Adress;
            
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
//        private void ShowKeys()
//        {
//            listBoxKeys.Items.Clear();
//            listBoxKeys.Items.AddRange(KeyableMethods.GetKeys(_models));
//        }
//        public void UpdateInfo(List<OwnerModel> models)
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


//        public FOwnersView()
//        {
//            InitializeComponent();
//            Title =  "Власники";
//            ClearData();
//            SetCrudMode(CrudMode.Reading);
//            SetControlsState();
//            ShowStatusMessage(" Вікно перегляду та редагування даних про власників ");

//        }
//        public event EventHandler <EventArgs> TestingDataCreation;

//        private void FOwnersView_Load(object sender, EventArgs e)
//        {

//        }

//        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void tableLayoutPanelControls_Paint(object sender, PaintEventArgs e)
//        {

//        }
//        public string Title
//        {
//            get { return this.Text; }
//            set { this.Text = value; }
//        }
//        private void ClearData()
//        {
//            textBoxVlasnik.Text = "";
//            maskedTextBoxNumber.Text = "";
//            textBoxEmail.Text = "";
//            textBoxAdress.Text = "";
//        }
//        private void ShowStatusMessage(string message)
//        {
//            toolStripStatusLabelMessage.Text = message;
//        }

//        private void textBoxVlasnik_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void checkBoxVlasnik_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void maskedTextBoxNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
//        {

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

//        private void listBoxKeys_SelectedIndexChanged_1(object sender, EventArgs e)
//        {
//            HandleSelection();
//        }

//        private void buttonCreate_Click(object sender, EventArgs e)
//        {
//            listBoxKeys.SelectedIndex = -1;
//            SelectedModel = new OwnerModel();
//            SetCrudMode(CrudMode.Creation);
//            SetControlsState();
//            ShowStatusMessage("Введіть або виберіть значення полів");
//        }

//        private void buttonUpdate_Click(object sender, EventArgs e)
//        {
//            SetCrudMode(CrudMode.Updating);
//            SetControlsState();
//            ShowStatusMessage("Внесіть зміни у значення полів");
//        }

//        private void buttonDelete_Click(object sender, EventArgs e)
//        {
//            SetCrudMode(CrudMode.Deleting);
//            SetControlsState();
//            ShowStatusMessage("Увага! Підтвердіть або відмініть операцію видалення");
//        }
//        protected void OnCrudAction(CrudActionEventArgs eventArgs)
//        {
//            if (CrudAction != null)
//            {
//                CrudAction.Invoke(this, eventArgs);
//            }
//        }

//        public event EventHandler<CrudActionEventArgs> CrudAction;
//        private void ChangeSelectedModel()
//        {
//            SelectedModel.Vlasnik = textBoxVlasnik.Text;
//            SelectedModel.Number = maskedTextBoxNumber.Text;
//            SelectedModel.Email = textBoxEmail.Text;
//            SelectedModel.Adress = textBoxAdress.Text;
            
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

//        private void buttonCancel_Click(object sender, EventArgs e)
//        {
//            buttonOk.BackColor = SystemColors.ButtonFace;
//            SetCrudMode(CrudMode.Reading);
//            HandleSelection();
//            SetControlsState();
//            ShowStatusMessage("Операцію відмінено");
//        }
//        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void ToolStripMenuItemDeleteAll_Click(object sender, EventArgs e)
//        {
//            _models = null; // Повністю обнуляємо список
//            listBoxKeys.Items.Clear();
//            ClearData();
//            SetControlsState();
//            ShowStatusMessage("Всі дані були видалені");
//        }
//    }
//}

  

