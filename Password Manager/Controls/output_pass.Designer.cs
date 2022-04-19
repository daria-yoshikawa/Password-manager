namespace Password_Manager
{
    partial class output_pass
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(output_pass));
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UserText
            // 
            this.UserText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserText.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserText.Location = new System.Drawing.Point(186, 112);
            this.UserText.Name = "UserText";
            this.UserText.ReadOnly = true;
            this.UserText.Size = new System.Drawing.Size(188, 32);
            this.UserText.TabIndex = 0;
            // 
            // PassText
            // 
            this.PassText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PassText.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassText.Location = new System.Drawing.Point(186, 158);
            this.PassText.Name = "PassText";
            this.PassText.ReadOnly = true;
            this.PassText.Size = new System.Drawing.Size(188, 32);
            this.PassText.TabIndex = 1;
            this.PassText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.NameText.ForeColor = System.Drawing.Color.Black;
            this.NameText.Location = new System.Drawing.Point(242, 51);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(82, 33);
            this.NameText.TabIndex = 3;
            this.NameText.Text = "Name";
            this.NameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(186, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Скопировать пароль";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(85, 115);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(95, 24);
            this.UserLabel.TabIndex = 6;
            this.UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassLabel.Location = new System.Drawing.Point(85, 161);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(91, 24);
            this.PassLabel.TabIndex = 7;
            this.PassLabel.Text = "Password";
            this.PassLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(380, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 23);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Скрыть";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // output_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Name = "output_pass";
            this.Size = new System.Drawing.Size(557, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserText;
        private TextBox PassText;
        private Label label1;
        private Label NameText;
        private Button button2;
        private Label UserLabel;
        private Label PassLabel;
        private CheckBox checkBox1;
    }
}
