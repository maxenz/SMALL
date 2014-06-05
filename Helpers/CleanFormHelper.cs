using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrbaCommerce.Helpers
{
    public class CleanFormHelper
    {
        // --> Limpio los textbox de un formulario
        public void cleanTextBoxes(Form frm,List<TextBox> lst)
        {
            foreach (TextBox t in lst)
            {
                t.Text = "";
            }
        }

        // --> Limpio los combobox de un formulario
        public void cleanComboBoxes(Form frm, List<ComboBox> lst)
        {
            foreach (ComboBox c in lst)
            {
                c.SelectedIndex = 0;
            }
        }

        // --> Obtengo una lista de textbox que hay en un groupbox
        public List<TextBox> collectTextBoxes(Form frm, Control.ControlCollection col)
        {
            List<TextBox> lstTextBox = new List<TextBox>();

            foreach (Control ctrl in col)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtBox = (TextBox)ctrl;
                    lstTextBox.Add(txtBox);
                }
            }

            return lstTextBox;

        }

        // --> Obtengo una lista de combobox que hay en un groupcontrol
        public List<ComboBox> collectComboBoxes(Form frm, Control.ControlCollection col)
        {
            List<ComboBox> lstCombo = new List<ComboBox>();

            foreach (Control ctrl in col)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    lstCombo.Add(cmb);
                }
            }

            return lstCombo;

        }

        // --> Seteo readonly los textboxes
        public void setReadOnlyTextBoxes(Form frm, List<TextBox> lst, bool vBool)
        {
            foreach (TextBox t in lst)
            {
                t.ReadOnly = vBool;
            }

        }

    }
}
