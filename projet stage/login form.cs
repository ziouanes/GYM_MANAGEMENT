using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace projet_stage
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();


        }

        public void Alert(string msg, msg.enmType type)
        {
            msg frm = new msg();
            frm.showAlert(msg, type);
        }



        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void log_Leave(object sender, EventArgs e)
        {
            if (log.Text == "")
            {
                log.Text = "Login";
            }
            log.ForeColor = Color.Silver;
        }

        private void log_Enter(object sender, EventArgs e)
        {
            if (log.Text == "Login")
            {
                log.Text = "";
            }
            log.ForeColor = Color.White;
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Mote de Pass")
            {
                pass.Text = "";
            }
            pass.ForeColor = Color.White;
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Mote de Pass";
            }
            pass.ForeColor = Color.Silver;
        }

        private void log_Validating(object sender, CancelEventArgs e)
        {
            //if(string.IsNullOrEmpty(log.Text)){
            //    e.Cancel = true;
            //    log.Focus();
            //    errorlog.SetError(log, "votre");


            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorlog.SetError(log, null);
            //}
        }

        private void pass_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(pass.Text))
            //{
            //    e.Cancel = true;
            //    pass.Focus();
            //    erropass.SetError(pass, "votre");


            //}
            //else
            //{
            //    e.Cancel = true;
            //    erropass.SetError(log, null);
            //}
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

            try
            {
                //if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();
                //{

                    if (log.Text == "" || pass.Text == "")
                    {
                        if (pass.Text == "")
                        {
                            erropass.SetError(pass, "Veuillez entrer votre mot de passe!");
                            ActiveControl = pass;
                        }
                        else
                            erropass.Clear();

                        if (log.Text == "")
                        {
                            errorlog.SetError(log, "Veuillez entrer votre nom d'utilisateur!");
                            ActiveControl = log;
                        }
                        else
                            errorlog.Clear();
                    }

                    else
                    {
                        Program.Connection.Open();
                        Program.Command = new SqlCommand("SELECT CONCAT(Role_admin,' ',Nom) FROM admin WHERE Login='" + log.Text + "' AND Passworld='" + pass.Text + "'", Program.Connection);
                        SqlDataReader data = Program.Command.ExecuteReader();
                        if (data.HasRows)
                        {
                        data.Read();
                        string nom = ( data[0].ToString());
                        this.Alert("bonjour "+ nom, msg.enmType.Success);
                            
                            Program.accuille = new formaccuille();
                            Program.accuille.ShowDialog();
                            data.Close();
                            Program.Connection.Close();
                            this.Close();
                        }
                        else
                        {
                            this.Alert("Incorect user or pass", msg.enmType.Warning);
                            Program.Connection.Close();
                        
                    }



                    }
                
            }
            catch (Exception x)
            {
                Program.Connection.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
