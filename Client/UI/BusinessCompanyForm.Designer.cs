namespace UI
{
    partial class BusinessCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessCompanyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateDonation = new System.Windows.Forms.Button();
            this.richTextBox_Quantity = new System.Windows.Forms.RichTextBox();
            this.richTextBox_ProductValue = new System.Windows.Forms.RichTextBox();
            this.richTextBox_ProductName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_MyDonations = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Campaign = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_SendItems = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_ToSend = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyDonations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ToSend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Business Company Aera";
            // 
            // button_CreateDonation
            // 
            this.button_CreateDonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_CreateDonation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CreateDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_CreateDonation.FlatAppearance.BorderSize = 0;
            this.button_CreateDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CreateDonation.ForeColor = System.Drawing.Color.White;
            this.button_CreateDonation.Location = new System.Drawing.Point(23, 414);
            this.button_CreateDonation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_CreateDonation.Name = "button_CreateDonation";
            this.button_CreateDonation.Size = new System.Drawing.Size(536, 57);
            this.button_CreateDonation.TabIndex = 9;
            this.button_CreateDonation.Text = "Create Donation";
            this.button_CreateDonation.UseVisualStyleBackColor = false;
            this.button_CreateDonation.Click += new System.EventHandler(this.button_CreateDonation_Click);
            // 
            // richTextBox_Quantity
            // 
            this.richTextBox_Quantity.Location = new System.Drawing.Point(280, 280);
            this.richTextBox_Quantity.Name = "richTextBox_Quantity";
            this.richTextBox_Quantity.Size = new System.Drawing.Size(269, 30);
            this.richTextBox_Quantity.TabIndex = 22;
            this.richTextBox_Quantity.Text = "";
            // 
            // richTextBox_ProductValue
            // 
            this.richTextBox_ProductValue.Location = new System.Drawing.Point(280, 213);
            this.richTextBox_ProductValue.Name = "richTextBox_ProductValue";
            this.richTextBox_ProductValue.Size = new System.Drawing.Size(269, 30);
            this.richTextBox_ProductValue.TabIndex = 21;
            this.richTextBox_ProductValue.Text = "";
            // 
            // richTextBox_ProductName
            // 
            this.richTextBox_ProductName.Location = new System.Drawing.Point(280, 142);
            this.richTextBox_ProductName.Name = "richTextBox_ProductName";
            this.richTextBox_ProductName.Size = new System.Drawing.Size(269, 30);
            this.richTextBox_ProductName.TabIndex = 20;
            this.richTextBox_ProductName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product value";
            // 
            // dataGridView_MyDonations
            // 
            this.dataGridView_MyDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MyDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MyDonations.Location = new System.Drawing.Point(645, 73);
            this.dataGridView_MyDonations.Name = "dataGridView_MyDonations";
            this.dataGridView_MyDonations.RowHeadersWidth = 51;
            this.dataGridView_MyDonations.RowTemplate.Height = 29;
            this.dataGridView_MyDonations.Size = new System.Drawing.Size(680, 124);
            this.dataGridView_MyDonations.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(852, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 51);
            this.label5.TabIndex = 23;
            this.label5.Text = "My Donations";
            // 
            // richTextBox_Campaign
            // 
            this.richTextBox_Campaign.Location = new System.Drawing.Point(280, 356);
            this.richTextBox_Campaign.Name = "richTextBox_Campaign";
            this.richTextBox_Campaign.Size = new System.Drawing.Size(269, 30);
            this.richTextBox_Campaign.TabIndex = 26;
            this.richTextBox_Campaign.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Campaign";
            // 
            // button_SendItems
            // 
            this.button_SendItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_SendItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SendItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_SendItems.FlatAppearance.BorderSize = 0;
            this.button_SendItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SendItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SendItems.ForeColor = System.Drawing.Color.White;
            this.button_SendItems.Location = new System.Drawing.Point(827, 416);
            this.button_SendItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SendItems.Name = "button_SendItems";
            this.button_SendItems.Size = new System.Drawing.Size(365, 67);
            this.button_SendItems.TabIndex = 27;
            this.button_SendItems.Text = "Send Items";
            this.button_SendItems.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(849, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 51);
            this.label7.TabIndex = 28;
            this.label7.Text = "Items To Send";
            // 
            // dataGridView_ToSend
            // 
            this.dataGridView_ToSend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ToSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ToSend.Location = new System.Drawing.Point(645, 284);
            this.dataGridView_ToSend.Name = "dataGridView_ToSend";
            this.dataGridView_ToSend.RowHeadersWidth = 51;
            this.dataGridView_ToSend.RowTemplate.Height = 29;
            this.dataGridView_ToSend.Size = new System.Drawing.Size(680, 124);
            this.dataGridView_ToSend.TabIndex = 29;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserName.Location = new System.Drawing.Point(2, 497);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(158, 41);
            this.UserName.TabIndex = 30;
            this.UserName.Text = "UserName";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ID.Location = new System.Drawing.Point(1313, 508);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(105, 41);
            this.label_ID.TabIndex = 31;
            this.label_ID.Text = "label8";
            // 
            // BusinessCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.twbackgound;
            this.ClientSize = new System.Drawing.Size(1359, 558);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.dataGridView_ToSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_SendItems);
            this.Controls.Add(this.richTextBox_Campaign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_MyDonations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Quantity);
            this.Controls.Add(this.richTextBox_ProductValue);
            this.Controls.Add(this.richTextBox_ProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_CreateDonation);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusinessCompanyForm";
            this.Text = "BusinessCompanyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyDonations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ToSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_CreateDonation;
        private RichTextBox richTextBox_Quantity;
        private RichTextBox richTextBox_ProductValue;
        private RichTextBox richTextBox_ProductName;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView_MyDonations;
        private Label label5;
        private RichTextBox richTextBox_Campaign;
        private Label label6;
        private Button button_SendItems;
        private Label label7;
        private DataGridView dataGridView_ToSend;
        private Label UserName;
        private Label label_ID;
    }
}