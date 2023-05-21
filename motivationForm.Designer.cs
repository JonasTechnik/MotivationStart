namespace Motivation_Start
{
    partial class motivationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motivationForm));
            quoteBox = new RichTextBox();
            anotherBTN = new Button();
            SuspendLayout();
            // 
            // quoteBox
            // 
            quoteBox.BackColor = Color.FromArgb(153, 51, 255);
            quoteBox.BorderStyle = BorderStyle.None;
            quoteBox.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            quoteBox.ForeColor = Color.White;
            quoteBox.Location = new Point(40, 40);
            quoteBox.Name = "quoteBox";
            quoteBox.ReadOnly = true;
            quoteBox.Size = new Size(1104, 431);
            quoteBox.TabIndex = 0;
            quoteBox.Text = "";
            // 
            // anotherBTN
            // 
            anotherBTN.BackColor = Color.White;
            anotherBTN.Dock = DockStyle.Bottom;
            anotherBTN.FlatStyle = FlatStyle.Flat;
            anotherBTN.ForeColor = Color.Black;
            anotherBTN.Location = new Point(0, 477);
            anotherBTN.Name = "anotherBTN";
            anotherBTN.Size = new Size(1184, 34);
            anotherBTN.TabIndex = 1;
            anotherBTN.Text = "Another One";
            anotherBTN.UseVisualStyleBackColor = false;
            anotherBTN.Click += anotherBTN_Click;
            // 
            // motivationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 51, 255);
            ClientSize = new Size(1184, 511);
            Controls.Add(anotherBTN);
            Controls.Add(quoteBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "motivationForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox quoteBox;
        private Button anotherBTN;
    }
}