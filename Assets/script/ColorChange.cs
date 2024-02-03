using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    private Button button;
    private bool isColor1 = true;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeColor);
        button.image.color = new Color(0, 1, 0);  // 設定成紅色
    }

    void ChangeColor()
    {
        if (isColor1)
        {
            button.image.color = new Color(1f, 0f, 0f);  // 改變成紅色
        }
        else
        {
            button.image.color = new Color(0, 1, 0);  // 改變成綠色
        }

        isColor1 = !isColor1;
    }
}
