using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockChecker : MonoBehaviour
{
    public Button[] buttons;
    public bool[] isRed;
    private int attempts = 3; // 新增嘗試次數變數

    void Start()
    {

        // 初始化按鈕狀態數組
        isRed = new bool[buttons.Length];

        // 為每個按鈕新增點擊事件監聽器
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // 將索引儲存到局部變數中，以便在委託中使用
            buttons[i].onClick.AddListener(() => ChangeColor(index));
            buttons[i].image.color = new Color(1, 0, 0, 1);  // 將按鈕顏色設定成紅色
            isRed[i] = true; // 初始狀態為紅色
        }
    }

    private void ChangeColor(int buttonIndex)
    {
        if (isRed[buttonIndex])
        {
            buttons[buttonIndex].image.color = new Color(0, 1, 0, 1);  // 改變成綠色
            AudioManager.Instance.PlaySFX("click");
        }
        else
        {
            buttons[buttonIndex].image.color = new Color(1, 0, 0, 1);  // 改變成紅色
            AudioManager.Instance.PlaySFX("click");
        }

        isRed[buttonIndex] = !isRed[buttonIndex];
    }

    public void EnterKeyCode()
    {
        if ((isRed[1] == false) && (isRed[2] == false) && (isRed[3] == false) && (isRed[4] == false) && (isRed[6] == false) && (isRed[7] == false) && isRed[0] && isRed[5] && isRed[8])
        {
            Debug.Log("成功解锁");
            SceneManager.LoadScene("HappyEnding");
        }
        else
        {
            Debug.Log("密码错误");

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].image.color = new Color(1, 0, 0, 1);  // 設定成紅色
                isRed[i] = true; // 初始狀態為紅色
            }
                attempts--;
            if (attempts == 0)
            {
                SceneManager.LoadScene("BadEnding");
            }
        }
    }
}
