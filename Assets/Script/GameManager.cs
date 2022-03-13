using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool[] is_spanyan;
    [SerializeField] GameObject[] spanyan_imgs;

    private void Start() {
        is_spanyan = new bool[5];
        for (int i = 0; i < is_spanyan.Length; i++)
        {
            is_spanyan[i] = false;
        }
    }

    public void Array_update(int array)
    {
        is_spanyan[array] = true;

        int clear_num=0;
        for (int i = 0; i < is_spanyan.Length; i++)
        {
            if(is_spanyan[i]){
                spanyan_imgs[i].GetComponent<Image>().color=new Color(0,0,0);
                Debug.Log(spanyan_imgs[i].GetComponent<Image>().color);
                clear_num++;
            }
        }
        if(clear_num == is_spanyan.Length)
        {
            Debug.Log("GameClear");
            SceneManager.LoadScene("GameClear");
        }

    }

    


}
