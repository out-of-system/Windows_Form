namespace Windows_Forms
{
    partial class Form1
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
            btnAdd = new Button();
            lstNames = new ListBox();
            label1 = new Label();
            txtName = new TextBox();
            btnClean = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(148, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Adicionar Convidado";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 38);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(119, 229);
            lstNames.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 2;
            label1.Text = "Lista de Convidados";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(148, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 23);
            txtName.TabIndex = 3;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(148, 141);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(185, 23);
            btnClean.TabIndex = 4;
            btnClean.Text = "Remover Convidado";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.Transparent;
            btnSair.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(274, 191);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(59, 34);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.TopCenter;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(365, 307);
            Controls.Add(btnSair);
            Controls.Add(btnClean);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lstNames);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox lstNames;
        private Label label1;
        private TextBox txtName;
        private Button btnClean;
        private Button btnSair;
    }
}
