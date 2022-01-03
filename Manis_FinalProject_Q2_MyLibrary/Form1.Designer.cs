
namespace Manis_FinalProject_Q2_MyLibrary
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
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.selectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListBox
            // 
            this.bookListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 27;
            this.bookListBox.Items.AddRange(new object[] {
            "The Lord of the Rings: The Fellowship of the Ring",
            "the Lord of the Rings: The Two Towers",
            "The Lord of the Rings The Return of the King",
            "The Hobbit",
            "Maze Runner",
            "The Hunger Games",
            "Fight Club"});
            this.bookListBox.Location = new System.Drawing.Point(236, 106);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.bookListBox.Size = new System.Drawing.Size(632, 220);
            this.bookListBox.TabIndex = 0;
            this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make as many selections as you like by holding down the Ctrl key";
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutLabel.Location = new System.Drawing.Point(232, 475);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(0, 27);
            this.outPutLabel.TabIndex = 2;
            // 
            // selectionButton
            // 
            this.selectionButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.selectionButton.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionButton.Location = new System.Drawing.Point(452, 346);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(186, 93);
            this.selectionButton.TabIndex = 3;
            this.selectionButton.Text = "Make Selection";
            this.selectionButton.UseVisualStyleBackColor = false;
            this.selectionButton.Click += new System.EventHandler(this.selectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 590);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.Button selectionButton;
    }
}

