using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    [SerializeField]
    public Transform text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            text.position = new Vector2(500.0f, 500.0f);
            try
            {
                SceneManager.UnloadSceneAsync("Levels");
            }
            catch
            {
            }
            SceneManager.LoadScene("Levels", LoadSceneMode.Additive);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            text.position = new Vector2(500.0f, 500.0f);
            try
            {
                SceneManager.UnloadSceneAsync("Levels");
            }
            catch
            {
            }
            SceneManager.LoadScene("Levels", LoadSceneMode.Additive);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            text.position = new Vector2(3.6f, 2.4f);
            SceneManager.UnloadSceneAsync("Levels");
            SceneManager.LoadScene("StartScreen", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("StartScreen");
        }
    }
}
