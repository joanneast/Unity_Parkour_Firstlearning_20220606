using UnityEngine;

namespace Parkour
{
    /// <summary>
    /// (練習用) API 靜態的使用方式
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
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
            int camcount = Camera.allCamerasCount;
            print("目前攝影機：" + camcount + "台");

            //顯示遊戲平台
            

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

            #endregion
        }
    }
}

