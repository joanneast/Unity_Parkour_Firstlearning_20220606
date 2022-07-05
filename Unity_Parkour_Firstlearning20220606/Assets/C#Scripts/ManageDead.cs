using UnityEngine;

namespace Parkour
{
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�ӪŤH";
        [SerializeField, Header("�����޲z��")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM��v�������")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("�ӪŤH"))
            {
                goCM.SetActive(false);
                manageFinal.finaltitle = "GAME OVER";
                manageFinal.enabled = true;
            }
        }

    }

}
