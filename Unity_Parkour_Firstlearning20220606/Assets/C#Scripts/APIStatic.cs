using UnityEngine;

namespace Parkour
{
    /// <summary>
    /// (�m�ߥ�) API �R�A���ϥΤ覡
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region �ǲ�
            /*
             * ���o�R�A�ݩ� get
             */

            // �����H����(0-1����)
            print("���ѥX�f�F�S�G" + Random.value);

            //�p���P�v
            print("�k�G" + Mathf.PI);

            //�p��L���j
            print("�L���j�G" + Mathf.Infinity);



            /*
             * �]�w�R�A�ݩ� set (read only)
             */

            // ���÷ƹ�(���L��=false)
            Cursor.visible = false;

            //�վ㭫�O
            Physics2D.gravity = new Vector2(0, -4.6f);

            //�վ�ɶ�
            Time.timeScale = 3f;

            /*
             * �ϥ��R�A��k
             */

            //���o�H���d�� float
            float range = Random.Range(-10.0f, 15.2f);
            print("�H���d��G"+range);
            #endregion

            #region �m��

            // �p��Ҧ���v���ƶq
            print("�ثe��v���G" + Camera.allCamerasCount + "�x");

            //��ܹC�����x
            print("�ثe�C�����x�G" + Application.platform);

            //3D���z�ίv�{�ɭȳ]�w��10
            Physics.sleepThreshold = 10;
            print("���z�ίv�{�ɭȡG" + Physics.sleepThreshold);

            //�ɶ��j�p�]�w��0.5(�C�ʧ@)
            Time.timeScale = 0.5f;
            print("�ɶ��t�סG" + Time.timeScale);

            //��9.999�h�p���I
            print("��9.999�|�ˤ��J�G" + Mathf.Round(9.999f));

            //���o���I���Z��
            float distance = Vector3.Distance(a,b);
            print("ab�I�����Z���G" + distance);

            //�}�ҳs��
            Application.OpenURL("https://unity.com/");

            #endregion
        }

        private void Update()
        {
            #region �ǲ�
            /*
             * �ϥ��R�A��k
            */

            //���o�H���d�� int
            int rangeInt = Random.Range(1, 3);
            print("�H���d��1-3�G" + rangeInt);
            #endregion

            #region �m��
            //�O�_��J���N��
            //print("�O�_��J���N��G" + Input.anyKeyDown);

            //�C���g�L�ɶ�
            //print("�C���g�L�ɶ��G" + Time.timeSinceLevelLoad);

            //�O�_���U�ť���
            print("�O�_���U�ť���G" + Input.GetKeyDown(KeyCode.Space));

            #endregion
        }
    }
}

