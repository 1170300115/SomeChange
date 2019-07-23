using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    [System.Obsolete]
    public void OnQuitClicked()
    {
        GameObject gameObject1 = GameObject.FindGameObjectWithTag("Window");

        Destroy(gameObject);
        Time.timeScale = 1;
        Application.LoadLevel("LevelSence");
    }

    public void OnRunCliced()
    {
        GameObject gameObject1 = GameObject.FindGameObjectWithTag("Window");

        Destroy(gameObject);
        Time.timeScale = 1;
    }
}
