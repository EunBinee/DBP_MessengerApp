using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    class User_info
    {
        // 로그인을 한 유저의 정보를 모아둔 클래스
        private string name;
        private string nickName;
        private string id;
        private int role;     // 1 관리자, 2 사원
        private string profilePic;


        //생성자
        public User_info(string name, string nickName, string id, int role, string profilePic)
        {
            this.name = name;
            this.nickName = nickName;
            this.id = id;
            this.role = role;
            this.profilePic = profilePic;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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

        public int Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
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
