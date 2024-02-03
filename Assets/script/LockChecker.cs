using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockChecker : MonoBehaviour
{
    public Button[] buttons;
    public bool[] isRed;
    private int attempts = 3; // 添加尝试次数变量

    void Start()
    {
        // 获取所有按钮
        //buttons = GetComponentsInChildren<Button>();

        // 初始化按钮状态数组
        isRed = new bool[buttons.Length];

        // 为每个按钮添加点击事件监听器
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // 将索引保存到局部变量中，以便在委托中使用
            buttons[i].onClick.AddListener(() => ChangeColor(index));
            buttons[i].image.color = new Color(1, 0, 0);  // 设置成紅色
            isRed[i] = false; // 初始状态为绿色
        }
    }

    private void ChangeColor(int buttonIndex)
    {
        if (isRed[buttonIndex])
        {
            buttons[buttonIndex].image.color = new Color(1, 0, 0);  // 改变成红色
        }
        else
        {
            buttons[buttonIndex].image.color = new Color(0, 1, 0);  // 改变成绿色
        }

        isRed[buttonIndex] = !isRed[buttonIndex];
    }

    public void EnterKeyCode()
    {
        if (isRed[1] && isRed[2] && isRed[3] && isRed[4] && isRed[6] && isRed[7] && (isRed[0] == false) && (isRed[5] == false) && (isRed[8] == false))
        {
            Debug.Log("成功解锁");
        }
        else
        {
            Debug.Log("密码错误");

            attempts--;
            if (attempts == 0)
            {
                SceneManager.LoadScene("BadEnding");
            }
        }
    }
}
