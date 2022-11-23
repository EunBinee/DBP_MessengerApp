﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    class User_info
    {
        // 로그인을 한 유저의 정보를 모아둔 클래스
        //싱글톤
        private string id;
        private string password;
        private string name;
        private string nickName;
        private int role;     // 1 관리자, 2 사원

        private string department;
        private string team;
        private string zipCode;
        private string address;

        private string profilePic;

        //유저외의 다른 사원들을 저장한다. (관리자 미포함)
        public List<Employee> employees = new List<Employee>();
        
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







        //----------------------------------------------------------------------------------------------------------------------------------
        public void GetWorkerInfo()
        {
            //사원의 정보를 불러옵니다.

            //1. 멀티프로필 확인.
            //

            //List<MultiProfile> multiProfiles = new List<MultiProfile>();

            //2. 값을 불러온다. 자기자신은 빼고

            string query = "SELECT * FROM talk.UserListTable";
            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                //만약 id가 같으면 넘어가기, role이 1이면(관리자면) 넘어가기
                if (id != row["id"].ToString() || 1 != int.Parse(row["role"].ToString()))
                {
                    string em_Id = row["password"].ToString();

                    //멀티 프로필 확인

                    string em_Name = row["name"].ToString();                      //이름
                    string em_NickName = row["nickName"].ToString();      //닉네임

                    string em_ZipCode = row["zipCode"].ToString();               //우편번호
                    string em_Address = row["userAddr"].ToString();             //주소 ( ", "로 split할 수있음)
                    string em_ProfilePic = row["profilePic"].ToString();            //프로필 사진*/

                    string em_Department = "";
                    string em_Team = "";


                    string query_ = "SELECT * FROM talk.UserDepartment WHERE `userId`=" + em_Id;

                    DataTable dt_depart = new DataTable();
                    dt_depart = Query.GetInstance().RunQuery(query_);

                    foreach (DataRow row_ in dt_depart.Rows)
                    {
                        //만약 id가 같으면 비밀번호도 확인한다.
                        em_Department = row_["departmentName"].ToString();      //부서명
                        em_Team = row_["teamName"].ToString();                           //팀명
                    }

                    employees.Add(new Employee(em_Id, em_Name, em_NickName, em_Department, em_Team, em_ProfilePic));             
                }
            }


        }

        class MultiProfile
        {
            private string id;     //user(나 : 로그인한 사람)에게 멀티 프로필을 건 사람의 사원번호(id)
            private string nickName;
            private string profilePic;

            public MultiProfile(string id, string nickName, string profilePic)
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
}
