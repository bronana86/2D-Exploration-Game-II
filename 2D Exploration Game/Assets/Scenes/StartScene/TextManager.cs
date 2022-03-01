using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    [SerializeField]
    GameObject text;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            text.SetActive(true);
            //SceneManager.UnloadSceneAsync(1);
        }
    }
}
