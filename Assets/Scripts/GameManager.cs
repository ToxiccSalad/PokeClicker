using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake() {
        instance = this;
    }
    public GameData gameData;
    public TMP_Text mText;
    // Start is called before the first frame update
    void Start()
    {
        gameData = new GameData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int amountcoins) {
        gameData.coins = gameData.coins + amountcoins;
        mText.text = gameData.coins +" Coins";
    }
    public void RemoveCoins(int amountcoins) {
        gameData.coins = gameData.coins - amountcoins;
        mText.text = gameData.coins +" Coins";
    }
    public int GetCoins(){
        return gameData.coins;
    }
}
