using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Walfrido.DML.Automation.View
{
    public partial class MainWindow : Form
    {
        private Model.Dao.IURL url;
        private Controller.IDMLController dml;
        private Controller.IColumnController columns;

        private Boolean drag;
        private int mouseX;
        private int mouseY;

        private int itemIdex;

        public MainWindow()
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

        private List<Model.IColumn> GetSelectColumns()
        {
            List<Model.IColumn> columns = new List<Model.IColumn>();
            foreach (Model.IColumn item in listBoxColumns.SelectedItems)
            {
                columns.Add(item);
            }
            return columns;
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
                        Controller.IDeleteController dmlDelete = (Controller.IDeleteController)dml;
                        if (dmlDelete.ParamValues.Conditions != null) textBoxResult.Text = dml.GetQuery();
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
                        Model.IParamsInsert paramsInsert = new Model.ParamsInsert();
                        paramsInsert.ParamName = textBoxParamName.Text;
                        paramsInsert.Columns = new Model.Columns(GetSelectColumns(), textBoxParamName.Text);
                        paramsInsert.TableName = textBoxTable.Text;
                        dml = new Controller.InsertController(paramsInsert);
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
                        DataGridViewConditionsVisible();
                        break;
                    case Model.Types.DML.UPDATE:
                        DataGridViewConditionsVisible(true);
                        break;
                    case Model.Types.DML.DELETE:
                        DataGridViewConditionsVisible(true);
                        break;
                    case Model.Types.DML.SELECT:
                        DataGridViewConditionsVisible();
                        break;
                    default:
                        DataGridViewConditionsVisible();
                        break;
                }
            }
        }

        private void dataGridViewConditions_DragDrop(object sender, DragEventArgs e)
        {
            Model.ICondition condition = new Model.Condition();
            condition.Column = (Model.Column)e.Data.GetData(typeof(Model.Column));
            LogicalOperatorWIndow logicalOperatorWindows = new LogicalOperatorWIndow();
            OperatorWindow operatorWindows = new OperatorWindow();

            switch ((Model.Types.DML)Enum.Parse(typeof(Model.Types.DML), comboBoxTipo.SelectedItem.ToString()))
            {
                case Model.Types.DML.UPDATE:

                    Model.IParamsUpdate paramsUpdate;
                    Controller.IUpdateController updateController = (Controller.IUpdateController)dml;

                    if (updateController != null)
                    {
                        paramsUpdate = updateController.ParamValues;
                    }
                    else
                    {
                        paramsUpdate = new Model.ParamsUpdate();
                        paramsUpdate.Columns = new Model.Columns(GetSelectColumns(), textBoxParamName.Text);
                        paramsUpdate.TableName = textBoxTable.Text;
                        paramsUpdate.ParamName = textBoxParamName.Text;
                        updateController = new Controller.UpdateController(paramsUpdate);
                    }

                    if (paramsUpdate.Conditions.ConditionList.Count >= 1)
                    {
                        if (logicalOperatorWindows.ShowDialog() == DialogResult.OK)
                        {
                            condition.LogicalOperator = logicalOperatorWindows.GetSelectedOperator();
                        }
                    }

                    if (operatorWindows.ShowDialog() == DialogResult.OK)
                    {                     
                        condition.Operator = operatorWindows.GetSelectedOperator();
                        paramsUpdate.Conditions.ConditionList.Add(condition);
                        
                        dml = new Controller.UpdateController(paramsUpdate);

                        dataGridViewConditions.Rows.Add(condition.Column, condition.Operator.OperatorValue);
                    }
                    break;

                case Model.Types.DML.DELETE:
                    Model.IParamsDelete paramsDelete;
                    Controller.IDeleteController deleteController = (Controller.IDeleteController)dml;

                    if (deleteController != null)
                    {
                        paramsDelete = deleteController.ParamValues;
                    }
                    else
                    {
                        paramsDelete = new Model.ParamsDelete();
                        paramsDelete.TableName = textBoxTable.Text;
                        paramsDelete.ParamName = textBoxParamName.Text;
                        deleteController = new Controller.DeleteController(paramsDelete);
                    }

                    if (paramsDelete.Conditions.ConditionList.Count >= 1)
                    {     
                        if (logicalOperatorWindows.ShowDialog() == DialogResult.OK)
                        {
                            condition.LogicalOperator = logicalOperatorWindows.GetSelectedOperator();
                        }
                    }

                   
                    if (operatorWindows.ShowDialog() == DialogResult.OK)
                    {
                        condition.Operator = operatorWindows.GetSelectedOperator();
                        paramsDelete.Conditions.ConditionList.Add(condition);

                        dml = new Controller.DeleteController(paramsDelete);

                        dataGridViewConditions.Rows.Add(condition.Column, condition.Operator.OperatorValue);
                    }
                    break;

                case Model.Types.DML.SELECT:
                    DataGridViewConditionsVisible();
                    break;
                default:
                    DataGridViewConditionsVisible();
                    break;
            }

            logicalOperatorWindows.Dispose();
            operatorWindows.Dispose();

        }

        private void DataGridViewConditionsVisible(bool visible = false)
        {
            if (visible)
            {
                dataGridViewConditions.Visible = true;
                listBoxColumns.Size = new Size(421, 317);
            }
            else
            {
                dataGridViewConditions.Visible = false;
                listBoxColumns.Size = new Size(843, 317);
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
    }
}
