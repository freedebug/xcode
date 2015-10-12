namespace VipSoft
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.myButton2 = new AlSkin.AlControl.AlButton();
            this.myButton1 = new AlSkin.AlControl.AlButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(323, 194);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(99, 21);
            this.txtUserName.TabIndex = 20;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            this.myButton2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton2.Location = new System.Drawing.Point(365, 264);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(80, 30);
            this.myButton2.TabIndex = 17;
            this.myButton2.Text = "关闭系统";
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton1.Location = new System.Drawing.Point(239, 264);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(80, 30);
            this.myButton1.TabIndex = 16;
            this.myButton1.Text = "马上登录";
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "操作密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "操作账号：";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(323, 227);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(99, 21);
            this.password.TabIndex = 15;
            this.password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BacklightImg = global::VipSoft.Properties.Resources.登录界面3;
            this.ClientSize = new System.Drawing.Size(664, 418);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowTitle = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.password, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.myButton1, 0);
            this.Controls.SetChildIndex(this.myButton2, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private AlSkin.AlControl.AlButton myButton2;
        private AlSkin.AlControl.AlButton myButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
    }
}

