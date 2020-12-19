namespace RunProgram
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.btnRegEdit = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(54, 40);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(168, 23);
            this.btnSystemInfo.TabIndex = 0;
            this.btnSystemInfo.Text = "Информация о системе";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // btnRegEdit
            // 
            this.btnRegEdit.Location = new System.Drawing.Point(54, 93);
            this.btnRegEdit.Name = "btnRegEdit";
            this.btnRegEdit.Size = new System.Drawing.Size(168, 23);
            this.btnRegEdit.TabIndex = 1;
            this.btnRegEdit.Text = "Редактор реестра";
            this.btnRegEdit.UseVisualStyleBackColor = true;
            this.btnRegEdit.Click += new System.EventHandler(this.btnRegEdit_Click);
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(54, 150);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(168, 23);
            this.btnExplorer.TabIndex = 2;
            this.btnExplorer.Text = "Проводник";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.btnRegEdit);
            this.Controls.Add(this.btnSystemInfo);
            this.Name = "Form1";
            this.Text = "RunProgram";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.Button btnRegEdit;
        private System.Windows.Forms.Button btnExplorer;
    }
}

