using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {
    
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(40);        
        Application.LoadLevel ("SampleScene");  }
   
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel("SampleScene"); }}
