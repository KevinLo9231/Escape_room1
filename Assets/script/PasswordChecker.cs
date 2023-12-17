using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PasswordChecker : MonoBehaviour
{
    public InputField passwordInputField;//�K�X��J������
    public string correctPassword ; 
    public GameObject panelChecker;
    public Button door;
    private int attemps = 3;//�K�X�e������
    
    public Button PasswordDevice; // �K�X��J��

    public void CheckPassword() // �P�_�K�X�O�_���T
    {

        if (passwordInputField.text == correctPassword)
        {
            panelChecker.SetActive(false);// ��J�����O����
            Debug.Log("Correct");
            PasswordDevice.interactable = false; // ��J���T�K�X��N���A�QĲ�o
            door.interactable = true; // ����X�f
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

    public void LockAccount() // �K�X�Q�W�ꪺ�a����
    {
        SceneManager.LoadScene("BadEnding");
    }

}
