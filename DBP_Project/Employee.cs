using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    class Employee
    {
        //유저외 직원 (관리자 미포함
        private string id;
        private string name;
        private string nickName;

        private string department;
        private string team;

        private string profilePic;
        private string btype; //차단 타입

        public Employee(string id, string name, string nickName, string department, string team, string profilePic, string btype)
        {
            this.id = id;
            this.name = name;
            this.nickName = nickName;
            this.department = department;
            this.team = team;
            this.profilePic = profilePic;
            this.btype = btype;
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

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
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

        public string Btype
        {
            get
            {
                return btype;
            }
            set
            {
                btype = value;
            }
        }

    }
}
