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
            this.searchedList = new System.Windows.Forms.ListView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectBtn = new System.Windows.Forms.Button();
            this.wordListTitle = new System.Windows.Forms.Button();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.exportExcelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.wordDetail = new System.Windows.Forms.Label();
            this.languageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
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
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            button1.Size = new System.Drawing.Size(267, 154);
            button1.TabIndex = 3;
            button1.Text = "Online   dictionary";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.webBrowser1.Location = new System.Drawing.Point(293, 279);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(935, 432);
            this.webBrowser1.TabIndex = 11;
            // 
            // displayInput
            // 
            this.displayInput.BackColor = System.Drawing.Color.White;
            this.displayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInput.Enabled = false;
            this.displayInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayInput.Location = new System.Drawing.Point(293, 212);
            this.displayInput.Margin = new System.Windows.Forms.Padding(4);
            this.displayInput.Multiline = false;
            this.displayInput.Name = "displayInput";
            this.displayInput.Size = new System.Drawing.Size(635, 52);
            this.displayInput.TabIndex = 12;
            this.displayInput.Text = "";
            // 
            // viewTypeBtn
            // 
            this.viewTypeBtn.BackColor = System.Drawing.Color.White;
            this.viewTypeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewTypeBtn.FlatAppearance.BorderSize = 0;
            this.viewTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTypeBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTypeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewTypeBtn.Image")));
            this.viewTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTypeBtn.Location = new System.Drawing.Point(19, 274);
            this.viewTypeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewTypeBtn.Name = "viewTypeBtn";
            this.viewTypeBtn.Size = new System.Drawing.Size(248, 57);
            this.viewTypeBtn.TabIndex = 5;
            this.viewTypeBtn.Text = " View word type";
            this.viewTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewTypeBtn.UseVisualStyleBackColor = false;
            this.viewTypeBtn.Click += new System.EventHandler(this.viewTypeBtn_Click);
            // 
            // viewMeaningBtn
            // 
            this.viewMeaningBtn.BackColor = System.Drawing.Color.White;
            this.viewMeaningBtn.FlatAppearance.BorderSize = 0;
            this.viewMeaningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMeaningBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMeaningBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewMeaningBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewMeaningBtn.Image")));
            this.viewMeaningBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMeaningBtn.Location = new System.Drawing.Point(19, 218);
            this.viewMeaningBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewMeaningBtn.Name = "viewMeaningBtn";
            this.viewMeaningBtn.Size = new System.Drawing.Size(248, 57);
            this.viewMeaningBtn.TabIndex = 4;
            this.viewMeaningBtn.Text = " View meaning";
            this.viewMeaningBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMeaningBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewMeaningBtn.UseVisualStyleBackColor = false;
            this.viewMeaningBtn.Click += new System.EventHandler(this.viewMeaningBtn_Click);
            // 
            // searchedList
            // 
            this.searchedList.BackColor = System.Drawing.Color.White;
            this.searchedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchedList.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchedList.HideSelection = false;
            this.searchedList.Location = new System.Drawing.Point(19, 448);
            this.searchedList.Margin = new System.Windows.Forms.Padding(4);
            this.searchedList.Name = "searchedList";
            this.searchedList.Size = new System.Drawing.Size(227, 279);
            this.searchedList.TabIndex = 3;
            this.searchedList.UseCompatibleStateImageBehavior = false;
            this.searchedList.View = System.Windows.Forms.View.List;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.searchBtn.Location = new System.Drawing.Point(683, 18);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 47);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.connectBtn);
            this.panel1.Controls.Add(this.wordListTitle);
            this.panel1.Controls.Add(this.serverIP);
            this.panel1.Controls.Add(this.exportExcelBtn);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(this.viewMeaningBtn);
            this.panel1.Controls.Add(this.searchedList);
            this.panel1.Controls.Add(this.viewTypeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 743);
            this.panel1.TabIndex = 14;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.White;
            this.connectBtn.FlatAppearance.BorderSize = 0;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.connectBtn.Location = new System.Drawing.Point(209, 165);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(53, 43);
            this.connectBtn.TabIndex = 17;
            this.connectBtn.Text = "OK";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // wordListTitle
            // 
            this.wordListTitle.BackColor = System.Drawing.Color.White;
            this.wordListTitle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.wordListTitle.FlatAppearance.BorderSize = 0;
            this.wordListTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordListTitle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordListTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordListTitle.Image = ((System.Drawing.Image)(resources.GetObject("wordListTitle.Image")));
            this.wordListTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wordListTitle.Location = new System.Drawing.Point(19, 388);
            this.wordListTitle.Margin = new System.Windows.Forms.Padding(0);
            this.wordListTitle.Name = "wordListTitle";
            this.wordListTitle.Size = new System.Drawing.Size(248, 57);
            this.wordListTitle.TabIndex = 7;
            this.wordListTitle.Text = " Searched list";
            this.wordListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wordListTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wordListTitle.UseVisualStyleBackColor = false;
            // 
            // serverIP
            // 
            this.serverIP.BackColor = System.Drawing.Color.White;
            this.serverIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIP.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.serverIP.Location = new System.Drawing.Point(19, 167);
            this.serverIP.Margin = new System.Windows.Forms.Padding(4);
            this.serverIP.Multiline = true;
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(182, 36);
            this.serverIP.TabIndex = 16;
            this.serverIP.Text = "Server IP";
            // 
            // exportExcelBtn
            // 
            this.exportExcelBtn.BackColor = System.Drawing.Color.White;
            this.exportExcelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exportExcelBtn.FlatAppearance.BorderSize = 0;
            this.exportExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportExcelBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportExcelBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exportExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportExcelBtn.Image")));
            this.exportExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportExcelBtn.Location = new System.Drawing.Point(19, 331);
            this.exportExcelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.Size = new System.Drawing.Size(248, 57);
            this.exportExcelBtn.TabIndex = 6;
            this.exportExcelBtn.Text = " Export to Excel";
            this.exportExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportExcelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportExcelBtn.UseVisualStyleBackColor = false;
            this.exportExcelBtn.Click += new System.EventHandler(this.exportExcelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.tbMessage);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 89);
            this.panel2.TabIndex = 15;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(316, 18);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Multiline = false;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(343, 47);
            this.tbMessage.TabIndex = 16;
            this.tbMessage.TabStop = false;
            this.tbMessage.Text = "";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Honeydew;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.DimGray;
            this.stopBtn.Location = new System.Drawing.Point(815, 18);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(112, 47);
            this.stopBtn.TabIndex = 15;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // wordDetail
            // 
            this.wordDetail.AutoSize = true;
            this.wordDetail.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDetail.ForeColor = System.Drawing.Color.White;
            this.wordDetail.Location = new System.Drawing.Point(281, 146);
            this.wordDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordDetail.Name = "wordDetail";
            this.wordDetail.Size = new System.Drawing.Size(289, 62);
            this.wordDetail.TabIndex = 15;
            this.wordDetail.Text = "Word details";
            // 
            // languageBtn
            // 
            this.languageBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.languageBtn.FlatAppearance.BorderSize = 0;
            this.languageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.languageBtn.Location = new System.Drawing.Point(1157, 101);
            this.languageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.languageBtn.Name = "languageBtn";
            this.languageBtn.Size = new System.Drawing.Size(71, 43);
            this.languageBtn.TabIndex = 17;
            this.languageBtn.Text = "Vie";
            this.languageBtn.UseVisualStyleBackColor = false;
            this.languageBtn.Click += new System.EventHandler(this.languageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(288, 722);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "[[NT106.L21] - Nhóm 8 - Thanh Hậu, Duy Tùng, Quang Linh, Trọng Nhân ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1045, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "add new word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageBtn);
            this.Controls.Add(this.wordDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayInput);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox displayInput;
        private System.Windows.Forms.Button viewTypeBtn;
        private System.Windows.Forms.Button viewMeaningBtn;
        private System.Windows.Forms.ListView searchedList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exportExcelBtn;
        private System.Windows.Forms.Label wordDetail;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button wordListTitle;
        private System.Windows.Forms.RichTextBox tbMessage;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button languageBtn;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
    }
}

