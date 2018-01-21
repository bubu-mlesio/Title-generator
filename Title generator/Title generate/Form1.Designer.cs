namespace Title_generate
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
            this.title_name = new System.Windows.Forms.TextBox();
            this.models_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fromFile = new System.Windows.Forms.CheckBox();
            this.file_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_name
            // 
            this.title_name.Location = new System.Drawing.Point(17, 107);
            this.title_name.Multiline = true;
            this.title_name.Name = "title_name";
            this.title_name.Size = new System.Drawing.Size(521, 29);
            this.title_name.TabIndex = 0;
            this.title_name.Text = "Wspólny tytuł";
            // 
            // models_name
            // 
            this.models_name.Location = new System.Drawing.Point(17, 188);
            this.models_name.MaxLength = 0;
            this.models_name.Multiline = true;
            this.models_name.Name = "models_name";
            this.models_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.models_name.Size = new System.Drawing.Size(521, 296);
            this.models_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modele:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(521, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fromFile
            // 
            this.fromFile.AutoSize = true;
            this.fromFile.Location = new System.Drawing.Point(22, 12);
            this.fromFile.Name = "fromFile";
            this.fromFile.Size = new System.Drawing.Size(173, 29);
            this.fromFile.TabIndex = 6;
            this.fromFile.Text = "modele z pliku?";
            this.fromFile.UseVisualStyleBackColor = true;
            this.fromFile.CheckedChanged += new System.EventHandler(this.fromFile_CheckedChanged);
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(22, 47);
            this.file_name.Multiline = true;
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(171, 29);
            this.file_name.TabIndex = 7;
            this.file_name.Text = "modele";
            this.file_name.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 655);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.fromFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.models_name);
            this.Controls.Add(this.title_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_name;
        private System.Windows.Forms.TextBox models_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox fromFile;
        private System.Windows.Forms.TextBox file_name;
    }
}

