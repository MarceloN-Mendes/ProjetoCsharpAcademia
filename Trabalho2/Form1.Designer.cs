namespace Trabalho2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labe1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoManha = new System.Windows.Forms.RadioButton();
            this.rdoNoite = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTarde = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstSelc = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAllBack = new System.Windows.Forms.Button();
            this.btnAllTransf = new System.Windows.Forms.Button();
            this.btnTransf = new System.Windows.Forms.Button();
            this.lstTodos = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.txtCort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(22, 20);
            this.labe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(38, 13);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Nome:";
            this.labe1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 18);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 48);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Período";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdoManha
            // 
            this.rdoManha.AutoSize = true;
            this.rdoManha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoManha.Location = new System.Drawing.Point(7, 13);
            this.rdoManha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoManha.Name = "rdoManha";
            this.rdoManha.Size = new System.Drawing.Size(69, 21);
            this.rdoManha.TabIndex = 7;
            this.rdoManha.TabStop = true;
            this.rdoManha.Text = "Manhã";
            this.rdoManha.UseVisualStyleBackColor = true;
            this.rdoManha.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoNoite
            // 
            this.rdoNoite.AutoSize = true;
            this.rdoNoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNoite.Location = new System.Drawing.Point(406, 13);
            this.rdoNoite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNoite.Name = "rdoNoite";
            this.rdoNoite.Size = new System.Drawing.Size(59, 21);
            this.rdoNoite.TabIndex = 8;
            this.rdoNoite.TabStop = true;
            this.rdoNoite.Text = "Noite";
            this.rdoNoite.UseVisualStyleBackColor = true;
            this.rdoNoite.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoTarde);
            this.panel1.Controls.Add(this.rdoNoite);
            this.panel1.Controls.Add(this.rdoManha);
            this.panel1.Location = new System.Drawing.Point(9, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 43);
            this.panel1.TabIndex = 10;
            // 
            // rdoTarde
            // 
            this.rdoTarde.AutoSize = true;
            this.rdoTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTarde.Location = new System.Drawing.Point(206, 13);
            this.rdoTarde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTarde.Name = "rdoTarde";
            this.rdoTarde.Size = new System.Drawing.Size(64, 21);
            this.rdoTarde.TabIndex = 9;
            this.rdoTarde.TabStop = true;
            this.rdoTarde.Text = "Tarde";
            this.rdoTarde.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstSelc);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnAllBack);
            this.panel2.Controls.Add(this.btnAllTransf);
            this.panel2.Controls.Add(this.btnTransf);
            this.panel2.Controls.Add(this.lstTodos);
            this.panel2.Location = new System.Drawing.Point(9, 147);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 162);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lstSelc
            // 
            this.lstSelc.Enabled = false;
            this.lstSelc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelc.FormattingEnabled = true;
            this.lstSelc.ItemHeight = 20;
            this.lstSelc.Location = new System.Drawing.Point(290, 15);
            this.lstSelc.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.lstSelc.Name = "lstSelc";
            this.lstSelc.Size = new System.Drawing.Size(170, 124);
            this.lstSelc.TabIndex = 5;
            this.lstSelc.SelectedIndexChanged += new System.EventHandler(this.lstSelc_SelectedIndexChanged);
            this.lstSelc.DoubleClick += new System.EventHandler(this.button6_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(206, 54);
            this.btnBack.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 19);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAllBack
            // 
            this.btnAllBack.Enabled = false;
            this.btnAllBack.Location = new System.Drawing.Point(206, 130);
            this.btnAllBack.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnAllBack.Name = "btnAllBack";
            this.btnAllBack.Size = new System.Drawing.Size(62, 19);
            this.btnAllBack.TabIndex = 3;
            this.btnAllBack.Text = "<<";
            this.btnAllBack.UseVisualStyleBackColor = true;
            this.btnAllBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAllTransf
            // 
            this.btnAllTransf.Enabled = false;
            this.btnAllTransf.Location = new System.Drawing.Point(206, 92);
            this.btnAllTransf.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnAllTransf.Name = "btnAllTransf";
            this.btnAllTransf.Size = new System.Drawing.Size(62, 19);
            this.btnAllTransf.TabIndex = 2;
            this.btnAllTransf.Text = ">>";
            this.btnAllTransf.UseVisualStyleBackColor = true;
            this.btnAllTransf.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTransf
            // 
            this.btnTransf.Enabled = false;
            this.btnTransf.Location = new System.Drawing.Point(206, 15);
            this.btnTransf.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(62, 19);
            this.btnTransf.TabIndex = 1;
            this.btnTransf.Text = ">";
            this.btnTransf.UseVisualStyleBackColor = true;
            this.btnTransf.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstTodos
            // 
            this.lstTodos.Enabled = false;
            this.lstTodos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTodos.FormattingEnabled = true;
            this.lstTodos.ItemHeight = 20;
            this.lstTodos.Items.AddRange(new object[] {
            "Ginástica Ritmica",
            "Hidroginástica",
            "Musculação",
            "Natação",
            "Patinação",
            "Pilates",
            "RPM",
            "Squash",
            "Karatê",
            "Muay Thai",
            "Cross Fit"});
            this.lstTodos.Location = new System.Drawing.Point(11, 15);
            this.lstTodos.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.lstTodos.Name = "lstTodos";
            this.lstTodos.Size = new System.Drawing.Size(170, 124);
            this.lstTodos.TabIndex = 0;
            this.lstTodos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            this.lstTodos.DoubleClick += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 392);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 32);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(92, 392);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 32);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modalidades";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPag);
            this.panel3.Controls.Add(this.txtCort);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtQuant);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(9, 328);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 59);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtPag
            // 
            this.txtPag.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPag.ForeColor = System.Drawing.Color.Red;
            this.txtPag.Location = new System.Drawing.Point(518, 21);
            this.txtPag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(98, 26);
            this.txtPag.TabIndex = 20;
            this.txtPag.Text = "0,00";
            this.txtPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPag.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCort
            // 
            this.txtCort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCort.ForeColor = System.Drawing.Color.Red;
            this.txtCort.Location = new System.Drawing.Point(272, 21);
            this.txtCort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCort.Name = "txtCort";
            this.txtCort.Size = new System.Drawing.Size(97, 26);
            this.txtCort.TabIndex = 17;
            this.txtCort.Text = "0";
            this.txtCort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCort.TextChanged += new System.EventHandler(this.txtCort_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Valor a pagar (R$)";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.ForeColor = System.Drawing.Color.Red;
            this.txtQuant.Location = new System.Drawing.Point(95, 20);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(98, 26);
            this.txtQuant.TabIndex = 15;
            this.txtQuant.Text = "0";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuant.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cortesia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resumo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(483, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 118);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chk5);
            this.panel4.Controls.Add(this.chk4);
            this.panel4.Controls.Add(this.chk3);
            this.panel4.Controls.Add(this.chk2);
            this.panel4.Controls.Add(this.chk1);
            this.panel4.Location = new System.Drawing.Point(487, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 162);
            this.panel4.TabIndex = 18;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Enabled = false;
            this.chk5.Location = new System.Drawing.Point(13, 132);
            this.chk5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(88, 17);
            this.chk5.TabIndex = 4;
            this.chk5.Text = "Cromoterapia";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Enabled = false;
            this.chk4.Location = new System.Drawing.Point(13, 103);
            this.chk4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(74, 17);
            this.chk4.TabIndex = 3;
            this.chk4.Text = "Feng Shui";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Enabled = false;
            this.chk3.Location = new System.Drawing.Point(13, 74);
            this.chk3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(93, 17);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "Tai Chi Chuan";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Enabled = false;
            this.chk2.Location = new System.Drawing.Point(13, 45);
            this.chk2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(76, 17);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "Meditação";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Enabled = false;
            this.chk1.Location = new System.Drawing.Point(13, 15);
            this.chk1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(51, 17);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "Yoga";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(500, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "cortesia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 426);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoManha;
        private System.Windows.Forms.RadioButton rdoNoite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoTarde;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAllBack;
        private System.Windows.Forms.Button btnAllTransf;
        private System.Windows.Forms.Button btnTransf;
        private System.Windows.Forms.ListBox lstSelc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.TextBox txtCort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk5;
    }
}

