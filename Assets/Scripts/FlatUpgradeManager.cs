using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlatUpgradeManager : MonoBehaviour
{
   [SerializeField]
    private int cost;
   [SerializeField]
    private int CPCIncrease;
   public TMP_Text CostText;
   public GameManager gamemanager;
   public CPCManager CPCManager;
   public Button UpgradeButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.GetCoins()>=cost){
        UpgradeButton.interactable = true;
    }else{
       UpgradeButton.interactable = false;
    }
        
    }
    public void ButtonClick() {
        Debug.Log("clicked");
       gamemanager.RemoveCoins(cost);
       CPCManager.AddCPC(CPCIncrease);
       SetNewCost();
       CostText.text=cost.ToString();
    }
    private void SetNewCost(){
        cost=(int)System.Math.Round(cost*1.1);
        
    }
}
