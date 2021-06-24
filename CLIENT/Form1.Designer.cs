namespace CLIENT
{
    partial class Form1
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.displayInput = new System.Windows.Forms.RichTextBox();
            this.viewTypeBtn = new System.Windows.Forms.Button();
            this.viewMeaningBtn = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.searchedList = new System.Windows.Forms.ListView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportExcelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LightCoral;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 125);
            button1.TabIndex = 3;
            button1.Text = "  Online   dictionary";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(220, 237);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(701, 301);
            this.webBrowser1.TabIndex = 11;
            // 
            // displayInput
            // 
            this.displayInput.BackColor = System.Drawing.Color.White;
            this.displayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInput.Enabled = false;
            this.displayInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInput.Location = new System.Drawing.Point(220, 165);
            this.displayInput.Name = "displayInput";
            this.displayInput.Size = new System.Drawing.Size(476, 42);
            this.displayInput.TabIndex = 12;
            this.displayInput.Text = "";
            // 
            // viewTypeBtn
            // 
            this.viewTypeBtn.BackColor = System.Drawing.Color.White;
            this.viewTypeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewTypeBtn.FlatAppearance.BorderSize = 0;
            this.viewTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTypeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTypeBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.viewTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewTypeBtn.Image")));
            this.viewTypeBtn.Location = new System.Drawing.Point(0, 181);
            this.viewTypeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewTypeBtn.Name = "viewTypeBtn";
            this.viewTypeBtn.Size = new System.Drawing.Size(200, 51);
            this.viewTypeBtn.TabIndex = 5;
            this.viewTypeBtn.Text = "   View word type";
            this.viewTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewTypeBtn.UseVisualStyleBackColor = false;
            this.viewTypeBtn.Click += new System.EventHandler(this.viewTypeBtn_Click);
            // 
            // viewMeaningBtn
            // 
            this.viewMeaningBtn.BackColor = System.Drawing.Color.White;
            this.viewMeaningBtn.FlatAppearance.BorderSize = 0;
            this.viewMeaningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMeaningBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMeaningBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.viewMeaningBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewMeaningBtn.Image")));
            this.viewMeaningBtn.Location = new System.Drawing.Point(0, 125);
            this.viewMeaningBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewMeaningBtn.Name = "viewMeaningBtn";
            this.viewMeaningBtn.Size = new System.Drawing.Size(200, 51);
            this.viewMeaningBtn.TabIndex = 4;
            this.viewMeaningBtn.Text = "  View meaning";
            this.viewMeaningBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewMeaningBtn.UseVisualStyleBackColor = false;
            this.viewMeaningBtn.Click += new System.EventHandler(this.viewMeaningBtn_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(459, 19);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(170, 32);
            this.tbMessage.TabIndex = 1;
            // 
            // searchedList
            // 
            this.searchedList.BackColor = System.Drawing.SystemColors.Window;
            this.searchedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.searchedList.Location = new System.Drawing.Point(26, 289);
            this.searchedList.Name = "searchedList";
            this.searchedList.Size = new System.Drawing.Size(174, 247);
            this.searchedList.TabIndex = 3;
            this.searchedList.UseCompatibleStateImageBehavior = false;
            this.searchedList.View = System.Windows.Forms.View.List;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatAppearance.BorderSize = 2;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(641, 19);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(84, 32);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exportExcelBtn);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(this.viewMeaningBtn);
            this.panel1.Controls.Add(this.searchedList);
            this.panel1.Controls.Add(this.viewTypeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 539);
            this.panel1.TabIndex = 14;
            // 
            // exportExcelBtn
            // 
            this.exportExcelBtn.BackColor = System.Drawing.Color.White;
            this.exportExcelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exportExcelBtn.FlatAppearance.BorderSize = 0;
            this.exportExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportExcelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportExcelBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exportExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportExcelBtn.Image")));
            this.exportExcelBtn.Location = new System.Drawing.Point(0, 235);
            this.exportExcelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.Size = new System.Drawing.Size(200, 51);
            this.exportExcelBtn.TabIndex = 6;
            this.exportExcelBtn.Text = "   Export to Excel";
            this.exportExcelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportExcelBtn.UseVisualStyleBackColor = false;
            this.exportExcelBtn.Click += new System.EventHandler(this.exportExcelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.tbMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(202, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 72);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "       Originally created by team 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Word details";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.SpringGreen;
            this.radioButton1.Location = new System.Drawing.Point(3, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayInput);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.Color.White;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox displayInput;
        private System.Windows.Forms.Button viewTypeBtn;
        private System.Windows.Forms.Button viewMeaningBtn;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListView searchedList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exportExcelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

