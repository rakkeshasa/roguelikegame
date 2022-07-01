using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCounter : MonoBehaviour
{
    public static int score;

    private Text text;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Score: " + score;
    }

}
