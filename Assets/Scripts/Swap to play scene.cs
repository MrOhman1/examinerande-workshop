using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Swaptoplayscene : MonoBehaviour
{
    public UnityEvent onstart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onstart.Invoke();
        SceneManager.LoadScene(sceneName: "SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
