using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    class MultiProfile_Class
    {
        private string id;     //user(나 : 로그인한 사람)에게 멀티 프로필을 건 사람의 사원번호(id)
        private string nickName;
        private string profilePic;

        public MultiProfile_Class()
        {

        }
        public MultiProfile_Class(string id, string nickName, string profilePic)
        {
            this.id = id;
            this.nickName = nickName;
            this.profilePic = profilePic;
        }

        //게터 세터

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }
        public string ProfilePic
        {
            get
            {
                return profilePic;
            }
            set
            {
                profilePic = value;
            }
        }
    }
}
