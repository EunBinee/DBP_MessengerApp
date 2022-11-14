using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DBP_Project
{
    class Sha265
    {
        //비밀번호를 암호화 합니다...
        private static Sha265 instance = new Sha265();
        
        public static Sha265 GetInstance()
        {
            return instance;
        }

        public string SHA256_password(string password)
        {
            //입력한 비밀번호를 바이트배열로 변환
            byte[] array = Encoding.Default.GetBytes(password);
            byte[] hashValue;
            string result = string.Empty;

            //바이트배열을 암호화된 32byte 해쉬값으로 생성
            using (SHA256 mySHA256 = SHA256.Create())
            {
                hashValue = mySHA256.ComputeHash(array);
            }
            //32byte 해쉬값을 16진수로변환하여 64자리로 만듬
            for (int i = 0; i < hashValue.Length; i++)
            {
                result += hashValue[i].ToString("x2");
            }
            return result;
        }

    }
}
