using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // [SerializeField] string current_scene_name;
    [SerializeField] string next_scene_name;

    public void OnClick()
    {
        SceneManager.LoadScene(next_scene_name);
    }
}
