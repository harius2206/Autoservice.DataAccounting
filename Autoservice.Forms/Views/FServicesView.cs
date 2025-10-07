//using Common.Processing.Types;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Autoservice.Forms.Views;

//namespace Autoservice.Forms.Views
//{
//    public partial class FServicesView : Form
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
//            checkBoxName.Enabled = !ReadOnly;
//            textBoxName.ReadOnly = ReadOnly;
//            maskedTextBoxPrice.ReadOnly = ReadOnly;
//            numericUpDownTime.ReadOnly = ReadOnly;
//            numericUpDownWarranty.ReadOnly = ReadOnly;
//        }

//        public FServicesView()
//        {
//            InitializeComponent();
//            Title = "Послуги";
//            ClearData();
//            SetCrudMode(CrudMode.Reading);
//            SetControlsState();
//        }

//        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void FServicesView_Load(object sender, EventArgs e)
//        {

//        }
//        public string Title
//        {
//            get { return this.Text; }
//            set { this.Text = value; }
//        }
//        private void ClearData()
//        {
//            textBoxName.Text = "";
//            maskedTextBoxPrice.Text = "";
//            numericUpDownTime.Text = "";
//            numericUpDownWarranty.Text = "";
//        }

//        private void buttonCancel_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
