 using UnityEngine;
 using System.Collections;
 
 public class SimpleTimer: MonoBehaviour {
 
 public float targetTime = 1.0f;
 
 void Update(){
 
 targetTime -= Time.deltaTime;
 
 if (targetTime <= 0)
 {
    timerEnded();
 }
 
 }
 
 void timerEnded()
 {
    Debug.Log("1 second passed");
 }
 
 
 }