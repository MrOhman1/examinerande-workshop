using UnityEngine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SwaptoMenu : MonoBehaviour
{
    public UnityEvent onstart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onstart.Invoke();
        SceneManager.LoadScene(sceneName: "Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
