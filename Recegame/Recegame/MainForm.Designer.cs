namespace Recegame
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_Botton = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Status_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Start_Botton
            // 
            this.Start_Botton.Location = new System.Drawing.Point(119, 361);
            this.Start_Botton.Name = "Start_Botton";
            this.Start_Botton.Size = new System.Drawing.Size(108, 42);
            this.Start_Botton.TabIndex = 0;
            this.Start_Botton.Text = "StartEngine";
            this.Start_Botton.UseVisualStyleBackColor = true;
            this.Start_Botton.Click += new System.EventHandler(this.Start_Botton_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(417, 361);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(100, 42);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Status_TextBox
            // 
            this.Status_TextBox.Location = new System.Drawing.Point(119, 36);
            this.Status_TextBox.Name = "Status_TextBox";
            this.Status_TextBox.Size = new System.Drawing.Size(398, 309);
            this.Status_TextBox.TabIndex = 2;
            this.Status_TextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status_TextBox);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Botton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Botton;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.RichTextBox Status_TextBox;
    }
}

