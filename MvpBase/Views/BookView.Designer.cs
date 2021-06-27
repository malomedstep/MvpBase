
namespace MvpBase
{
    partial class BookView
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this._booksListBox = new System.Windows.Forms.ListBox();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this._authorTextBox = new System.Windows.Forms.TextBox();
            this._addBookButton = new System.Windows.Forms.Button();
            this._removeBookButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(301, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(301, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Author:";
            // 
            // _booksListBox
            // 
            this._booksListBox.FormattingEnabled = true;
            this._booksListBox.ItemHeight = 15;
            this._booksListBox.Location = new System.Drawing.Point(12, 12);
            this._booksListBox.Name = "_booksListBox";
            this._booksListBox.Size = new System.Drawing.Size(283, 424);
            this._booksListBox.TabIndex = 0;
            this._booksListBox.DoubleClick += new System.EventHandler(this.BooksListBox_DoubleClick);
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(301, 30);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.Size = new System.Drawing.Size(272, 23);
            this._titleTextBox.TabIndex = 1;
            // 
            // _authorTextBox
            // 
            this._authorTextBox.Location = new System.Drawing.Point(302, 88);
            this._authorTextBox.Name = "_authorTextBox";
            this._authorTextBox.Size = new System.Drawing.Size(271, 23);
            this._authorTextBox.TabIndex = 4;
            // 
            // _addBookButton
            // 
            this._addBookButton.Location = new System.Drawing.Point(301, 140);
            this._addBookButton.Name = "_addBookButton";
            this._addBookButton.Size = new System.Drawing.Size(272, 23);
            this._addBookButton.TabIndex = 5;
            this._addBookButton.Text = "Add";
            this._addBookButton.UseVisualStyleBackColor = true;
            this._addBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // _removeBookButton
            // 
            this._removeBookButton.Location = new System.Drawing.Point(301, 412);
            this._removeBookButton.Name = "_removeBookButton";
            this._removeBookButton.Size = new System.Drawing.Size(272, 23);
            this._removeBookButton.TabIndex = 6;
            this._removeBookButton.Text = "Remove";
            this._removeBookButton.UseVisualStyleBackColor = true;
            this._removeBookButton.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this._removeBookButton);
            this.Controls.Add(this._addBookButton);
            this.Controls.Add(this._authorTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this._titleTextBox);
            this.Controls.Add(this._booksListBox);
            this.Name = "BookView";
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _booksListBox;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _authorTextBox;
        private System.Windows.Forms.Button _addBookButton;
        private System.Windows.Forms.Button _removeBookButton;
    }
}

