using UnityEngine;
using UnityEngine.SceneManagement;  //�ޥγ����޲zapi
using TMPro;    //�ޥηs��text��Ʈw

/// <summary>
/// �޲z�����e��
/// �L���P����
/// </summary>
namespace Parkour 
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textfinal;

        public string finaltitle;


        private void Start()
        {
            textfinal.text = finaltitle;

            //MonoBehaviour���Oapi�i�H�����ΦW�٩I�s
            InvokeRepeating("FadeIn", 0.2f, 0.1f);
        }

        //���������y�H�J�ĪG
        private void FadeIn()
        {
            groupfinal.alpha += 0.1f;

            print("�H�J�H�J�H�J");

            if (groupfinal.alpha >= 1)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }

        /*���s�P�{�����q�覡
         * 1 �w�q���}��k
         * 2 button on click �]�w���}�������}��k
         */
        public void Quit()
        {
            print("���}�C��");

            //�u�b�o�������ɫ� �׺ݾ��W����
            Application.Quit();
        }

        public void Restart()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}


