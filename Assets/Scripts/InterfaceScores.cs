using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceScores : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;
    public Text textHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textHP.text = "HP: " + GameManager.hp;
        textThrown.text = "Number of Stones: " + GameManager.totalStones;
        textDestroyed.text = "Destroyed: " + GameManager.totalStonesDestroyed;
    }
}
