using UnityEngine; // �ޥ� unity���� �R�W�Ŷ� (API)

namespace Parkour
{
    /* unity �Nc#�Ź��ܦ����骫��G
     * 1 �����W���C������(Game Object/�Ǧ���)
     * 2 �N�}�����b����W�ܦ�����(Add Component)
     */

    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�Ωһݪ����

        /*[SerializeField] �ǦC�����G�N�p�H���'���'
         * Header ���D
         * Tooltip ���ܡG�ƹ���а��d�b�W������
         * Range �d��G���ͼƭȩԱ�(�ȥi�ϥμƭ�������Ʀp int, float, byte, long)
         */
        
        [SerializeField, Header("�]�B�t��"), Tooltip("�ӪŤH���]�B�t��"), Range(0,100)]
        private float speedRun = 3.5f;
        
        [SerializeField, Header("���D����"), Tooltip("�ӪŤH�����D����"), Range(0, 100)]
        private float heightJump = 350;
        
        private Animator anir;
        
        private Rigidbody2D rig;

        #endregion



        #region �\��G�B�@�һݪ�������k

        #endregion



        #region �ƥ�G�{���J�f

        private void Start()
        {
            print("���w���w");
        }

        #endregion

    }
}


