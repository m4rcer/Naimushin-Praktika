
namespace Naimushin.Forms
{
    partial class StudentInfoForm
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
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MathLabel = new System.Windows.Forms.Label();
            this.ProgrammingLabel = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.RussianLabel = new System.Windows.Forms.Label();
            this.PhysicsLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(12, 9);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(167, 38);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Наймушин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оценки:";
            // 
            // MathLabel
            // 
            this.MathLabel.AutoSize = true;
            this.MathLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MathLabel.Location = new System.Drawing.Point(12, 121);
            this.MathLabel.Name = "MathLabel";
            this.MathLabel.Size = new System.Drawing.Size(177, 38);
            this.MathLabel.TabIndex = 0;
            this.MathLabel.Text = "Математика:";
            // 
            // ProgrammingLabel
            // 
            this.ProgrammingLabel.AutoSize = true;
            this.ProgrammingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgrammingLabel.Location = new System.Drawing.Point(12, 170);
            this.ProgrammingLabel.Name = "ProgrammingLabel";
            this.ProgrammingLabel.Size = new System.Drawing.Size(0, 38);
            this.ProgrammingLabel.TabIndex = 0;
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnglishLabel.Location = new System.Drawing.Point(12, 220);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(0, 38);
            this.EnglishLabel.TabIndex = 0;
            // 
            // RussianLabel
            // 
            this.RussianLabel.AutoSize = true;
            this.RussianLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RussianLabel.Location = new System.Drawing.Point(12, 269);
            this.RussianLabel.Name = "RussianLabel";
            this.RussianLabel.Size = new System.Drawing.Size(0, 38);
            this.RussianLabel.TabIndex = 0;
            // 
            // PhysicsLabel
            // 
            this.PhysicsLabel.AutoSize = true;
            this.PhysicsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhysicsLabel.Location = new System.Drawing.Point(12, 321);
            this.PhysicsLabel.Name = "PhysicsLabel";
            this.PhysicsLabel.Size = new System.Drawing.Size(0, 38);
            this.PhysicsLabel.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Silver;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(169, 377);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 66);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Silver;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edit.Location = new System.Drawing.Point(12, 377);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(151, 66);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 455);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.PhysicsLabel);
            this.Controls.Add(this.RussianLabel);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.ProgrammingLabel);
            this.Controls.Add(this.MathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 511);
            this.MinimumSize = new System.Drawing.Size(348, 511);
            this.Name = "StudentInfoForm";
            this.Text = "Информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MathLabel;
        private System.Windows.Forms.Label ProgrammingLabel;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label RussianLabel;
        private System.Windows.Forms.Label PhysicsLabel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
    }
}