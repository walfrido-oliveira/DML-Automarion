using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Walfrido.DML.Automation.View
{
    public partial class MainWindows : Form
    {
        private Model.IParams paramsValue;
        private Model.Dao.IURL url;
        private Controller.IDMLController dml;
        private Controller.IColumnController columns;

        private Boolean drag;
        private int mouseX;
        private int mouseY;

        private int itemIdex;

        public MainWindows()
        {
            InitializeComponent();
            comboBoxTipo.DataSource = Enum.GetValues(typeof(Model.Types.DML));
        }

        private Boolean IsNullOrWhiteSpace()
        {
            return string.IsNullOrWhiteSpace(textBoxTable.Text) || string.IsNullOrWhiteSpace(textBoxParamName.Text) ||
                   comboBoxTipo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxDataBase.Text) ||
                   string.IsNullOrWhiteSpace(textBoxHostname.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                   string.IsNullOrWhiteSpace(textBoxPort.Text) || string.IsNullOrWhiteSpace(textBoxUser.Text) ||
                   (comboBoxTipo.SelectedIndex == ((int)Model.Types.DML.UPDATE) - 1 && dataGridViewConditions.RowCount == 0);
        }

        private void ConfURL()
        {
            url = new Model.Dao.URL();
            url.DataBase = textBoxDataBase.Text;
            url.Hostname = textBoxHostname.Text;
            url.Password = textBoxPassword.Text;
            url.Port = textBoxPort.Text;
            url.User = textBoxUser.Text;
        }

        private void ConfSelectColumns()
        {
            System.Collections.Generic.List<Model.IColumn> columns = new System.Collections.Generic.List<Model.IColumn>();
            foreach (Model.IColumn item in listBoxColumns.SelectedItems)
            {
                columns.Add(item);
            }
            if(paramsValue != null) paramsValue.Columns = new Model.Columns(columns, textBoxParamName.Text);
        }

        private void ConfResult()
        {
            if (comboBoxTipo.SelectedItem != null && dml != null)
            {
                switch ((Model.Types.DML)Enum.Parse(typeof(Model.Types.DML), comboBoxTipo.SelectedItem.ToString()))
                {
                    case Model.Types.DML.INSERT:
                        textBoxResult.Text = dml.GetQuery();
                        break;
                    case Model.Types.DML.UPDATE:
                        Controller.IUpdateController dmlUpdate = (Controller.IUpdateController)dml;
                        if(dmlUpdate.ParamValues.Conditions != null) textBoxResult.Text = dml.GetQuery();
                        break;
                    case Model.Types.DML.DELETE:

                        break;
                    case Model.Types.DML.SELECT:

                        break;
                    default:

                        break;
                }
            }
        }

        private void ConfParamns()
        {
            if (comboBoxTipo.SelectedItem != null && !string.IsNullOrWhiteSpace(textBoxTable.Text) &&
                !string.IsNullOrWhiteSpace(textBoxParamName.Text))
            {
                switch ((Model.Types.DML)Enum.Parse(typeof(Model.Types.DML), comboBoxTipo.SelectedItem.ToString()))
                {
                    case Model.Types.DML.INSERT:
                        paramsValue = new Model.Params();
                        paramsValue.Columns = new Model.Columns(columns.GetColumns(textBoxTable.Text),textBoxParamName.Text);
                        paramsValue.TableName = textBoxTable.Text;
                        dml = new Controller.InsertController(paramsValue);
                        break;
                    case Model.Types.DML.UPDATE:
                        break;
                    case Model.Types.DML.DELETE:

                        break;
                    case Model.Types.DML.SELECT:

                        break;
                    default:

                        break;
                }
            }
        }

        private void ConfCheckedListBox()
        {
            if (url != null && !string.IsNullOrWhiteSpace(textBoxTable.Text))
            {
                listBoxColumns.Items.Clear();
                columns = new Controller.ColumnsController(url);
                listBoxColumns.Items.AddRange(columns.GetColumns(textBoxTable.Text).ToArray());
                SelectAllCheckBoxes(true);
            }
        }

        private void ConfForm()
        {
            if(comboBoxTipo.SelectedItem != null)
            {
                switch ((Model.Types.DML)Enum.Parse(typeof(Model.Types.DML), comboBoxTipo.SelectedItem.ToString()))
                {
                    case Model.Types.DML.INSERT:
                        dataGridViewConditions.Visible = false;
                        listBoxColumns.Size = new System.Drawing.Size(843, 317);
                        break;
                    case Model.Types.DML.UPDATE:
                        dataGridViewConditions.Visible = true;
                        listBoxColumns.Size = new System.Drawing.Size(421, 317);
                        break;
                    case Model.Types.DML.DELETE:
                        dataGridViewConditions.Visible = false;
                        listBoxColumns.Size = new System.Drawing.Size(843, 317);
                        break;
                    case Model.Types.DML.SELECT:
                        dataGridViewConditions.Visible = false;
                        listBoxColumns.Size = new System.Drawing.Size(843, 317);
                        break;
                    default:
                        dataGridViewConditions.Visible = false;
                        listBoxColumns.Size = new System.Drawing.Size(843, 317);
                        break;
                }
            }
        }

        private void SelectAllCheckBoxes(bool checkThem)
        {
            for(int i = 0; i < listBoxColumns.Items.Count; i++)
            {
                listBoxColumns.SetSelected(i, checkThem);
            }
        }

        private void buttonGetQuery_Click(object sender, EventArgs e)
        {
            ConfParamns();
            ConfSelectColumns();
            ConfResult();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MainWindows_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouseX = Cursor.Position.X - Left;
            mouseY = Cursor.Position.Y - Top;
        }

        private void MainWindows_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mouseY;
                Left = Cursor.Position.X - mouseX;
            }
        }

        private void MainWindows_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfForm();
            ConfURL();
            ConfCheckedListBox();
        }

        private void checkedListBoxColumns_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewConditions_DragDrop(object sender, DragEventArgs e)
        {
            Model.IParamsUpdate paramUpdate;
            Model.ICondition condition = new Model.Condition();

            if (paramsValue != null)
            {
                paramUpdate = (Model.IParamsUpdate)paramsValue;
            }
            else
            {
                paramUpdate = new Model.ParamsUpdate();
                paramUpdate.Columns = new Model.Columns(columns.GetColumns(textBoxTable.Text), textBoxParamName.Text);
                paramUpdate.TableName = textBoxTable.Text;
            }

            if (paramUpdate.Conditions.ConditionList.Count >= 1)
            {
                LogicalOperatorWIndows logicalOperatorWindows = new LogicalOperatorWIndows();
                if (logicalOperatorWindows.ShowDialog() == DialogResult.OK)
                {
                    condition.LogicalOperator = logicalOperatorWindows.GetSelectedOperator();
                }
            }

            OperatorWindows operatorWindows = new OperatorWindows();
            if(operatorWindows.ShowDialog() == DialogResult.OK)
            {
                condition.Column = (Model.Column)e.Data.GetData(typeof(Model.Column));
                condition.Operator = operatorWindows.GetSelectedOperator();
                paramUpdate.Conditions.ConditionList.Add(condition);


                dml = new Controller.UpdateController(paramUpdate);

                paramsValue = paramUpdate;

                dataGridViewConditions.Rows.Add(condition.Column, condition.Operator.OperatorValue);
            }
        }

        private void dataGridViewConditions_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Model.Column)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBoxColumns_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            itemIdex = listBox.IndexFromPoint(e.X, e.Y);
            if (itemIdex >= 0 && e.Button == MouseButtons.Left)
            {
                Model.IColumn column = (Model.IColumn)listBox.Items[itemIdex];
                listBox.DoDragDrop(column, DragDropEffects.Copy);
            }
        }

        //global brushes with ordinary/selected colors
        private SolidBrush reportsForegroundBrushSelected = new SolidBrush(Color.White);
        private SolidBrush reportsForegroundBrush = new SolidBrush(Color.Black);
        private SolidBrush reportsBackgroundBrushSelected = new SolidBrush(Color.FromKnownColor(KnownColor.Silver));
        private SolidBrush reportsBackgroundBrush1 = new SolidBrush(Color.White);
        private SolidBrush reportsBackgroundBrush2 = new SolidBrush(Color.Gray);
        private void listBoxColumns_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < listBoxColumns.Items.Count)
            {
                string text = listBoxColumns.Items[index].ToString();
                Graphics g = e.Graphics;

                //background:
                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = reportsBackgroundBrushSelected;
                else if ((index % 2) == 0)
                    backgroundBrush = reportsBackgroundBrush1;
                else
                    backgroundBrush = reportsBackgroundBrush2;
                g.FillRectangle(backgroundBrush, e.Bounds);

                //text:
                SolidBrush foregroundBrush = (selected) ? reportsForegroundBrushSelected : reportsForegroundBrush;
                g.DrawString(text, e.Font, foregroundBrush, listBoxColumns.GetItemRectangle(index).Location);
            }

            e.DrawFocusRectangle();
        }
    }
}
