using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenuCall : MonoBehaviour
{
    public GameObject menuSet;
    // Start is called before the first frame update
    void Start()
    {
        menuSet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
            }
            else
            {
                menuSet.SetActive(true);
            }
        }
    }
}
