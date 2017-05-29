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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventScreen));
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 61);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1240, 73);
            this.title.TabIndex = 0;
            this.title.Text = "Event Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Black;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(12, 167);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(1240, 262);
            this.text.TabIndex = 1;
            this.text.Text = "Event Text";
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.White;
            this.choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.Location = new System.Drawing.Point(12, 435);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(1240, 102);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "Choice 1";
            this.choice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.White;
            this.choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.Location = new System.Drawing.Point(12, 556);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(1240, 102);
            this.choice2.TabIndex = 3;
            this.choice2.Text = "Choice 2";
            this.choice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tile: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "NaN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "NaN";
            // 
            // EventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}