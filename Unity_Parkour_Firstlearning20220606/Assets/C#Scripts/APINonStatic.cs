using UnityEngine;

/// <summary>
/// 非靜態API
/// 只能控制存在實體的遊戲物件
/// </summary>

namespace Parkour
{
    public class APINonStatic : MonoBehaviour
    {
        /*
         * 必須：
         * １　定義欄位，資料類型為類別
         * ２　UNITY屬性面板必須確定該欄位不是空值(NONE)
         * ３　使用非靜態API
         */

        [SerializeField]
        private GameObject astronunt;
        [SerializeField]
        private Transform startPoint;
 
        private void Start()
        {
            #region 取得 非靜態屬性
            print("太空人的啟動狀態" + astronunt.activeInHierarchy);
            print("太空人的預設圖層" + astronunt.layer);
            print("起點座標"+startPoint.position);
            #endregion

            #region 設定 非靜態屬性
            astronunt.tag = "Player";
            astronunt.layer = 4;
            startPoint.position = new Vector3(0, 2, 0);
            #endregion

            #region 使用 非靜態方法
            astronunt.SetActive(false);
            #endregion
        }

        private void Update()
        {
            startPoint.Translate(1.5f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
        }
    }
}



