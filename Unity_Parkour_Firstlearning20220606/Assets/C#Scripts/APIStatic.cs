using UnityEngine;

namespace Parkour
{
    /// <summary>
    /// (練習用) API 靜態的使用方式
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region 學習
            /*
             * 取得靜態屬性 get
             */

            // 產生隨機值(0-1之間)
            print("今天出貨了沒：" + Random.value);

            //計算圓周率
            print("π：" + Mathf.PI);

            //計算無限大
            print("無限大：" + Mathf.Infinity);



            /*
             * 設定靜態屬性 set (read only)
             */

            // 隱藏滑鼠(布林值=false)
            Cursor.visible = false;

            //調整重力
            Physics2D.gravity = new Vector2(0, -4.6f);

            //調整時間
            Time.timeScale = 3f;

            /*
             * 使用靜態方法
             */

            //取得隨機範圍 float
            float range = Random.Range(-10.0f, 15.2f);
            print("隨機範圍："+range);
            #endregion

            #region 練習

            // 計算所有攝影機數量
            print("目前攝影機：" + Camera.allCamerasCount + "台");

            //顯示遊戲平台
            print("目前遊戲平台：" + Application.platform);

            //3D物理睡眠臨界值設定為10
            Physics.sleepThreshold = 10;
            print("物理睡眠臨界值：" + Physics.sleepThreshold);

            //時間大小設定為0.5(慢動作)
            Time.timeScale = 0.5f;
            print("時間速度：" + Time.timeScale);

            //對9.999去小數點
            print("對9.999四捨五入：" + Mathf.Round(9.999f));

            //取得兩點的距離
            float distance = Vector3.Distance(a,b);
            print("ab點之間距離：" + distance);

            //開啟連結
            Application.OpenURL("https://unity.com/");

            #endregion
        }

        private void Update()
        {
            #region 學習
            /*
             * 使用靜態方法
            */

            //取得隨機範圍 int
            int rangeInt = Random.Range(1, 3);
            print("隨機範圍1-3：" + rangeInt);
            #endregion

            #region 練習
            //是否輸入任意鍵
            //print("是否輸入任意鍵：" + Input.anyKeyDown);

            //遊戲經過時間
            //print("遊戲經過時間：" + Time.timeSinceLevelLoad);

            //是否按下空白鍵
            print("是否按下空白鍵：" + Input.GetKeyDown(KeyCode.Space));

            #endregion
        }
    }
}

