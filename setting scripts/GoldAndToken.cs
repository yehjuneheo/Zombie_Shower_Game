using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoldAndToken : MonoBehaviour
{
    int goldAmount;

    int tokenAmount;

    public TextMeshProUGUI goldAmountText;

    public TextMeshProUGUI tokenAmountText;

    // Start is called before the first frame update
    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");
    }

    // Update is called once per frame
    void Update()
    {
        goldAmountText.text = goldAmount.ToString();
        tokenAmountText.text = tokenAmount.ToString();
    }
}
