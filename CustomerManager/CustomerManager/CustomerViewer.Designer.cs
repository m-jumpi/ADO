namespace CustomerManager
{
    partial class CustomerViewer
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
            this.customerList = new System.Windows.Forms.ComboBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelFoto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViporderradioButton = new System.Windows.Forms.RadioButton();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(65, 68);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(363, 33);
            this.customerList.TabIndex = 0;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.ItemHeight = 25;
            this.orderlistBox.Location = new System.Drawing.Point(65, 162);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(363, 204);
            this.orderlistBox.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(673, 68);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(242, 31);
            this.textBoxname.TabIndex = 2;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(673, 134);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(242, 31);
            this.textBoxlastname.TabIndex = 3;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(673, 206);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(242, 31);
            this.textBoxmail.TabIndex = 4;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(673, 294);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(242, 31);
            this.textBoxage.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(552, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(552, 140);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(106, 25);
            this.labelLastname.TabIndex = 7;
            this.labelLastname.Text = "Lastname";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(552, 212);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(91, 25);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(570, 300);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 25);
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Age";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(673, 392);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(242, 64);
            this.buttonFile.TabIndex = 10;
            this.buttonFile.Text = "Choose a file";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1141, 68);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(240, 97);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Data";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(1423, 68);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(208, 97);
            this.buttonOut.TabIndex = 12;
            this.buttonOut.Text = "Show Data";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(1679, 68);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 55);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1679, 162);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(177, 58);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Location = new System.Drawing.Point(552, 422);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(55, 25);
            this.labelFoto.TabIndex = 15;
            this.labelFoto.Text = "Foto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViporderradioButton);
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(1161, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 144);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Data";
            // 
            // ViporderradioButton
            // 
            this.ViporderradioButton.AutoSize = true;
            this.ViporderradioButton.Location = new System.Drawing.Point(398, 72);
            this.ViporderradioButton.Name = "ViporderradioButton";
            this.ViporderradioButton.Size = new System.Drawing.Size(234, 29);
            this.ViporderradioButton.TabIndex = 2;
            this.ViporderradioButton.TabStop = true;
            this.ViporderradioButton.Text = "ViporderradioButton";
            this.ViporderradioButton.UseVisualStyleBackColor = true;
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(222, 72);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(108, 29);
            this.OrderradioButton.TabIndex = 1;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(54, 72);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(146, 29);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(1161, 416);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(695, 31);
            this.textBoxCustomer.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(1091, 419);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 25);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "Id";
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 524);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 82;
            this.GridView.RowTemplate.Height = 33;
            this.GridView.Size = new System.Drawing.Size(1990, 496);
            this.GridView.TabIndex = 19;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1990, 1020);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.Name = "CustomerViewer";
            this.Text = "Customer Viewer";
            this.Load += new System.EventHandler(this.CustomerViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.RadioButton ViporderradioButton;
    }
}

