using UnityEngine;
using System.Collections;

public class Loadh : MonoBehaviour {
    
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(20);        
        Application.LoadLevel ("LevelThree");  }
   
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel("LevelThree"); }}
