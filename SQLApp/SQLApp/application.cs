using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();

            nameField.Text = "Введите имя";

            phoneField.Text = "Введите ваш номер телефона";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`Name`, `PhoneNumber`) VALUES (@Name, @PhoneNumber)", db.getConnection());

            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = phoneField.Text;

            db.openConnection();

            MessageBox.Show("Заявка была отправлена, менеджер сейчас свяжется с вами");
           
            db.closeConnection();

        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите имя")
                nameField.Text = "";
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
                nameField.Text = "Введите имя";
        }

        private void phoneField_Enter(object sender, EventArgs e)
        {
            if (phoneField.Text == "Введите ваш номер телефона")
                phoneField.Text = "";
        }

        private void phoneField_Leave(object sender, EventArgs e)
        {
            if (phoneField.Text == "")
                phoneField.Text = "Введите ваш номер телефона";
        }
    }
}
