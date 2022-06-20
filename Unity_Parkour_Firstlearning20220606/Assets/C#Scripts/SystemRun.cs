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
        
        private Animator anir;
        
        private Rigidbody2D rig;

        #endregion


        /// <summary>
        /// �]�B�\��
        /// </summary>
        #region �\��G��@�Өt�Ϊ�������k
        private void Run()
        {
            print("�]�B��");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion



        #region �ƥ�G�{���J�f

        // Awake�G����ƥ�G���J�C���e����@���A�Ω���o���󵥵�
        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }


        // Start�G�}�l�ƥ�G����C���ɰ���@��
        private void Start()
        {
            //print("���w���w");
        }

        // Update�G��s�ƥ�G�C���������Q�� =60FPS(Frame Per Secend)
        private void Update()
        {
            //print("<color=yellow>�کԼکԧ�s��</color>");

            Run();
        }

        #endregion

    }
}


