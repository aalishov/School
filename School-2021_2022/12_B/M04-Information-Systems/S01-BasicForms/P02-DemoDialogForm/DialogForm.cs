namespace P02_DemoDialogForm
{
    public class DialogForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public DialogForm(string dialogName, string textBoxInfo)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent(dialogName, textBoxInfo);

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
        private void InitializeComponent(string dialogName, string textBoxInfo)
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBox.Location = new System.Drawing.Point(104, 16);
            this.TextBox.Name = "TextBoxName";
            this.TextBox.Size = new System.Drawing.Size(152, 20);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // LabelYourName
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(8, 19);
            this.Label.Name = "LabelYourName";
            this.Label.Size = new System.Drawing.Size(91, 16);
            this.Label.TabIndex = 1;
            this.Label.Text = textBoxInfo;
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
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.Text = dialogName;
            this.ResumeLayout(false);

        }
        #endregion

        public string TextResult
        {
            get
            {
                return TextBox.Text;
            }
        }
    }
}
