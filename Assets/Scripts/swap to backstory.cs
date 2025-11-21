using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class swaptobackstory : MonoBehaviour
{
    public UnityEvent onstart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onstart.Invoke();
        SceneManager.LoadScene(sceneName: "Backstory");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
