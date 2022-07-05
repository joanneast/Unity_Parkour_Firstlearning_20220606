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
        private float heightJump = 500;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3checkgroundsize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3checkgroundoffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorcheckground = new Color(145, 196, 212, 0.3f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layercheckground;
        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string swJump = "swJump";
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;

        private Animator anir;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isground;
        private AudioSource aud;
        #endregion

        #region �ƥ�

        //ø�s�ϥ�
        //�b�s�边��ø�s���U�Ϊ��u���B�Ϊ��ιϤ��A�C�������|�X�{
        private void OnDrawGizmos()
        {
            //1 �M�w�C��
            Gizmos.color = colorcheckground;
            //2 ø�s�ϥ�
            Gizmos.DrawCube(transform.position+ v3checkgroundoffset,v3checkgroundsize);
        }

        private void Awake()
        {
            anir = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }

        //Input API ��ĳ�bUpdate�I�s
        //�@�������60��
        private void Update()
        {
            JumpKey();
            CheckGround();
            UpdateAnimator();
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
                //print("���I");
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
            //print($"�I��F{touchyon}");

            isground = touchyon;
        }

        private void UpdateAnimator()
        {
            anir.SetBool(swJump, !isground);
        }

        #endregion
    }
}

