using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace chatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string? userName;
        StreamWriter? Writer;
        private void button1_Click(object sender, EventArgs e)
        {
            login();
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox2.Enabled = true;
            button2.Enabled = true;

        }

        async private void login()
        {
            string host = "127.0.0.1";
            int port = 8888;
            using TcpClient client = new TcpClient();

            StreamReader? Reader;
            Reader = null;
            Writer = null;
            bool histIsShowed = false;
            userName = textBox1.Text;

            try
            {
                client.Connect(host, port); //подключение клиента
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                if (Writer is null || Reader is null) return;
                await Writer.WriteLineAsync(userName);
                await Writer.FlushAsync();


                //запускаем новый поток для получения данных

                while (true)
                {

                    try
                    {


                        // считываем ответ в виде строки
                        string? message = await Reader.ReadLineAsync();

                        // если пустой ответ, ничего не выводим на консоль
                        if (string.IsNullOrEmpty(message)) continue;

                        textBox3.Text = textBox3.Text + Environment.NewLine + message;//вывод сообщения
                        if (!histIsShowed)
                        {

                            textBox3.Text = $"!!! Добро пожаловать, {userName} !!! {Environment.NewLine} _____________________________ {Environment.NewLine}";
                            histIsShowed = true;

                        }

                    }
                    catch
                    {
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            SendMessageAsync(Writer);
        }

        async Task SendMessageAsync(StreamWriter? writer)
        {
            string? message = textBox2.Text;
            textBox3.Text = textBox3.Text + Environment.NewLine + "Вы: " + message;
            textBox2.Text = "";
            await writer.WriteLineAsync(message);
            await writer.FlushAsync();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}