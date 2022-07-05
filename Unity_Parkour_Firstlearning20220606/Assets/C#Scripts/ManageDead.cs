using UnityEngine;

namespace Parkour
{
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "太空人";
        [SerializeField, Header("結束管理器")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM攝影機控制物件")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("太空人"))
            {
                goCM.SetActive(false);
                manageFinal.finaltitle = "GAME OVER";
                manageFinal.enabled = true;
            }
        }

    }

}
