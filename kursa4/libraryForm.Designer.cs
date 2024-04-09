namespace kursa4
{
    partial class libraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraryForm));
            addBtn = new Button();
            reportAuthor = new Button();
            reportDate = new Button();
            dataBase = new DataGridView();
            input = new RichTextBox();
            connectDB = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataBase).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(278, 536);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(260, 83);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add/Remove book";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // reportAuthor
            // 
            reportAuthor.Location = new Point(544, 536);
            reportAuthor.Name = "reportAuthor";
            reportAuthor.Size = new Size(260, 83);
            reportAuthor.TabIndex = 2;
            reportAuthor.Text = "Book report by authors";
            reportAuthor.UseVisualStyleBackColor = true;
            reportAuthor.Click += reportAuthor_Click;
            // 
            // reportDate
            // 
            reportDate.Location = new Point(810, 536);
            reportDate.Name = "reportDate";
            reportDate.Size = new Size(260, 83);
            reportDate.TabIndex = 3;
            reportDate.Text = "Book report by release date";
            reportDate.UseVisualStyleBackColor = true;
            reportDate.Click += reportDate_Click;
            // 
            // dataBase
            // 
            dataBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBase.Location = new Point(12, 12);
            dataBase.Name = "dataBase";
            dataBase.Size = new Size(651, 350);
            dataBase.TabIndex = 4;
            // 
            // input
            // 
            input.Location = new Point(12, 388);
            input.Name = "input";
            input.Size = new Size(1058, 120);
            input.TabIndex = 5;
            input.Text = "";
            // 
            // connectDB
            // 
            connectDB.Location = new Point(12, 536);
            connectDB.Name = "connectDB";
            connectDB.Size = new Size(260, 83);
            connectDB.TabIndex = 6;
            connectDB.Text = "Connect database";
            connectDB.UseVisualStyleBackColor = true;
            connectDB.Click += connectDB_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(669, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(401, 350);
            textBox1.TabIndex = 7;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // libraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 631);
            Controls.Add(textBox1);
            Controls.Add(connectDB);
            Controls.Add(input);
            Controls.Add(dataBase);
            Controls.Add(reportDate);
            Controls.Add(reportAuthor);
            Controls.Add(addBtn);
            Name = "libraryForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataBase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Button reportAuthor;
        private Button reportDate;
        private DataGridView dataBase;
        private RichTextBox input;
        private Button connectDB;
        private TextBox textBox1;
    }
}
