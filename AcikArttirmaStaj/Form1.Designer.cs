namespace AcikArttirmaStaj
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgrwProductList = new DataGridView();
            btnGiveOffer = new Button();
            tbxOffer = new TextBox();
            tbxProductId = new TextBox();
            lblProductId = new Label();
            lblOffer = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrwProductList).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgrwProductList
            // 
            dgrwProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwProductList.Location = new Point(12, 12);
            dgrwProductList.Name = "dgrwProductList";
            dgrwProductList.RowHeadersWidth = 51;
            dgrwProductList.Size = new Size(776, 185);
            dgrwProductList.TabIndex = 1;
            // 
            // btnGiveOffer
            // 
            btnGiveOffer.Location = new Point(224, 279);
            btnGiveOffer.Name = "btnGiveOffer";
            btnGiveOffer.Size = new Size(125, 29);
            btnGiveOffer.TabIndex = 2;
            btnGiveOffer.Text = "Teklif ver";
            btnGiveOffer.UseVisualStyleBackColor = true;
            btnGiveOffer.Click += btnGiveOffer_Click;
            // 
            // tbxOffer
            // 
            tbxOffer.Location = new Point(224, 246);
            tbxOffer.Name = "tbxOffer";
            tbxOffer.Size = new Size(125, 27);
            tbxOffer.TabIndex = 3;
            // 
            // tbxProductId
            // 
            tbxProductId.Location = new Point(224, 214);
            tbxProductId.Name = "tbxProductId";
            tbxProductId.Size = new Size(125, 27);
            tbxProductId.TabIndex = 4;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(161, 217);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(57, 20);
            lblProductId.TabIndex = 5;
            lblProductId.Text = "Ürün Id";
            // 
            // lblOffer
            // 
            lblOffer.AutoSize = true;
            lblOffer.Location = new Point(168, 253);
            lblOffer.Name = "lblOffer";
            lblOffer.Size = new Size(44, 20);
            lblOffer.TabIndex = 6;
            lblOffer.Text = "Teklif";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOffer);
            Controls.Add(lblProductId);
            Controls.Add(tbxProductId);
            Controls.Add(tbxOffer);
            Controls.Add(btnGiveOffer);
            Controls.Add(dgrwProductList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgrwProductList;
        private Button btnGiveOffer;
        private TextBox tbxOffer;
        private TextBox tbxProductId;
        private Label lblProductId;
        private Label lblOffer;
    }
}
