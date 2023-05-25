using UnityEngine;
using System.Collections;

public class Loadt : MonoBehaviour {
    
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(20);        
        Application.LoadLevel ("LevelTwo");  }
   
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel("LevelTwo"); }}
