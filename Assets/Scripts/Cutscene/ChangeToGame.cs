using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Game());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Game()
    {
        yield return new WaitForSeconds(5.875f);
        SceneManager.LoadScene("NoelMain");
    }
}
