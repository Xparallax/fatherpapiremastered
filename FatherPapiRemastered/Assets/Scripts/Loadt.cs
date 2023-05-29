using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loadt : MonoBehaviour
{
    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(18);
        SceneManager.LoadScene("LevelTwo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("LevelTwo");
    }
}
