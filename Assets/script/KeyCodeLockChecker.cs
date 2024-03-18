using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class KeyCodeLockChecker : MonoBehaviour
{
    public GameObject KeyCodeChecker;
    public InputField inputField;
    public Button[] KeyCodeItems;
    public Button PasswordDevice; // 密碼輸入器紐
    public Button doornob; // 門把
    public string KeyCodeKey; // 正確密碼
    private int attemps = 3; // 容錯次數 

    public Sound sound;
    void Start()
    {
        doornob.interactable = false;
    }
    //按鈕Enter、Back、0~9
    public void EnterKeyCode()
    {
        if (inputField.text == KeyCodeKey)
        {
            //KeyCodeChecker.SetActive(false);
            Debug.Log("成功解鎖");
            PasswordDevice.interactable = false; // 輸入正確密碼後將不再被觸發
            AudioManager.Instance.PlaySFX("door");
            doornob.interactable = true;
            //SceneManager.LoadScene("GameScene2");
        }
        else
        {
            Debug.Log("密碼錯誤");
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
