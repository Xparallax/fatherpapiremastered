using UnityEngine;
using UnityEngine.SceneManagement;

public class testscript : MonoBehaviour
{
    public string nextSceneName;

    private void OnDestroy()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
