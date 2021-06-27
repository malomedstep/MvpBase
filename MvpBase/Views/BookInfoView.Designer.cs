
namespace MvpBase.Views
{
    partial class BookInfoView
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
            this.label1 = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._authorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(13, 32);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.ReadOnly = true;
            this._idTextBox.Size = new System.Drawing.Size(258, 23);
            this._idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // _authorTextBox
            // 
            this._authorTextBox.Location = new System.Drawing.Point(13, 81);
            this._authorTextBox.Name = "_authorTextBox";
            this._authorTextBox.ReadOnly = true;
            this._authorTextBox.Size = new System.Drawing.Size(258, 23);
            this._authorTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(12, 129);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.ReadOnly = true;
            this._titleTextBox.Size = new System.Drawing.Size(259, 23);
            this._titleTextBox.TabIndex = 5;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(196, 186);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 6;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // BookInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 223);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._titleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._authorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BookInfoView";
            this.Text = "Book Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _authorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.Button _okButton;
    }
}