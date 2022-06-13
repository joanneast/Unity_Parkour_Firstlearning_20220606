using UnityEngine;

namespace Parkour
{
    /// <summary>
    /// (�m�ߥ�) API �R�A���ϥΤ覡
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
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
            int camcount = Camera.allCamerasCount;
            print("�ثe��v���G" + camcount + "�x");

            //��ܹC�����x
            

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

            #endregion
        }
    }
}

