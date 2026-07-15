namespace WinFormsApp1
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
            btnCat = new Button();
            lblCatFact = new Label();
            btnBigger = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCat
            // 
            btnCat.Dock = DockStyle.Fill;
            btnCat.Location = new Point(0, 0);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(96, 309);
            btnCat.TabIndex = 0;
            btnCat.Text = "Get Cat Fact";
            btnCat.UseVisualStyleBackColor = true;
            btnCat.Click += btnCat_Click;
            // 
            // lblCatFact
            // 
            lblCatFact.Dock = DockStyle.Fill;
            lblCatFact.Location = new Point(0, 0);
            lblCatFact.Name = "lblCatFact";
            lblCatFact.Size = new Size(948, 309);
            lblCatFact.TabIndex = 1;
            lblCatFact.Text = "Get ready to find out some fascinating feline facts";
            // 
            // btnBigger
            // 
            btnBigger.Location = new Point(3, 3);
            btnBigger.Name = "btnBigger";
            btnBigger.Size = new Size(75, 23);
            btnBigger.TabIndex = 2;
            btnBigger.Text = "+";
            btnBigger.UseVisualStyleBackColor = true;
            btnBigger.Click += btnBigger_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblCatFact);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCat);
            splitContainer1.Size = new Size(1048, 309);
            splitContainer1.SplitterDistance = 948;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(1048, 340);
            splitContainer2.SplitterDistance = 309;
            splitContainer2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBigger);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1048, 27);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 340);
            Controls.Add(splitContainer2);
            Name = "Form1";
            Text = "All about Cats";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCat;
        private Label lblCatFact;
        private Button btnBigger;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
