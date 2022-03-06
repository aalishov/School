using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooters.FormApp
{
    public class DialogForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelYourName;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private readonly string message;

        public DialogForm(string message)
        {
            //
            // Required for Windows Form Designer support
            //
            this.message = message;
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelYourName = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(104, 16);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(152, 20);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Text = "";
            // 
            // LabelYourName
            // 
            this.LabelYourName.AutoSize = true;
            this.LabelYourName.Location = new System.Drawing.Point(8, 19);
            this.LabelYourName.Name = "LabelYourName";
            this.LabelYourName.Size = new System.Drawing.Size(91, 16);
            this.LabelYourName.TabIndex = 1;
            this.LabelYourName.Text = $"{message}:";
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(40, 48);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "OK";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(152, 48);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            // 
            // DialogForm
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(274, 87);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.LabelYourName);
            this.Controls.Add(this.TextBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.Text = "Dialog Form";
            this.ResumeLayout(false);
        }
        #endregion
        public string Result
        {
            get
            {
                return TextBoxName.Text;
            }
        }
    }
}
