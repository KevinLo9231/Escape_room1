using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class KeyCodeLockChecker : MonoBehaviour
{
    public GameObject KeyCodeChecker;
    public InputField inputField;
    public Button[] KeyCodeItems;
    public Button PasswordDevice; // �K�X��J����
    public Button doornob; // ����
    public string KeyCodeKey; // ���T�K�X
    private int attemps = 3; // �e������ 

    public Sound sound;
    void Start()
    {
        doornob.interactable = false;
    }
    //���sEnter�BBack�B0~9
    public void EnterKeyCode()
    {
        if (inputField.text == KeyCodeKey)
        {
            //KeyCodeChecker.SetActive(false);
            Debug.Log("���\����");
            PasswordDevice.interactable = false; // ��J���T�K�X��N���A�QĲ�o
            AudioManager.Instance.PlaySFX("door");
            doornob.interactable = true;
            //SceneManager.LoadScene("GameScene2");
        }
        else
        {
            Debug.Log("�K�X���~");
            inputField.text = null;
            attemps--;
            if ( attemps == 0)
            {
                AudioManager.Instance.PlaySFX("click");
                SceneManager.LoadScene("BadEnding");
                AudioManager.Instance.musicSource.Stop();
            }
        }
    }
    public void PressNumButton_0()
    {
        inputField.text += 0;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_1()
    {
        inputField.text += 1;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_2()
    {
        inputField.text += 2;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_3()
    {
        inputField.text += 3;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_4()
    {
        inputField.text += 4;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_5()
    {
        inputField.text += 5;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_6()
    {
        inputField.text += 6;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_7()
    {
        inputField.text += 7;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_8()
    {
        inputField.text += 8;
        AudioManager.Instance.PlaySFX("click");
    }
    public void PressNumButton_9()
    {
        inputField.text += 9;
        AudioManager.Instance.PlaySFX("click");
    }
    public void BackSpaceButton()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
        AudioManager.Instance.PlaySFX("click");
    }
}
