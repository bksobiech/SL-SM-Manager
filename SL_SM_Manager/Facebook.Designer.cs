namespace SL_SM_Manager
{
    partial class Facebook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imgButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rDateBox = new System.Windows.Forms.TextBox();
            this.imgUpload = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.imgButton2 = new System.Windows.Forms.Button();
            this.imgUpload2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Request Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content to Post:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(209, 41);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(320, 22);
            this.nameBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(209, 83);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(320, 22);
            this.dateBox.TabIndex = 4;
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(209, 164);
            this.contentBox.MaxLength = 2000;
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(320, 168);
            this.contentBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Image to Post:";
            // 
            // imgButton
            // 
            this.imgButton.Location = new System.Drawing.Point(34, 390);
            this.imgButton.Name = "imgButton";
            this.imgButton.Size = new System.Drawing.Size(106, 31);
            this.imgButton.TabIndex = 7;
            this.imgButton.Text = "Add Image";
            this.imgButton.UseVisualStyleBackColor = true;
            this.imgButton.Click += new System.EventHandler(this.imgButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date to Post:";
            // 
            // rDateBox
            // 
            this.rDateBox.Location = new System.Drawing.Point(209, 121);
            this.rDateBox.Name = "rDateBox";
            this.rDateBox.Size = new System.Drawing.Size(320, 22);
            this.rDateBox.TabIndex = 9;
            // 
            // imgUpload
            // 
            this.imgUpload.Location = new System.Drawing.Point(172, 338);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(357, 220);
            this.imgUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpload.TabIndex = 10;
            this.imgUpload.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(209, 838);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(454, 838);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(333, 838);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Image to Post(2):";
            // 
            // imgButton2
            // 
            this.imgButton2.Location = new System.Drawing.Point(33, 627);
            this.imgButton2.Name = "imgButton2";
            this.imgButton2.Size = new System.Drawing.Size(103, 31);
            this.imgButton2.TabIndex = 15;
            this.imgButton2.Text = "Add Image 2";
            this.imgButton2.UseVisualStyleBackColor = true;
            this.imgButton2.Click += new System.EventHandler(this.imgButton2_Click);
            // 
            // imgUpload2
            // 
            this.imgUpload2.Location = new System.Drawing.Point(169, 594);
            this.imgUpload2.Name = "imgUpload2";
            this.imgUpload2.Size = new System.Drawing.Size(357, 220);
            this.imgUpload2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpload2.TabIndex = 16;
            this.imgUpload2.TabStop = false;
            // 
            // Facebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 889);
            this.Controls.Add(this.imgUpload2);
            this.Controls.Add(this.imgButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.imgUpload);
            this.Controls.Add(this.rDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facebook";
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button imgButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rDateBox;
        private System.Windows.Forms.PictureBox imgUpload;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button imgButton2;
        private System.Windows.Forms.PictureBox imgUpload2;
    }
}