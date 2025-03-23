namespace CMSWinFormsApp
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            lblCarNo = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblMake = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            errCustForm = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errCustForm).BeginInit();
            SuspendLayout();
            // 
            // lblCarNo
            // 
            lblCarNo.AutoSize = true;
            lblCarNo.Location = new Point(102, 43);
            lblCarNo.Name = "lblCarNo";
            lblCarNo.Size = new Size(63, 20);
            lblCarNo.TabIndex = 0;
            lblCarNo.Text = "Car No.";
            lblCarNo.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(113, 167);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(394, 43);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Adress";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(394, 170);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(49, 20);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(477, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(194, 325);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 27);
            textBox5.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(71, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(213, 250);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(349, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(508, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button4_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(71, 325);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 13;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(508, 325);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // errCustForm
            // 
            errCustForm.ContainerControl = this;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblMake);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblCarNo);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)errCustForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarNo;
        private Label lblName;
        private Label lblAddress;
        private Label lblMake;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnSave;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExit;
        private Button btnPrevious;
        private Button btnNext;
        private ErrorProvider errCustForm;
    }
}