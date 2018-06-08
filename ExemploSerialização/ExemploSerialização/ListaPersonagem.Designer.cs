namespace ExemploSerialização
{
    partial class ListaPersonagem
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
            this.cbCla = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNivelChakra = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClaColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelChakraColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel de chakra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // cbCla
            // 
            this.cbCla.FormattingEnabled = true;
            this.cbCla.Items.AddRange(new object[] {
            "Otsutsuki",
            "Senju",
            "Hyuuga",
            "Uchiha",
            "Uzumaki",
            "Kazekage",
            "Sarutobi",
            "Hatake",
            "Nara",
            "Aburame"});
            this.cbCla.Location = new System.Drawing.Point(147, 33);
            this.cbCla.Name = "cbCla";
            this.cbCla.Size = new System.Drawing.Size(179, 21);
            this.cbCla.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(147, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtNivelChakra
            // 
            this.txtNivelChakra.Location = new System.Drawing.Point(147, 134);
            this.txtNivelChakra.Name = "txtNivelChakra";
            this.txtNivelChakra.Size = new System.Drawing.Size(179, 20);
            this.txtNivelChakra.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(379, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 463);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaColunn,
            this.NomeColunn,
            this.NivelChakraColunn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 159);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ClaColunn
            // 
            this.ClaColunn.HeaderText = "Clã";
            this.ClaColunn.Name = "ClaColunn";
            this.ClaColunn.ReadOnly = true;
            // 
            // NomeColunn
            // 
            this.NomeColunn.HeaderText = "Nome";
            this.NomeColunn.Name = "NomeColunn";
            this.NomeColunn.ReadOnly = true;
            // 
            // NivelChakraColunn
            // 
            this.NivelChakraColunn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NivelChakraColunn.HeaderText = "Nivel de Chakra";
            this.NivelChakraColunn.Name = "NivelChakraColunn";
            this.NivelChakraColunn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 92);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(229, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 92);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListaPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNivelChakra);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbCla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaPersonagem";
            this.Text = "ListaPersonagem";
            this.Activated += new System.EventHandler(this.ListaPersonagem_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaPersonagem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCla;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNivelChakra;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelChakraColunn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

