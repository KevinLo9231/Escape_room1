using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;



public class KeyCodeLockChecker : MonoBehaviour
{
    public GameObject KeyCodeChecker;
    public InputField inputField;
    public Button[] KeyCodeItems;
    public Button PasswordDevice; // �K�X��J����
    public string KeyCodeKey; // ���T�K�X
    private int attemps = 3; // �e������ 

    
    public void EnterKeyCode()
    {
        if (inputField.text == KeyCodeKey)
        {
            KeyCodeChecker.SetActive(false);
            Debug.Log("���\����");
            PasswordDevice.interactable = false; // ��J���T�K�X��N���A�QĲ�o
            SceneManager.LoadScene("HappyEnding");
        }
        else
        {
            Debug.Log("�K�X���~");
            inputField.text = null;
            attemps--;
            if ( attemps == 0)
            {
                SceneManager.LoadScene("BadEnding");
            }
        }
    }

    public void PressNumButton_0()
    {
        inputField.text += 0;
    }
    public void PressNumButton_1()
    {
        inputField.text += 1;
    }
    public void PressNumButton_2()
    {
        inputField.text += 2;
    }
    public void PressNumButton_3()
    {
        inputField.text += 3;
    }
    public void PressNumButton_4()
    {
        inputField.text += 4;
    }
    public void PressNumButton_5()
    {
        inputField.text += 5;
    }
    public void PressNumButton_6()
    {
        inputField.text += 6;
    }
    public void PressNumButton_7()
    {
        inputField.text += 7;
    }
    public void PressNumButton_8()
    {
        inputField.text += 8;
    }
    public void PressNumButton_9()
    {
        inputField.text += 9;
    }
    public void BackSpaceButton()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }
}
