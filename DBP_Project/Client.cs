﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DBP_Project
{
    internal class Client
    {
        Socket conn_socket;
        Socket photo_socket;
        int myPeer = 0;
        private static Client instance = new Client();
        private Client()
        {
            StartConnect();
        }
        public static Client GetInstance()
        {
            return instance;
        }

        private void StartConnect()
        { 
            conn_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conn_socket.Connect(new IPEndPoint(IPAddress.Parse("15.164.218.208"), 9997));

            // myPeer 저장
            var data = new byte[1024];
            conn_socket.Receive(data, data.Length, SocketFlags.None);
            myPeer = Int32.Parse(Encoding.UTF8.GetString(data));
            Query.GetInstance().RunQuery("UPDATE `talk`.`UserListTable` SET `peer` = '" + myPeer + "' WHERE (`id` = '"+Chat.myID+"');");
            MessageBox.Show("서버 접속 성공");
        }

        public void PhotoConnect()
        {
            photo_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            photo_socket.Connect(new IPEndPoint(IPAddress.Parse("15.164.218.208"), 9996));
        }
        public void PhotoClose()
        {
            photo_socket.Close();
        }
        private void connect()
        {
            MessageBox.Show("듣는 중");
            while (true)
            {
                // 데이터의 길이만큼 byte 배열을 생성한다.
                var data = new byte[1024];
                // 데이터를 수신한다.
                conn_socket.Receive(data, data.Length, SocketFlags.None);
                // 수신된 데이터를 UTF8인코딩으로 string 타입으로 변환 후에 콘솔에 출력한다.
                MessageBox.Show("카톡이 왔습니다.\n" + Encoding.UTF8.GetString(data));

                if(Chat.instance.InvokeRequired)
                {
                    // 카톡 그리기 호출해야함, 지금 상태는 고정 상대
                    Chat.instance.BeginInvoke(new Action(() => Chat.instance.RecieveMsg()));
                }
            }
        }

        public void StartListen()
        {
            Thread thread1 = new Thread(connect); // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.
        }
        public void SendMsg(string str)
        {
            // 보낼 메시지를 UTF8타입의 byte 배열로 변환한다.
            var data = Encoding.UTF8.GetBytes(str);
            // 데이터를 전송한다.
            conn_socket.Send(data);
        }
        public void SendByte(byte[] _data)
        {
            photo_socket.Send(_data);
        }
        public void SendByte(string _data)
        {
            // 보낼 메시지를 UTF8타입의 byte 배열로 변환한다.
            var data = Encoding.UTF8.GetBytes(_data);
            photo_socket.Send(data);
            photo_socket.Close();
        }

    }
}
