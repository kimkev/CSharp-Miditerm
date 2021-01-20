namespace KevinKim_Midterm_991456570
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.cmbCard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emter Your Details Here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Info";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 31);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Your Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 192);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(286, 31);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "Address";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(59, 274);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 31);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toppings";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(69, 505);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(118, 29);
            this.chkCheese.TabIndex = 13;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(69, 557);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(142, 29);
            this.chkPepperoni.TabIndex = 14;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(69, 607);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(156, 29);
            this.chkMushrooms.TabIndex = 15;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // cmbCard
            // 
            this.cmbCard.FormattingEnabled = true;
            this.cmbCard.Items.AddRange(new object[] {
            "Master",
            "Visa",
            "American Express"});
            this.cmbCard.Location = new System.Drawing.Point(290, 505);
            this.cmbCard.Name = "cmbCard";
            this.cmbCard.Size = new System.Drawing.Size(198, 33);
            this.cmbCard.TabIndex = 16;
            this.cmbCard.Text = "Master";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Card Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(290, 557);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(198, 31);
            this.txtCardNo.TabIndex = 18;
            this.txtCardNo.Text = "Credit Card Number";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(290, 607);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(198, 31);
            this.txtStatus.TabIndex = 19;
            this.txtStatus.Text = "Status (In Process)";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(562, 72);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(592, 349);
            this.txtOutput.TabIndex = 20;
            this.txtOutput.Text = "Output here";
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(665, 469);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(163, 52);
            this.btnPlace.TabIndex = 21;
            this.btnPlace.Text = "Place Order";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(910, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 52);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.Location = new System.Drawing.Point(627, 544);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(201, 52);
            this.btnChangeAddress.TabIndex = 23;
            this.btnChangeAddress.Text = "Change Address";
            this.btnChangeAddress.UseVisualStyleBackColor = true;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(910, 546);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(200, 52);
            this.btnChangeStatus.TabIndex = 24;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(910, 638);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(163, 42);
            this.btnView.TabIndex = 25;
            this.btnView.Text = "View Order";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(795, 702);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(163, 52);
            this.btnQuery.TabIndex = 26;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(665, 638);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(163, 31);
            this.txtOrderId.TabIndex = 27;
            this.txtOrderId.Text = "Order Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 810);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnChangeAddress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCard);
            this.Controls.Add(this.chkMushrooms);
            this.Controls.Add(this.chkPepperoni);
            this.Controls.Add(this.chkCheese);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.ComboBox cmbCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtOrderId;
    }
}

