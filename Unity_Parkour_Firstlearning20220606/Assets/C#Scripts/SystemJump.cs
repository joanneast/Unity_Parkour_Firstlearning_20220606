using UnityEngine;

/// <summary>
/// ���D�t��
/// </summary>
namespace Parkour
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Tooltip("�ӪŤH�����D����"), Range(0, 100)]
        private float heightJump = 800;

        private Animator anir;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //Input API ��ĳ�bUpdate�I�s
        //�@�������60��
        private void Update()
        {
            JumpKey();
        }

        //�@��T�w����50��
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region �\��
        private void JumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���I");
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

