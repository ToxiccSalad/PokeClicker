using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int coins;
    public TMP_Text mText;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int amountcoins) {
        coins = coins + amountcoins;
        mText.text = coins +" Coins";
    }
    public void RemoveCoins(int amountcoins) {
        coins = coins - amountcoins;
        mText.text = coins +" Coins";
    }
    public int GetCoins(){
        return coins;
    }
}
