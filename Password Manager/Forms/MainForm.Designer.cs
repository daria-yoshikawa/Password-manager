namespace Password_Manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.output = new Password_Manager.output_pass();
            this.AccountView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.ExitButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNewButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.output);
            this.splitContainer1.Panel2.Controls.Add(this.AccountView);
            this.splitContainer1.Size = new System.Drawing.Size(875, 593);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.BackColor = System.Drawing.Color.MistyRose;
            this.EditButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditButton.Location = new System.Drawing.Point(21, 103);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(249, 71);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(21, 498);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(249, 71);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(21, 180);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(249, 71);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackColor = System.Drawing.Color.MistyRose;
            this.AddNewButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewButton.Location = new System.Drawing.Point(21, 26);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(249, 71);
            this.AddNewButton.TabIndex = 0;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // output
            // 
            this.output.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output.BackgroundImage")));
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(576, 289);
            this.output.TabIndex = 1;
            // 
            // AccountView
            // 
            this.AccountView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountView.BackColor = System.Drawing.Color.AliceBlue;
            this.AccountView.ForeColor = System.Drawing.Color.DeepPink;
            this.AccountView.Location = new System.Drawing.Point(3, 298);
            this.AccountView.MultiSelect = false;
            this.AccountView.Name = "AccountView";
            this.AccountView.Size = new System.Drawing.Size(576, 292);
            this.AccountView.TabIndex = 0;
            this.AccountView.UseCompatibleStateImageBehavior = false;
            this.AccountView.ItemActivate += new System.EventHandler(this.AccountView_ItemActivate);
            this.AccountView.SelectedIndexChanged += new System.EventHandler(this.AccountView_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "89osDqGMA3M.jpg");
            this.imageList1.Images.SetKeyName(1, "A7rDMq2P03U.jpg");
            this.imageList1.Images.SetKeyName(2, "bc80n6NFK3Y.jpg");
            this.imageList1.Images.SetKeyName(3, "BErjdbhSPgc.jpg");
            this.imageList1.Images.SetKeyName(4, "Epxy_dJbL1c.jpg");
            this.imageList1.Images.SetKeyName(5, "Gx2GivI7qNA.jpg");
            this.imageList1.Images.SetKeyName(6, "jp0RML1-Wdw.jpg");
            this.imageList1.Images.SetKeyName(7, "-Jy1V98YiOM.jpg");
            this.imageList1.Images.SetKeyName(8, "ntwHmVHUIb4.jpg");
            this.imageList1.Images.SetKeyName(9, "nwikjpeN87U.jpg");
            this.imageList1.Images.SetKeyName(10, "osxM55LyqqI.jpg");
            this.imageList1.Images.SetKeyName(11, "rdkPfZ8KjQE.jpg");
            this.imageList1.Images.SetKeyName(12, "URAhjT9k7zk.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 593);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button AddNewButton;
        private Button DeleteButton;
        private Button ExitButton;
        private ListView AccountView;
        private output_pass output;
        private Button EditButton;
        private ImageList imageList1;
    }
}