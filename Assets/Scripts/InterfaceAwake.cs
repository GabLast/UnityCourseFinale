using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour
{
    public GameObject playBTN;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.ResetGame();
    }

    public void Click()
    {
        SceneManager.LoadScene("StoneGame");
    }
}
