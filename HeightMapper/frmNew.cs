using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TerrainEditor {
    public partial class frmNew : Form {
        public int size;

        public frmNew() {
            InitializeComponent();
        }

        private void frmNew_Load(object sender, EventArgs e) {
            size = 512;
            textBoxSize.Text = size.ToString();
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e) {
            base.OnKeyPress(e);
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;
            string keyInput = e.KeyChar.ToString();
            if (Char.IsDigit(e.KeyChar)) {
                
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) || keyInput.Equals(negativeSign)) {
                
            }
            else if (e.KeyChar == '\b') {
                
            }
            else
                e.Handled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e) {

            if (int.TryParse(textBoxSize.Text, out size)) {
                if (size < 64 || size > 4096)
                    MessageBox.Show("Wrong size!", "Error");
                else
                    DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Wrong size!", "Error");
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
