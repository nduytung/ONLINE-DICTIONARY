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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.searchedList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.RichTextBox();
            this.meanInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.wordType = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.GhostWhite;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(338, 48);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(283, 30);
            this.tbMessage.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.Color.LightSalmon;
            this.btSend.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSend.Location = new System.Drawing.Point(636, 48);
            this.btSend.Margin = new System.Windows.Forms.Padding(0);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(115, 30);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "SEARCH";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // searchedList
            // 
            this.searchedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedList.Enabled = false;
            this.searchedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.searchedList.Location = new System.Drawing.Point(12, 118);
            this.searchedList.Name = "searchedList";
            this.searchedList.Size = new System.Drawing.Size(191, 319);
            this.searchedList.TabIndex = 3;
            this.searchedList.UseCompatibleStateImageBehavior = false;
            this.searchedList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Bungee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIVE DICTIONARY ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeInput
            // 
            this.typeInput.BackColor = System.Drawing.Color.LightBlue;
            this.typeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeInput.Location = new System.Drawing.Point(477, 166);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(274, 42);
            this.typeInput.TabIndex = 5;
            this.typeInput.Text = "";
            // 
            // meanInput
            // 
            this.meanInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanInput.Enabled = false;
            this.meanInput.Location = new System.Drawing.Point(247, 120);
            this.meanInput.Name = "meanInput";
            this.meanInput.Size = new System.Drawing.Size(214, 42);
            this.meanInput.TabIndex = 6;
            this.meanInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bungee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "SEARCH ENTRY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Bungee", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(332, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type some new word ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bungee", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(241, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "MEANING";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(247, 177);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(504, 260);
            this.webBrowser1.TabIndex = 11;
            // 
            // wordType
            // 
            this.wordType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordType.Enabled = false;
            this.wordType.Location = new System.Drawing.Point(488, 120);
            this.wordType.Name = "wordType";
            this.wordType.Size = new System.Drawing.Size(263, 42);
            this.wordType.TabIndex = 12;
            this.wordType.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bungee", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(482, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "TYPE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wordType);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meanInput);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedList);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.ListView searchedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox typeInput;
        private System.Windows.Forms.RichTextBox meanInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox wordType;
        private System.Windows.Forms.Label label5;
    }
}

