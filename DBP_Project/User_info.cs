using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    class User_info
    {
        // 로그인을 한 유저의 정보를 모아둔 클래스
        //싱글톤

        
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

        //나의 멀티프로필을 저장
        private MultiProfile_Class myMultiProfile;
        public List<string> multiProfileEmployee = new List<string>();

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

        public MultiProfile_Class MyMultiProfile
        {
            get
            {
                return myMultiProfile;
            }
        }

        public void SetMyMultiProfile(string myNickname, string myProfile)
        {
            myMultiProfile.NickName = myNickname;
            myMultiProfile.ProfilePic = myProfile;
        }
        //----------------------------------------------------------------------------------------------------------------------------------

        //로그인할 때 모든 직원 정보를 읽어온다.
        public void GetWorkerInfo()
        {
            //사원의 정보를 불러옵니다.
            string query = "";
            
            //1. 멀티프로필 확인.----------------------------------------------------------------------------------------------------
            List<MultiProfile_Class> multiProfiles = new List<MultiProfile_Class>();

            query= "SELECT* FROM talk.MultiProfile where `user_id` = '"+ id + "'";
            DataTable dt_Multi = new DataTable();
            dt_Multi = Query.GetInstance().RunQuery(query);

            foreach (DataRow row_Multi in dt_Multi.Rows)
            {
                string Multi_id = row_Multi["doMultiProfile_Id"].ToString();
                string Multi_nickName = row_Multi["nickname"].ToString();
                string Multi_profile = row_Multi["profilePic"].ToString();

                multiProfiles.Add(new MultiProfile_Class(Multi_id, Multi_nickName, Multi_profile));
            }

            //2. 값을 불러온다. 자기자신과 관리자는 빼고---------------------------------------------------------------------------

            query = "SELECT * FROM talk.UserListTable where id != '" + id + "' and role =2;";
            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string em_Id = row["id"].ToString();
                bool isMulti = false;
                int multiCount = 0;
                //멀티 프로필 확인******************************************************************************************
                if (multiProfiles.Count != 0)
                {
                    foreach (var multi in multiProfiles)
                    {
                        //em_id가 같은지 확인
                        if (multi.ID == em_Id)
                        {
                            isMulti = true;
                            break;
                        }
                        multiCount++;
                    }
                }
                string em_NickName;
                string em_ProfilePic;
                if (isMulti)
                {
                    em_NickName = multiProfiles[multiCount].NickName;      //닉네임
                    em_ProfilePic = multiProfiles[multiCount].ProfilePic;         //멀티프로필 사진
                }
                else
                {
                    em_NickName = row["nickName"].ToString();           //닉네임
                    em_ProfilePic = row["profilePic"].ToString();            //프로필 사진
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
              
                string em_Name          = row["name"].ToString();                      //이름

                string em_ZipCode       = row["zipCode"].ToString();               //우편번호
                string em_Address       = row["userAddr"].ToString();             //주소 ( ", "로 split할 수있음)
                

                string em_Department = "";
                string em_Team           = "";


                //부서 확인-----------------------------------------------------------------------------------------------------------------------------------------------
                string query_ = "SELECT * FROM talk.UserDepartment WHERE `userId`='" + em_Id + "'";
                MessageBox.Show(query_);
                DataTable dt_depart = new DataTable();
                dt_depart = Query.GetInstance().RunQuery(query_);

                foreach (DataRow row_ in dt_depart.Rows)
                {
                    //만약 id가 같으면 비밀번호도 확인한다.
                    em_Department   = row_["departmentName"].ToString();                  //부서명
                    em_Team             = row_["teamName"].ToString();                           //팀명
                }

                employees.Add(new Employee(em_Id, em_Name, em_NickName, em_Department, em_Team, em_ProfilePic));
            }

        }

        //로그인할 때 나의 멀티프로필을 가지고 온다.
        //1. 내가 설정한 프로필과 별명
        //2. 내가 보여주기로 한 사람들의 리스트
        public void GetMyMultiProfile()
        {
            string query = "SELECT * FROM talk.MultiProfile where doMultiProfile_Id = '" + id + "';";

            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);

            string myProfile = "";
            string myNickname = "";
            foreach (DataRow row in dt.Rows)
            {
                myProfile = row["profilePic"].ToString();
                myNickname = row["nickname"].ToString();
                string user_id = row["user_id"].ToString();
                multiProfileEmployee.Add(user_id);
            }

            myMultiProfile = new MultiProfile_Class(id, myNickname, myProfile);
        }


           

    }
}
