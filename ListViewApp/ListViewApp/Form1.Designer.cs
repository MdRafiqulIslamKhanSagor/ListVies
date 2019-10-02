namespace ListViewApp
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allInfoListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addAllButton = new System.Windows.Forms.Button();
            this.clearAllFromTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(167, 107);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(220, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(167, 144);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(220, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // allInfoListView
            // 
            this.allInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.contactColumn,
            this.emailColumn});
            this.allInfoListView.Location = new System.Drawing.Point(42, 211);
            this.allInfoListView.Name = "allInfoListView";
            this.allInfoListView.Size = new System.Drawing.Size(345, 167);
            this.allInfoListView.TabIndex = 6;
            this.allInfoListView.UseCompatibleStateImageBehavior = false;
            this.allInfoListView.View = System.Windows.Forms.View.Details;
            this.allInfoListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allInfoListView_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // contactColumn
            // 
            this.contactColumn.Text = "Contact";
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            // 
            // addAllButton
            // 
            this.addAllButton.Location = new System.Drawing.Point(272, 182);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Size = new System.Drawing.Size(115, 23);
            this.addAllButton.TabIndex = 7;
            this.addAllButton.Text = "Add";
            this.addAllButton.UseVisualStyleBackColor = true;
            this.addAllButton.Click += new System.EventHandler(this.addAllButton_Click);
            // 
            // clearAllFromTable
            // 
            this.clearAllFromTable.Location = new System.Drawing.Point(272, 384);
            this.clearAllFromTable.Name = "clearAllFromTable";
            this.clearAllFromTable.Size = new System.Drawing.Size(115, 23);
            this.clearAllFromTable.TabIndex = 8;
            this.clearAllFromTable.Text = "Clear All";
            this.clearAllFromTable.UseVisualStyleBackColor = true;
            this.clearAllFromTable.Click += new System.EventHandler(this.clearAllFromTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.clearAllFromTable);
            this.Controls.Add(this.addAllButton);
            this.Controls.Add(this.allInfoListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "User Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView allInfoListView;
        private System.Windows.Forms.Button addAllButton;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader contactColumn;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.Button clearAllFromTable;
    }
}

