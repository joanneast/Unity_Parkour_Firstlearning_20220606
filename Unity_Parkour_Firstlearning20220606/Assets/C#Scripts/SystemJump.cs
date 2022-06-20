using UnityEngine;

/// <summary>
/// 跳躍系統
/// </summary>
namespace Parkour
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("太空人的跳躍高度"), Range(0, 100)]
        private float heightJump = 800;

        private Animator anir;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //Input API 建議在Update呼叫
        //一秒約執行60次
        private void Update()
        {
            JumpKey();
        }

        //一秒固定執行50次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能
        private void JumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳！");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }
}

