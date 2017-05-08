namespace LifeAdvanced
{
    partial class EventScreen
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
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(460, 61);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(335, 73);
            this.title.TabIndex = 0;
            this.title.Text = "Event Title";
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.text.ForeColor = System.Drawing.SystemColors.Window;
            this.text.Location = new System.Drawing.Point(12, 167);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(1240, 262);
            this.text.TabIndex = 1;
            this.text.Text = "Event Text";
            // 
            // choice1
            // 
            this.choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.Location = new System.Drawing.Point(12, 435);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(1240, 102);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "Choice 1";
            this.choice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice1.UseVisualStyleBackColor = true;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.Location = new System.Drawing.Point(12, 556);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(1240, 102);
            this.choice2.TabIndex = 3;
            this.choice2.Text = "Choice 2";
            this.choice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice2.UseVisualStyleBackColor = true;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // EventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Name = "EventScreen";
            this.Text = "EventScreen";
            this.Load += new System.EventHandler(this.EventScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
    }
}