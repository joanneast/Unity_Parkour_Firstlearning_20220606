using UnityEngine;

/// <summary>
/// 管理通關
/// </summary>
namespace Parkour
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "太空人";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemJump;
        [SerializeField, Header("遊戲結束管理器")]
        private ManageFinal manageFinal;

        #region 只有一個物件開is trigger
        //兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);

            if (collision.name.Contains(nameTarget))
            {
                systemJump.enabled = false;
                systemRun.enabled = false;
                manageFinal.enabled = true;
                manageFinal.finaltitle = "GAME OVER";
            }
        }
        //兩個物件碰撞結束(離開)時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        //兩個物件碰撞重疊時持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region 兩個物件都沒有開is trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
        #endregion
    }
}