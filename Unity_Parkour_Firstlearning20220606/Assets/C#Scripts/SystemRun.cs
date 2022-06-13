using UnityEngine; // 引用 unity引擎 命名空間 (API)

namespace Parkour
{
    /* unity 將c#藍圖變成實體物件：
     * 1 場景上的遊戲物件(Game Object/灰色方塊)
     * 2 將腳本掛在物件上變成元件(Add Component)
     */

    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料：保存系統所需的資料

        /*[SerializeField] 序列化欄位：將私人欄位'顯示'
         * Header 標題
         * Tooltip 提示：滑鼠游標停留在上方時顯示
         * Range 範圍：產生數值拉桿(僅可使用數值類型資料如 int, float, byte, long)
         */
        
        [SerializeField, Header("跑步速度"), Tooltip("太空人的跑步速度"), Range(0,100)]
        private float speedRun = 3.5f;
        
        [SerializeField, Header("跳躍高度"), Tooltip("太空人的跳躍高度"), Range(0, 100)]
        private float heightJump = 350;
        
        private Animator anir;
        
        private Rigidbody2D rig;

        #endregion



        #region 功能：運作所需的複雜方法

        #endregion



        #region 事件：程式入口

        private void Start()
        {
            print("挖庫挖庫");
        }

        #endregion

    }
}


