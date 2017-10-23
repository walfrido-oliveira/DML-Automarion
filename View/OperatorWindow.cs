using System;
using System.Windows.Forms;

namespace Walfrido.DML.Automation.View
{
    public partial class OperatorWindows : Form
    {
        private Boolean drag;
        private int mouseX;
        private int mouseY;

        public OperatorWindows()
        {
            InitializeComponent();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mouseY;
                Left = Cursor.Position.X - mouseX;
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouseX = Cursor.Position.X - Left;
            mouseY = Cursor.Position.Y - Top;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void comboBoxOperators_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public Model.Operator GetSelectedOperator()
        {
           return new Model.Operator((Model.Types.OPERATOR)comboBoxOperators.SelectedIndex + 1);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxOperators.SelectedIndex == -1) DialogResult = DialogResult.None;
            else DialogResult = DialogResult.OK;
        }
    }
}
