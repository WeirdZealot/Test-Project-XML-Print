
namespace Test_Project_XML_Print
{
    partial class PrintForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SBind = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.CreateXML = new System.Windows.Forms.Button();
            this.PrintDoc = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectRow = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.NewName = new System.Windows.Forms.ToolStripTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.docViewer1 = new Test_Project_XML_Print.DocViewer();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(269, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(269, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(535, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(535, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(535, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(535, 209);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(535, 278);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 10;
            // 
            // CreateXML
            // 
            this.CreateXML.Location = new System.Drawing.Point(289, 397);
            this.CreateXML.Name = "CreateXML";
            this.CreateXML.Size = new System.Drawing.Size(147, 23);
            this.CreateXML.TabIndex = 11;
            this.CreateXML.Text = "Создать XML";
            this.CreateXML.UseVisualStyleBackColor = true;
            this.CreateXML.Click += new System.EventHandler(this.CreateXML_Click);
            // 
            // PrintDoc
            // 
            this.PrintDoc.Location = new System.Drawing.Point(492, 397);
            this.PrintDoc.Name = "PrintDoc";
            this.PrintDoc.Size = new System.Drawing.Size(143, 23);
            this.PrintDoc.TabIndex = 12;
            this.PrintDoc.Text = "Распечатать документ";
            this.PrintDoc.UseVisualStyleBackColor = true;
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.ContextMenuStrip = this.ContextMenu;
            this.TableView.Location = new System.Drawing.Point(948, 53);
            this.TableView.Name = "TableView";
            this.TableView.RowTemplate.Height = 24;
            this.TableView.Size = new System.Drawing.Size(240, 150);
            this.TableView.TabIndex = 13;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectRow,
            this.SelectColumn,
            this.NewName});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(181, 73);
            // 
            // SelectRow
            // 
            this.SelectRow.Name = "SelectRow";
            this.SelectRow.Size = new System.Drawing.Size(180, 22);
            this.SelectRow.Text = "Добавить строку";
            this.SelectRow.Click += new System.EventHandler(this.SelectRow_Click);
            // 
            // SelectColumn
            // 
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.Size = new System.Drawing.Size(180, 22);
            this.SelectColumn.Text = "Добавить столбец";
            this.SelectColumn.Click += new System.EventHandler(this.SelectColumn_Click);
            // 
            // NewName
            // 
            this.NewName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 23);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(818, 278);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(475, 186);
            this.elementHost1.TabIndex = 14;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.docViewer1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Правый клик на DataGridView (сверхуэтой надписи) открывает контекстное меню";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.PrintDoc);
            this.Controls.Add(this.CreateXML);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PrintForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.ContextMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SBind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button CreateXML;
        private System.Windows.Forms.Button PrintDoc;
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectRow;
        private System.Windows.Forms.ToolStripMenuItem SelectColumn;
        private System.Windows.Forms.ToolStripTextBox NewName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private DocViewer docViewer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
    }
}

