using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timerDuration = 40f;
    public string nextSceneName;

    private void Start()
    {
        // Start the coroutine for the timer
        StartCoroutine(StartTimer());
    }

    private System.Collections.IEnumerator StartTimer()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(timerDuration);

        // Load the next scene
        SceneManager.LoadScene("LevelThree");
    }
}
