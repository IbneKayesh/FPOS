using System.Windows.Forms;

public static class AioControls
{
    public static void ClearControls(Form frm, string controls)
    {
        string[] ctrls = controls.Split(',');
        foreach (string ctrl in ctrls)
        {
            if (ctrl.StartsWith("txt"))
            {
                TextBox textBox = (TextBox)frm.Controls.Find(ctrl, true)[0];
                textBox.Text = "";
            }
            else if (ctrl.StartsWith("grd"))
            {
                DataGridView grid = (DataGridView)frm.Controls.Find(ctrl, true)[0];
                if (grid != null)
                {
                    foreach (DataGridViewRow dr in grid.Rows)
                    {
                        //dr.Delete(false);
                    }
                }
            }
            //else if (ctrl.StartsWith("cmb"))
            //{
            //    UltraCombo cmb = (UltraCombo)frm.Controls.Find(ctrl, true)[0];
            //    if (cmb != null)
            //    {
            //        cmb.DataSource = null;
            //    }
            //}
            //else if (ctrl.StartsWith("chk"))
            //{
            //    UltraCheckEditor chk = (UltraCheckEditor)frm.Controls.Find(ctrl, true)[0];
            //    if (chk != null)
            //    {
            //        chk.Checked = false;
            //    }
            //}
        }
    }

    public static bool TextBoxIsNullOrWhiteSpace(Form frm, string frmTextBox)
    {
        string[] ctrls = frmTextBox.Split(',');
        foreach (string ctrl in ctrls)
        {
            TextBox textBox = (TextBox)frm.Controls.Find(ctrl, true)[0];
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
        }
        return false;
    }

    public static string TxtFilter(TextBox txtBox)
    {
        return txtBox.Text.Trim().Replace("'", "");
    }
}