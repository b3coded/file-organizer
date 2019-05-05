namespace File_Organizer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.BackColor = System.Drawing.Color.Transparent;
            this.btn_select_folder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_select_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_select_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select_folder.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_folder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_select_folder.Location = new System.Drawing.Point(305, 296);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(226, 50);
            this.btn_select_folder.TabIndex = 0;
            this.btn_select_folder.Text = "Select Folder";
            this.btn_select_folder.UseVisualStyleBackColor = false;
            this.btn_select_folder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(305, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Organize!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.fileCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.currentFolder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_select_folder);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 519);
            this.panel2.TabIndex = 3;
            // 
            // fileCount
            // 
            this.fileCount.AutoSize = true;
            this.fileCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileCount.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileCount.Location = new System.Drawing.Point(12, 170);
            this.fileCount.MinimumSize = new System.Drawing.Size(200, 20);
            this.fileCount.Name = "fileCount";
            this.fileCount.Size = new System.Drawing.Size(200, 26);
            this.fileCount.TabIndex = 5;
            this.fileCount.Click += new System.EventHandler(this.FileCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Files Found:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // currentFolder
            // 
            this.currentFolder.AutoSize = true;
            this.currentFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentFolder.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentFolder.Location = new System.Drawing.Point(12, 86);
            this.currentFolder.MinimumSize = new System.Drawing.Size(200, 20);
            this.currentFolder.Name = "currentFolder";
            this.currentFolder.Size = new System.Drawing.Size(200, 26);
            this.currentFolder.TabIndex = 3;
            this.currentFolder.Click += new System.EventHandler(this.CurrentFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FO - File Organizer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentFolder;
        private System.Windows.Forms.Label fileCount;
        private System.Windows.Forms.Label label3;
    }
}

