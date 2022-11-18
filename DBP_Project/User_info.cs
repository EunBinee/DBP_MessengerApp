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

        private string id;
        private string password;
        private string name;
        private string nickName;
        private int role;     // 1 관리자, 2 사원

        private string zipCode;
        private string address;

        private string profilePic;

        //유저외의 다른 사원들을 저장한다.
        private List<Employee> employees = new List<Employee>();
        
        private static User_info instance = new User_info();
        //생성자
        private User_info()
        {

        }

        //나중에 로그인 후, 회원정보 변경할때 쓸 생성자
        public User_info(string id, string password, string name, string nickName, int role, string zipCode, string address, string profilePic)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.nickName = nickName;
            this.role = role;
            this.zipCode = zipCode;
            this.address = address;
            this.profilePic = profilePic;
        }

        public static User_info GetInstance()
        {
            return instance;
        }

        //편하게 쓰기위한.. 겟터와 세터..
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
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
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
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
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
