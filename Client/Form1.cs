using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    public partial class Form1 : Form
    {
        bool isRefreshed = false;
        private bool isRegister = true;
        ServerService service = new ServerService();
        public Form1()
        {
            InitializeComponent();
        }

  
        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
              
        }

        private void button_changeButton_Click(object sender, EventArgs e)
        {
            isRegister = !isRegister;
            if (isRegister)
                register_button.Text = "Register";
            else
                register_button.Text = "Login";

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Person person = new Person(register_password_textBox.Text, 
                register_nick_textBox.Text, register_login_textBox.Text);

            
            try
            {
                if (isRegister)
                {
                    service.registration(person);
                    answer.Text = "User was successfully registered";
                }

                else
                {
                    service.login(person);
                    answer.Text = "User was successfully logined";
                }

                //chat_answer.Text = service.getMessages();
                    
            }catch(Exception err)
            {
                answer.Text = err.Message;
                Console.WriteLine(err.StackTrace);
            }
        }

        private void button_getUsers_Click(object sender, EventArgs e)
        {
            
            try
            {
                Person[] people = service.getUsers();
                
                StringBuilder stringBuilder = new StringBuilder();
                for(int i = 0;i < people.Length; i++)
                {
                   stringBuilder.Append(people[i].toString());
                   stringBuilder.Append("\n");
                }

                answer.Text = stringBuilder.ToString();
            }
            catch (Exception err)
            {
                answer.Text = err.Message;
                Console.WriteLine(err.StackTrace);
            }

        }

        private void send_button_Click(object sender, EventArgs e)
        {
           
            try
            {

                service.postMessage(message_TextBox.Text);
                message_answer.Text = "Message was delivered";

            }
            catch(Exception err)
            {
                message_answer.Text = err.Message;
                Console.WriteLine(err.StackTrace);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                Message[] messages = service.GetMessages();
                foreach(Message message in messages)
                {
                    stringBuilder.Append(message.ToString());
                    stringBuilder.Append('\n');
                }


                chat_answer.Text = stringBuilder.ToString();

            }
            catch (Exception err)
            {
                message_answer.Text = err.Message;
                Console.WriteLine(err.StackTrace);
            }
        }
    }
}
