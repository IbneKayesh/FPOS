using System.Windows.Forms;

public class AioMsgBox
{
    public static void Required(string body, string title)
    {
        MessageBox.Show(body + " is requried", title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    public static void Failed(string body, string title)
    {
        MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void Success(string title)
    {
        MessageBox.Show("Request submitted successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}