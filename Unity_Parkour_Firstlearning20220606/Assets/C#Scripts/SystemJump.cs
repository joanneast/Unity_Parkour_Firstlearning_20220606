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
        private float heightJump = 500;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3checkgroundsize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3checkgroundoffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorcheckground = new Color(145, 196, 212, 0.3f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layercheckground;
        [SerializeField, Header("跳躍動畫參數")]
        private string swJump = "swJump";
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;

        private Animator anir;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isground;
        private AudioSource aud;
        #endregion

        #region 事件

        //繪製圖示
        //在編輯器內繪製輔助用的線條、形狀或圖片，遊戲內不會出現
        private void OnDrawGizmos()
        {
            //1 決定顏色
            Gizmos.color = colorcheckground;
            //2 繪製圖示
            Gizmos.DrawCube(transform.position+ v3checkgroundoffset,v3checkgroundsize);
        }

        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }

        //Input API 建議在Update呼叫
        //一秒約執行60次
        private void Update()
        {
            JumpKey();
            CheckGround();
            UpdateAnimator();
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
                //print("跳！");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {
            if (clickJump && isground)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
                aud.PlayOneShot(soundJump, Random.Range(0.3f, 0.5f));
            }
        }

        private void CheckGround()
        {
            Collider2D touchyon = Physics2D.OverlapBox(transform.position + v3checkgroundoffset, v3checkgroundsize, 0,layercheckground);
            //print($"碰到了{touchyon}");

            isground = touchyon;
        }

        private void UpdateAnimator()
        {
            anir.SetBool(swJump, !isground);
        }

        #endregion
    }
}

