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

        [SerializeField, Header("跑步速度"), Tooltip("太空人的跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跑步動畫參數")]
        private string swRun = "swRun";

        private Animator anir;
        private Rigidbody2D rig;
        private bool clickRun;
        private SpriteRenderer spr;

        #endregion


        /// <summary>
        /// 跑步功能
        /// </summary>
        #region 功能：實作該系統的複雜方法
        private void Run()
        {
            //print("跑步中");
            float h = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(speedRun * h * 1.5F, rig.velocity.y);
        }
        #endregion



        #region 事件：程式入口

        // Awake：喚醒事件：載入遊戲前執行一次，用於取得元件等等
        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            spr = GetComponent<SpriteRenderer>();
        }


        // Start：開始事件：播放遊戲時執行一次
        private void Start()
        {
            //print("挖庫挖庫");
        }

        // Update：更新事件：每秒執行約六十次 =60FPS(Frame Per Secend)
        private void Update()
        {
            //print("<color=yellow>歐拉歐拉更新拳</color>");

            Run();
            UpdateAnimator();
            RunKey();
            UpdateAnimator();
        }

        //此元件被勾選時執行一次
        private void OnEnable()
        {

        }

        //此元件被取消勾選時執行一次
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }

        private void RunKey()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                clickRun = true;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                clickRun = false;
            }

            if (rig.velocity.x > 0.1f)
            {
                spr.flipX = false;
            }
            if (rig.velocity.x < -0.1f)
            {
                spr.flipX = true;
            }
        }

        private void UpdateAnimator()
        {
            anir.SetBool(swRun, clickRun);
        }

        #endregion

    }
}


