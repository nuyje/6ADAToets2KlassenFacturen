namespace InterfaceFactuur
{
    partial class Form1 : Form
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
            btnAanmakenFactuur = new Button();
            txtKlantNaam = new TextBox();
            txtKlantnummer = new TextBox();
            txtProduct = new TextBox();
            txtAantal = new TextBox();
            txtPrijs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstFacturen = new ListBox();
            label6 = new Label();
            label7 = new Label();
            btnFactuurLijn = new Button();
            label8 = new Label();
            txtFactuurID = new TextBox();
            lstFactuurLijnen = new ListBox();
            lblFactuurtotaal = new Label();
            SuspendLayout();
            // 
            // btnAanmakenFactuur
            // 
            btnAanmakenFactuur.Location = new Point(13, 193);
            btnAanmakenFactuur.Margin = new Padding(4, 3, 4, 3);
            btnAanmakenFactuur.Name = "btnAanmakenFactuur";
            btnAanmakenFactuur.Size = new Size(258, 27);
            btnAanmakenFactuur.TabIndex = 4;
            btnAanmakenFactuur.Text = "Maak factuur aan";
            btnAanmakenFactuur.UseVisualStyleBackColor = true;
            // 
            // txtKlantNaam
            // 
            txtKlantNaam.Location = new Point(147, 102);
            txtKlantNaam.Margin = new Padding(4, 3, 4, 3);
            txtKlantNaam.Name = "txtKlantNaam";
            txtKlantNaam.Size = new Size(116, 23);
            txtKlantNaam.TabIndex = 2;
            // 
            // txtKlantnummer
            // 
            txtKlantnummer.Location = new Point(147, 147);
            txtKlantnummer.Margin = new Padding(4, 3, 4, 3);
            txtKlantnummer.Name = "txtKlantnummer";
            txtKlantnummer.Size = new Size(116, 23);
            txtKlantnummer.TabIndex = 3;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(518, 63);
            txtProduct.Margin = new Padding(4, 3, 4, 3);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(116, 23);
            txtProduct.TabIndex = 5;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(518, 109);
            txtAantal.Margin = new Padding(4, 3, 4, 3);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(116, 23);
            txtAantal.TabIndex = 6;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(518, 153);
            txtPrijs.Margin = new Padding(4, 3, 4, 3);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(116, 23);
            txtPrijs.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Naam klant: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "Klantnummer: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Product: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 117);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Aantal: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 161);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Prijs: ";
            // 
            // lstFacturen
            // 
            lstFacturen.FormattingEnabled = true;
            lstFacturen.ItemHeight = 15;
            lstFacturen.Location = new Point(15, 251);
            lstFacturen.Margin = new Padding(4, 3, 4, 3);
            lstFacturen.Name = "lstFacturen";
            lstFacturen.Size = new Size(248, 214);
            lstFacturen.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 21);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 16;
            label6.Text = "Factuur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(386, 21);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 17;
            label7.Text = "Factuurlijn";
            // 
            // btnFactuurLijn
            // 
            btnFactuurLijn.Location = new Point(386, 197);
            btnFactuurLijn.Name = "btnFactuurLijn";
            btnFactuurLijn.Size = new Size(248, 23);
            btnFactuurLijn.TabIndex = 18;
            btnFactuurLijn.Text = "Maak factuurlijn aan";
            btnFactuurLijn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 71);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 20;
            label8.Text = "Factuur ID: ";
            // 
            // txtFactuurID
            // 
            txtFactuurID.Location = new Point(147, 63);
            txtFactuurID.Margin = new Padding(4, 3, 4, 3);
            txtFactuurID.Name = "txtFactuurID";
            txtFactuurID.Size = new Size(116, 23);
            txtFactuurID.TabIndex = 1;
            // 
            // lstFactuurLijnen
            // 
            lstFactuurLijnen.FormattingEnabled = true;
            lstFactuurLijnen.ItemHeight = 15;
            lstFactuurLijnen.Location = new Point(386, 251);
            lstFactuurLijnen.Name = "lstFactuurLijnen";
            lstFactuurLijnen.Size = new Size(248, 214);
            lstFactuurLijnen.TabIndex = 21;
            // 
            // lblFactuurtotaal
            // 
            lblFactuurtotaal.AutoSize = true;
            lblFactuurtotaal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFactuurtotaal.Location = new Point(15, 514);
            lblFactuurtotaal.Name = "lblFactuurtotaal";
            lblFactuurtotaal.Size = new Size(0, 25);
            lblFactuurtotaal.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 587);
            Controls.Add(lblFactuurtotaal);
            Controls.Add(lstFactuurLijnen);
            Controls.Add(label8);
            Controls.Add(txtFactuurID);
            Controls.Add(btnFactuurLijn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lstFacturen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(txtKlantnummer);
            Controls.Add(txtKlantNaam);
            Controls.Add(btnAanmakenFactuur);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAanmakenFactuur;
        private System.Windows.Forms.TextBox txtKlantNaam;
        private System.Windows.Forms.TextBox txtKlantnummer;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstFacturen;
        private Label label6;
        private Label label7;
        private Button btnFactuurLijn;
        private Label label8;
        private TextBox txtFactuurID;
        private ListBox lstFactuurLijnen;
        private Label lblFactuurtotaal;
    }
}

