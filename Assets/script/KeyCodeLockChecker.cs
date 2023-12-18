using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;



public class KeyCodeLockChecker : MonoBehaviour
{
    public GameObject KeyCodeChecker;
    public InputField inputField;
    public Button[] KeyCodeItems;
    public Button PasswordDevice; // 密碼輸入器紐
    public string KeyCodeKey; // 正確密碼
    private int attemps = 3; // 容錯次數 

    
    public void EnterKeyCode()
    {
        if (inputField.text == KeyCodeKey)
        {
            KeyCodeChecker.SetActive(false);
            Debug.Log("成功解鎖");
            PasswordDevice.interactable = false; // 輸入正確密碼後將不再被觸發
            SceneManager.LoadScene("HappyEnding");
        }
        else
        {
            Debug.Log("密碼錯誤");
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
