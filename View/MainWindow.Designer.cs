namespace Walfrido.DML.Automation.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelDML = new System.Windows.Forms.Panel();
            this.listBoxColumns = new System.Windows.Forms.ListBox();
            this.dataGridViewConditions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxParamName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonGetQuery = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDML
            // 
            this.panelDML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDML.Controls.Add(this.listBoxColumns);
            this.panelDML.Controls.Add(this.dataGridViewConditions);
            this.panelDML.Controls.Add(this.label9);
            this.panelDML.Controls.Add(this.comboBoxTipo);
            this.panelDML.Controls.Add(this.label7);
            this.panelDML.Controls.Add(this.textBoxParamName);
            this.panelDML.Controls.Add(this.label6);
            this.panelDML.Controls.Add(this.textBoxTable);
            this.panelDML.Controls.Add(this.textBoxResult);
            this.panelDML.Controls.Add(this.buttonGetQuery);
            this.panelDML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDML.Location = new System.Drawing.Point(3, 3);
            this.panelDML.Name = "panelDML";
            this.panelDML.Size = new System.Drawing.Size(1013, 478);
            this.panelDML.TabIndex = 0;
            // 
            // listBoxColumns
            // 
            this.listBoxColumns.FormattingEnabled = true;
            this.listBoxColumns.Location = new System.Drawing.Point(49, 69);
            this.listBoxColumns.Name = "listBoxColumns";
            this.listBoxColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxColumns.Size = new System.Drawing.Size(421, 316);
            this.listBoxColumns.TabIndex = 19;
            this.listBoxColumns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColumns_MouseDown);
            // 
            // dataGridViewConditions
            // 
            this.dataGridViewConditions.AllowDrop = true;
            this.dataGridViewConditions.AllowUserToAddRows = false;
            this.dataGridViewConditions.AllowUserToDeleteRows = false;
            this.dataGridViewConditions.AllowUserToResizeColumns = false;
            this.dataGridViewConditions.AllowUserToResizeRows = false;
            this.dataGridViewConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConditions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConditions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConditions.Location = new System.Drawing.Point(476, 67);
            this.dataGridViewConditions.MultiSelect = false;
            this.dataGridViewConditions.Name = "dataGridViewConditions";
            this.dataGridViewConditions.ReadOnly = true;
            this.dataGridViewConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConditions.ShowCellErrors = false;
            this.dataGridViewConditions.ShowCellToolTips = false;
            this.dataGridViewConditions.ShowEditingIcon = false;
            this.dataGridViewConditions.ShowRowErrors = false;
            this.dataGridViewConditions.Size = new System.Drawing.Size(416, 317);
            this.dataGridViewConditions.TabIndex = 18;
            this.dataGridViewConditions.Visible = false;
            this.dataGridViewConditions.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewConditions_DragDrop);
            this.dataGridViewConditions.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewConditions_DragOver);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Coluna";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Operador";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTipo.BackColor = System.Drawing.Color.White;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(628, 36);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(264, 21);
            this.comboBoxTipo.TabIndex = 14;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            this.comboBoxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTipo_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name:";
            // 
            // textBoxParamName
            // 
            this.textBoxParamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParamName.Location = new System.Drawing.Point(49, 37);
            this.textBoxParamName.Name = "textBoxParamName";
            this.textBoxParamName.Size = new System.Drawing.Size(536, 20);
            this.textBoxParamName.TabIndex = 11;
            this.textBoxParamName.Text = "param";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tabela:";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTable.Location = new System.Drawing.Point(49, 11);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(843, 20);
            this.textBoxTable.TabIndex = 8;
            this.textBoxTable.Text = "ocorrencia_evidencia";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(49, 390);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(843, 54);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonGetQuery
            // 
            this.buttonGetQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGetQuery.Location = new System.Drawing.Point(434, 450);
            this.buttonGetQuery.Name = "buttonGetQuery";
            this.buttonGetQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonGetQuery.TabIndex = 0;
            this.buttonGetQuery.Text = "Gerar";
            this.buttonGetQuery.UseVisualStyleBackColor = true;
            this.buttonGetQuery.Click += new System.EventHandler(this.buttonGetQuery_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.Location = new System.Drawing.Point(49, 115);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(933, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPort.Location = new System.Drawing.Point(49, 89);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(933, 20);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(49, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(933, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHostname.Location = new System.Drawing.Point(49, 37);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(933, 20);
            this.textBoxHostname.TabIndex = 4;
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataBase.Location = new System.Drawing.Point(49, 11);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(933, 20);
            this.textBoxDataBase.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDML);
            this.tabControl.Controls.Add(this.tabPageConnection);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1027, 510);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.panelDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(1019, 484);
            this.tabPageDML.TabIndex = 0;
            this.tabPageDML.Text = "DML";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.panelConnection);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(1019, 484);
            this.tabPageConnection.TabIndex = 1;
            this.tabPageConnection.Text = "Conexão";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // panelConnection
            // 
            this.panelConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConnection.Controls.Add(this.label5);
            this.panelConnection.Controls.Add(this.label4);
            this.panelConnection.Controls.Add(this.label3);
            this.panelConnection.Controls.Add(this.label2);
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Controls.Add(this.textBoxUser);
            this.panelConnection.Controls.Add(this.textBoxPort);
            this.panelConnection.Controls.Add(this.textBoxPassword);
            this.panelConnection.Controls.Add(this.textBoxHostname);
            this.panelConnection.Controls.Add(this.textBoxDataBase);
            this.panelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnection.Location = new System.Drawing.Point(3, 3);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(1013, 478);
            this.panelConnection.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Porta:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Host:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banco:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(940, 512);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Sair";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 543);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DML Automation";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindows_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindows_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindows_MouseUp);
            this.panelDML.ResumeLayout(false);
            this.panelDML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageDML.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDML;
        private System.Windows.Forms.Button buttonGetQuery;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxParamName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.DataGridView dataGridViewConditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox listBoxColumns;
    }
}

