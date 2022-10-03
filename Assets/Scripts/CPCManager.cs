using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPCManager : MonoBehaviour
{
    [SerializeField]
    private int CPC;
    public CPCManager instance;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

   public void AddCPC(int amountCPC){
        CPC+= amountCPC;
    }

    public void ButtonClick() {
        Debug.Log("clicked");
        GameManager.instance.AddCoins(CPC);
    }



}
