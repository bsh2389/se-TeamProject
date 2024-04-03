using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // UserManager 클래스를 초기화하고 해당 인스턴스에 접근
            UserManager manager = UserManager.Instance;

            Application.Run(new Main());

        }
    }
    public class UserManager
    {
        private static UserManager instance;
        private bool isLoggedIn = false;

        // 외부에서 생성자 호출 방지
        private UserManager() { }

        // 싱글톤 인스턴스 반환
        public static UserManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserManager();
                }
                return instance;
            }
        }

        // 로그인 상태 확인
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
        }

        // 로그인
        public void Login()
        {
            isLoggedIn = true;
        }

        // 로그아웃
        public void Logout()
        {
            isLoggedIn = false;
        }
    }
}
