using UnityEngine;

/// <summary>
/// �D�R�AAPI
/// �u�౱��s�b���骺�C������
/// </summary>

namespace Parkour
{
    public class APINonStatic : MonoBehaviour
    {
        /*
         * �����G
         * ���@�w�q���A������������O
         * ���@UNITY�ݩʭ��O�����T�w����줣�O�ŭ�(NONE)
         * ���@�ϥΫD�R�AAPI
         */

        [SerializeField]
        private GameObject astronunt;
        [SerializeField]
        private Transform startPoint;
 
        private void Start()
        {
            #region ���o �D�R�A�ݩ�
            print("�ӪŤH���Ұʪ��A" + astronunt.activeInHierarchy);
            print("�ӪŤH���w�]�ϼh" + astronunt.layer);
            print("�_�I�y��"+startPoint.position);
            #endregion

            #region �]�w �D�R�A�ݩ�
            astronunt.tag = "Player";
            astronunt.layer = 4;
            startPoint.position = new Vector3(0, 2, 0);
            #endregion

            #region �ϥ� �D�R�A��k
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



