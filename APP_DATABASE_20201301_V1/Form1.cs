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


namespace APP_DATABASE_20201301_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VID1QPA;Initial Catalog=Information_app;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty
                && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty
                && textBox7.Text != string.Empty && textBox8.Text != string.Empty && textBox9.Text != string.Empty
                && textBox10.Text != string.Empty)
                {
                    con.Open();
                    string query = "INSERT INTO Information_input (ID,FirstName,LastName,MiddleName,JobTitle,DeptID,MngrID,HireDate,Salary,AddressID)" +
                        "VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("INSERTED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty
                && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty
                && textBox7.Text != string.Empty && textBox8.Text != string.Empty && textBox9.Text != string.Empty
                && textBox10.Text != string.Empty)
                {
                    con.Open();
                    string query = "SELECT * FROM Information_input";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    MessageBox.Show("VIEW SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty
               && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty
               && textBox7.Text != string.Empty && textBox8.Text != string.Empty && textBox9.Text != string.Empty
               && textBox10.Text != string.Empty)
                {
                    con.Open();
                    string query = "UPDATE Information_input " +
                        "SET FirstName = '" + textBox2.Text + "',LastName = '" + textBox3.Text + "',MiddleName = '" + textBox4.Text + "',JobTitle = '" + textBox5.Text + "',DeptID = '" + textBox10.Text + "',MngrID = '" + textBox9.Text + "',HireDate = '" + textBox8.Text + "',Salary = '" + textBox7.Text + "',AddressID = '" + textBox6.Text + "', WHERE ID = '" + textBox1.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("UPDATE SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            MessageBox.Show("DETELE SUCCESSFULLY");
        }

    }  

}
