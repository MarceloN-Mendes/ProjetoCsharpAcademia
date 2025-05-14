using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNome.TextChanged += atvCaixas;
            txtEmail.TextChanged += atvCaixas;
            rdoManha.CheckedChanged += atvCaixas;
            rdoTarde.CheckedChanged += atvCaixas;
            rdoNoite.CheckedChanged += atvCaixas;

            btnAllBack.Click += atvBtnTranfs;
            btnAllTransf.Click += atvBtnTranfs;
            btnBack.Click += atvBtnTranfs;
            btnTransf.Click += atvBtnTranfs;
            lstSelc.DoubleClick += atvBtnTranfs;
            lstTodos.DoubleClick += atvBtnTranfs;

            btnAllBack.Click += calcPag;
            btnAllTransf.Click += calcPag;
            btnBack.Click += calcPag;
            btnTransf.Click += calcPag;
            lstSelc.DoubleClick += calcPag;
            lstTodos.DoubleClick += calcPag;
            rdoManha.CheckedChanged += calcPag;
            rdoTarde.CheckedChanged += calcPag;
            rdoNoite.CheckedChanged += calcPag;

            this.FormClosing += Form1_FormClosing;
        }

        public int boxChk;



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                foreach (var item in lstTodos.Items)
                {
                    lstSelc.Items.Add(item);
                }
                lstTodos.Items.Clear();
                txtQuant.Text = lstSelc.Items.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Selecione uma opção!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lstSelc.Items)
                {
                    lstTodos.Items.Add(item);
                }
                lstSelc.Items.Clear();
                txtQuant.Text = lstSelc.Items.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Selecione uma opção!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
                lstSelc.Items.Add(lstTodos.SelectedItem);
                lstTodos.Items.Remove(lstTodos.SelectedItem);
                txtQuant.Text = lstSelc.Items.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Selecione uma opção!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                lstTodos.Items.Add(lstSelc.SelectedItem);
                lstSelc.Items.Remove(lstSelc.SelectedItem);
                txtQuant.Text = lstSelc.Items.Count.ToString();


            }
            catch {
                MessageBox.Show("Selecione uma opção!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstSelc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void atvCaixas(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) && (rdoManha.Checked || rdoTarde.Checked || rdoNoite.Checked))
            {
                lstTodos.Enabled = true;
                lstSelc.Enabled = true;
                btnAllBack.Enabled = true;
                btnAllTransf.Enabled = true;
                btnBack.Enabled = true;
                btnTransf.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                chk5.Enabled = true;
            } else
            {
                lstTodos.Enabled = false;
                lstSelc.Enabled = false;
                btnAllBack.Enabled = false;
                btnAllTransf.Enabled = false;
                btnBack.Enabled = false;
                btnTransf.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;

                foreach (var item in lstSelc.Items)
                {
                    lstTodos.Items.Add(item);
                }
                lstSelc.Items.Clear();
            }

        }
        public void atvBtnTranfs(object sender, EventArgs e)
        {
            if (lstTodos.Items.Count == 0)
            {
                btnAllBack.Enabled = true;
                btnAllTransf.Enabled = false;
                btnBack.Enabled = true;
                btnTransf.Enabled = false;
            } else if(lstSelc.Items.Count == 0)
            {
                btnAllBack.Enabled = false;
                btnAllTransf.Enabled = true;
                btnBack.Enabled = false;
                btnTransf.Enabled = true;
            } else{
                btnAllBack.Enabled = true;
                btnAllTransf.Enabled = true;
                btnBack.Enabled = true;
                btnTransf.Enabled = true;
            }
        }

        public void calcPag(object sender, EventArgs e)
        {
            double valor;

            if (int.Parse(txtQuant.Text) > 0 && int.Parse(txtQuant.Text) <= 2)
            {
                valor = 100;
            }
            else if (int.Parse(txtQuant.Text) >= 3 && int.Parse(txtQuant.Text) <= 4)
            {
                valor = 150;
            }
            else if (int.Parse(txtQuant.Text) >= 5 && int.Parse(txtQuant.Text) <= 6)
            {
                valor = 200;
            }
            else if (int.Parse(txtQuant.Text) > 6)
            {
                valor = 250;
            }
            else
            {
                valor = 0;
            }

            if (rdoTarde.Checked)
            {
                valor = valor - valor * 0.15;
            }

            txtPag.Text = valor.ToString();
        }

        private void txtCort_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == false && boxChk <= 4)
            {
                boxChk -= 1;
            }
            if (chk1.Checked == true)
            {
                boxChk += 1;
            }
            if (boxChk == 4)
            {
                chk1.Checked = false;

            }
            txtCort.Text = boxChk.ToString();


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == false && boxChk <= 4)
            {
                boxChk -= 1;
            }
            if (chk2.Checked == true)
            {
                boxChk += 1;
            }
            if (boxChk == 4)
            {
                chk2.Checked = false;

            }
            txtCort.Text = boxChk.ToString();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == false && boxChk <= 4)
            {
                boxChk -= 1;
            }
            if (chk3.Checked == true)
            {
                boxChk += 1;
            }
            if (boxChk == 4)
            {
                chk3.Checked = false;

            }
            txtCort.Text = boxChk.ToString();

        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == false && boxChk <= 4)
            {
                boxChk -= 1;
            }
            if (chk4.Checked == true)
            {
                boxChk += 1;
            }
            if (boxChk == 4)
            {
                chk4.Checked = false;

            }
            txtCort.Text = boxChk.ToString();

        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == false && boxChk <= 4)
            {
                boxChk -= 1;
            }
            if (chk5.Checked == true)
            {
                boxChk += 1;
            }
            if (boxChk == 4)
            {
                chk5.Checked = false;

            }
            txtCort.Text = boxChk.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTodos.Enabled = false;
            lstSelc.Enabled = false;
            btnAllBack.Enabled = false;
            btnAllTransf.Enabled = false;
            btnBack.Enabled = false;
            btnTransf.Enabled = false;
            chk1.Enabled = false;
            chk2.Enabled = false;
            chk3.Enabled = false;
            chk4.Enabled = false;
            chk5.Enabled = false;

            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;

            foreach (var item in lstSelc.Items)
            {
                lstTodos.Items.Add(item);
            }
            lstSelc.Items.Clear();

            txtQuant.Text = "0";
            txtPag.Text = "0,00";
            txtNome.Text = "";
            txtEmail.Text = "";
            rdoManha.Checked = false;
            rdoTarde.Checked = false;
            rdoNoite.Checked = false;
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
