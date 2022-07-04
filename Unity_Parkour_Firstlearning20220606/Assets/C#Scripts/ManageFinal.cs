using UnityEngine;
using UnityEngine.SceneManagement;  //引用場景管理api
using TMPro;    //引用新版text資料庫

/// <summary>
/// 管理結束畫面
/// 過關與失敗
/// </summary>
namespace Parkour 
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textfinal;

        public string finaltitle;


        private void Start()
        {
            textfinal.text = finaltitle;

            //MonoBehaviour類別api可以直接用名稱呼叫
            InvokeRepeating("FadeIn", 0.2f, 0.1f);
        }

        //結束選單營造淡入效果
        private void FadeIn()
        {
            groupfinal.alpha += 0.1f;

            print("淡入淡入淡入");

            if (groupfinal.alpha >= 1)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }

        /*按鈕與程式溝通方式
         * 1 定義公開方法
         * 2 button on click 設定此腳本的公開方法
         */
        public void Quit()
        {
            print("離開遊戲");

            //只在發布執行檔後 終端機上有用
            Application.Quit();
        }

        public void Restart()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}


