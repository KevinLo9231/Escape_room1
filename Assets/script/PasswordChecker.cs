using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PasswordChecker : MonoBehaviour
{
    public InputField passwordInputField;//密碼輸入的窗框
    public string correctPassword ; 
    public GameObject panelChecker;
    public Button door;
    private int attemps = 3;//密碼容錯次數
    
    public Button PasswordDevice; // 密碼輸入器

    public void CheckPassword() // 判斷密碼是否正確
    {

        if (passwordInputField.text == correctPassword)
        {
            panelChecker.SetActive(false);// 輸入的面板關閉
            Debug.Log("Correct");
            PasswordDevice.interactable = false; // 輸入正確密碼後將不再被觸發
            door.interactable = true; // 解鎖出口
        }
        else
        {
            passwordInputField.text = "";
            Debug.Log("Wrong");
            attemps--;
            if( attemps == 0)
            {
                LockAccount();
            }
        }
    }

    public void Close()
    {
        panelChecker.SetActive(false); 
    }

    public void On()
    {
        panelChecker.SetActive(true);
    }

    public void LockAccount() // 密碼被上鎖的壞結局
    {
        SceneManager.LoadScene("BadEnding");
    }

}
