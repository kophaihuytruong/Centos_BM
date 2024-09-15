
namespace CentosBM.UserControls
{
    partial class CategoriesItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.59091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.59091F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCategoriesName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 70);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnEditing
            // 
            this.btnEditing.BackColor = System.Drawing.Color.Black;
            this.btnEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditing.FlatAppearance.BorderSize = 0;
            this.btnEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditing.ForeColor = System.Drawing.Color.White;
            this.btnEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditing.Location = new System.Drawing.Point(507, 12);
            this.btnEditing.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(116, 46);
            this.btnEditing.TabIndex = 34;
            this.btnEditing.Text = "Edit";
            this.btnEditing.UseVisualStyleBackColor = false;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DeepPink;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(371, 12);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(114, 46);
            this.btnDetails.TabIndex = 33;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCategoriesName.ForeColor = System.Drawing.Color.Black;
            this.labelCategoriesName.Location = new System.Drawing.Point(0, 0);
            this.labelCategoriesName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(360, 70);
            this.labelCategoriesName.TabIndex = 31;
            this.labelCategoriesName.Text = "Gạch";
            this.labelCategoriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoriesItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CategoriesItems";
            this.Size = new System.Drawing.Size(640, 79);
            this.Load += new System.EventHandler(this.CategoriesItems_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label labelCategoriesName;
    }
}
