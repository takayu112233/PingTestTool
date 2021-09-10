using System;
using System.Configuration;
using System.Windows.Forms;

namespace PingTestTool
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int fontsize = int.Parse(ConfigurationManager.AppSettings["FontSize"]);

            if (int.Parse(ConfigurationManager.AppSettings["UseConfig"]) == 1)
            {
                StartMenu startmenu = new StartMenu();
                startmenu.ShowDialog();
                if (startmenu.start)
                {
                    //前回設定でつなぐ場合
                    startmenu.Dispose();
                    Main main = new Main(true ,fontsize);
                    main.ShowDialog();
                }
                else
                {
                    //前回設定を使わない場合
                    startmenu.Dispose();
                    Setting setting = new Setting();
                    setting.ShowDialog();
                    if (setting.save == 0)
                    {
                        //終了
                    }
                    else
                    {
                        //設定を変更し接続
                        Main main = new Main(false ,fontsize);
                        main.ShowDialog();
                        setting.Dispose();
                    }
                }
            }
            else
            {
                //初回起動時
                Setting setting = new Setting();
                setting.ShowDialog();
                if (setting.save == 0)
                {
                    //終了
                }
                else
                {
                    //設定を変更し接続
                    Main main = new Main(false, fontsize);
                    main.ShowDialog();
                    setting.Dispose();
                }
            }
        }
    }
}
