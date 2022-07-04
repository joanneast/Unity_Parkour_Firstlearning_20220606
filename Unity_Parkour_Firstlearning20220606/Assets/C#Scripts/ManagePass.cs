using UnityEngine;

/// <summary>
/// �޲z�q��
/// </summary>
namespace Parkour
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�ӪŤH";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�C�������޲z��")]
        private ManageFinal manageFinal;

        #region �u���@�Ӫ���}is trigger
        //��Ӫ���I���ɰ���@��
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
        //��Ӫ���I������(���})�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        //��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region ��Ӫ��󳣨S���}is trigger
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