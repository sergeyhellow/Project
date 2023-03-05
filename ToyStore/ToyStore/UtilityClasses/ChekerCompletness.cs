using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore.UtilityClasses
{
    public class ChekerCompletness
    {
        public ChekerCompletness() { }




        public bool ChekDataCompleteness(Form form, string blank_fields)
        {
            foreach (var item in form.Controls)
            {
                if (item is RadioButton rb)
                {
                    if (rb.Checked == false)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is NumericUpDown nud)
                {
                    if (nud == null)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is TextBox tb)
                {
                    if (tb.Text == "")
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }
                }
                else if (item is ComboBox cb)
                {
                    if (cb.Text == "")
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is MaskedTextBox mtb)
                {
                    if (mtb.MaskCompleted==false)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }


            }
            return true;

        }

        public bool ChekDataCompleteness(TabPage tp, string blank_fields)
        {
            foreach (var item in tp.Controls)
            {
                if (item is RadioButton rb)
                {
                    if (rb.Checked == false)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is NumericUpDown nud)
                {
                    if (nud == null)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is TextBox tb)
                {
                    if (tb.Text == "")
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }
                }
                else if (item is ComboBox cb)
                {
                    if (cb.Text == "")
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }
                else if (item is MaskedTextBox mtb)
                {
                    if (mtb.MaskCompleted == false)
                    {
                        MessageBox.Show(blank_fields);
                        return false;
                    }

                }


            }
            return true;

        }



    }
}
