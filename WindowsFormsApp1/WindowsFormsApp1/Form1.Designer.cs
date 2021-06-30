

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += Timer_Tick;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(252, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 147);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);







            ///                 colorBtn             
            this.colorBtn = new Button();
            this.colorBtn.Text = "BG color";
            this.colorBtn.Location = new System.Drawing.Point(600,100);
            this.colorBtn.Click += (sender, args) =>
            {
                using (ColorDialog dialog = new ColorDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.BackColor = dialog.Color;
                    }
                }
            };
            ///                 colorBtn             END




            ///                 colorBtn             
            this.colorBtnn = new Button();
            this.colorBtnn.Text = "time color";
            this.colorBtnn.Location = new System.Drawing.Point(600, 150);
            this.colorBtnn.Click += (sender, args) =>
            {
                using (ColorDialog dialog = new ColorDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.panel1.BackColor = dialog.Color;
                    }
                }
            };
            ///                 colorBtn             END

            //                  
            this._check_1 = new CheckBox();
            this._check_1.Text = "Second";
            this._check_1.Name = "check_1";
            this._check_1.Location = new Point(100, 350);
          


            this._check_2 = new CheckBox();
            this._check_2.Text = "Hour";
            this._check_2.Name = "check_2";
            this._check_2.Location = new Point(250, 350);
            

            this._check_3 = new CheckBox();
            this._check_3.Text = "Minute";
            this._check_3.Name = "check_3";
            this._check_3.Location = new Point(400, 350);


            this._check_4 = new CheckBox();
            this._check_4.Text = "Millisecond";
            this._check_4.Name = "check_3";
            this._check_4.Location = new Point(550, 350);

            //       





            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.colorBtnn);

            this.Controls.Add(this._check_1);
            this.Controls.Add(this._check_2);
            this.Controls.Add(this._check_3);
            this.Controls.Add(this._check_4);

        }


        private void Timer_Tick(object sender, System.EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToShortTimeString();
        }


        


        #endregion

        private Timer timer;
        private System.Windows.Forms.Label label1;
        private Panel panel1;
        private Button colorBtn;
        private Button colorBtnn;

        CheckBox _check_1;
        CheckBox _check_2;
        CheckBox _check_3;
        CheckBox _check_4;
    }
}

