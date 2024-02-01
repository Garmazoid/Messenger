using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace Messenger
{
    public partial class Form1 : Form
    {
        public IPAddress ip;
        public IPEndPoint ep;
        public Socket s;

        private string login = "";
        private TabPage MesTabBU;
        private TabPage FriendsTabBU;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ip = IPAddress.Parse("127.0.0.1");
            ep = new IPEndPoint(ip, 1024);

            MesTabBU = MesTab; // запоминаем вкладку которую хотим скрыть
            FriendsTabBU = FriendsTab; // запоминаем вкладку которую хотим скрыть
            tabControl1.TabPages.RemoveAt(1); // удаляем ее из коллекции
            tabControl1.TabPages.RemoveAt(1); // удаляем ее из коллекции

            updateUserList();
        }

        private void Registrarion_Click(object sender, EventArgs e)
        {
            // проверочка
            if (loginRegistr.Text == "" || passwordRegistr.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Вы не запонили поля.");
                return;
            }


            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "Registration|" + loginRegistr.Text + "|" + passwordRegistr.Text;
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    if (receivedMessage == "True")
                    {
                        loginVhod.Text = "";
                        passwordVhod.Text = "";
                        System.Windows.Forms.MessageBox.Show("Регистрация прошла успешно!");
                    }
                    else if (receivedMessage == "False")
                        System.Windows.Forms.MessageBox.Show("Такой пользователь уже зарегистрирован!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            // проверочка
            if (loginVhod.Text == "" || passwordVhod.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Вы не запонили поля.");
                return;
            }


            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string receivedMessage = "";
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "Vhod|" + loginVhod.Text + "|" + passwordVhod.Text;
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    
                    if (receivedMessage == "True") // мы вошли
                    {
                        if (login == "") // добавляем вкладочки
                        {
                            tabControl1.TabPages.Add(MesTabBU);
                            tabControl1.TabPages.Add(FriendsTabBU);
                        }

                        login = loginVhod.Text; // сохраняем логин
                        statusLabel.Text = login;

                        loginVhod.Text = "";
                        passwordVhod.Text = "";

                        System.Windows.Forms.MessageBox.Show("Вход выполнен успешно!");
                    }
                    else if (receivedMessage == "False")
                        System.Windows.Forms.MessageBox.Show("Вход не выполнен!\nНеверный логин или пароль.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
            if (receivedMessage == "True")
            {
                requestBox.Text = "";
                updateFriendList();
                updateRequestList();
            }
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            login = "";
            tabControl1.TabPages.RemoveAt(1);
            tabControl1.TabPages.RemoveAt(1);
            statusLabel.Text = "не авторизован";

            System.Windows.Forms.MessageBox.Show("Вы вышли из аккаунта.");
        }



        private void updateUserListBut_Click(object sender, EventArgs e)
        {
            updateUserList();
        }
        private void updateUserList()
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "UserList|" + "-_-" + "|" + "-_-";
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    userList.Items.Clear();
                    foreach (string user in receivedMessage.Split('|'))
                    {
                        userList.Items.Add(user);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
        }

        private void updateFriendListBut_Click(object sender, EventArgs e)
        {
            updateFriendList();
        }
        private void updateFriendListBut1_Click(object sender, EventArgs e)
        {
            updateFriendList();
        }
        private void updateFriendList()
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "FriendList|" + login + "|" + "-_-";
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    friendList.Items.Clear();
                    foreach (string user in receivedMessage.Split('|'))
                    {
                        friendList.Items.Add(user);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

            friendList1.Items.Clear();
            foreach (string elem in friendList.Items)
                friendList1.Items.Add(elem);
        }

        private void userList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (userList.SelectedIndex != -1)
                requestBox.Text = userList.Items[userList.SelectedIndex].ToString();
        }
        private void friendList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (friendList.SelectedIndex != -1)
                requestBox.Text = friendList.Items[friendList.SelectedIndex].ToString();
        }
        private void requestList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (requestList.SelectedIndex != -1)
                requestBox.Text = requestList.Items[requestList.SelectedIndex].ToString();
        }

        private void sendRequestBut_Click(object sender, EventArgs e)
        {
            if (requestBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Вы не запонили поле.");
                return;
            }


            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "AddRequest|" + login + "|" + requestBox.Text;
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    if (receivedMessage == "True")
                    {
                        System.Windows.Forms.MessageBox.Show("Заявка отправлена.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

            updateRequestList();
            updateFriendList();
        }
        private void deleteRequestBut_Click(object sender, EventArgs e)
        {
            if (requestBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Вы не запонили поле.");
                return;
            }

            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "DeleteRequest|" + login + "|" + requestBox.Text;
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

            updateFriendList();
            updateRequestList();
        }
        private void updateRequestList()
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "RequestList|" + login + "|" + "-_-";
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    requestList.Items.Clear();
                    foreach (string user in receivedMessage.Split('|'))
                    {
                        requestList.Items.Add(user);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
        }

        private void friendList1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updateFriendList1();
        }
        private void updateFriendList1()
        {
            if (friendList1.SelectedIndex == -1)
                return;

            chatLabel.Text = "чат с: " + friendList1.Items[friendList1.SelectedIndex];

            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = "Messages|" + login + "|" + friendList1.Items[friendList1.SelectedIndex];
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    chatBox.Text = receivedMessage;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения.");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
        }

        private void sendMessageBut_Click(object sender, EventArgs e)
        {
            // проверочка
            if (MessageBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Вы не запонили поля.");
                return;
            }


            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ep);
                if (s.Connected)
                {
                    string messageToSend = login + "|" + friendList1.Items[friendList1.SelectedIndex] + "|" + MessageBox.Text;
                    byte[] messageBytes = Encoding.ASCII.GetBytes(messageToSend);
                    s.Send(messageBytes);

                    byte[] buffer = new byte[1024];
                    int bytesRead = s.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }
            }
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

            updateFriendList1();
        }
    }
}
