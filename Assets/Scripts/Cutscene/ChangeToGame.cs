using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToGame : MonoBehaviour
{
    public GameObject Cutscene1;
    public GameObject Cutscene2;
    public GameObject Cutscene3;
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
        Cutscene1.SetActive(false);
        Cutscene2.SetActive(true);

        yield return new WaitForSeconds(1.750f);
        Cutscene2.SetActive(false);
        Cutscene3.SetActive(true);

        yield return new WaitForSeconds(3.840f);
        SceneManager.LoadScene("NoelMain");
    }
}
