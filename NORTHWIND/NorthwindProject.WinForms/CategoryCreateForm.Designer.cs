namespace NorthwindProject.WinForms
{
    partial class CategoryCreateForm
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
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            lbl2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(304, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(199, 23);
            txtDescription.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(304, 139);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(199, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(208, 188);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(56, 15);
            lbl2.TabIndex = 7;
            lbl2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 139);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Kategori adı";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(428, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CategorryCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lbl2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "CategorryCreateForm";
            Text = "CategoryCreateForm";
            Load += CategorryCreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private Label lbl2;
        private Label label1;
        private Button btnSave;
    }
}