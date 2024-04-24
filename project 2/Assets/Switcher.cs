using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Eexpressions
{
    buff,
    jeans,
    emo
}
public class Switcher : MonoBehaviour
{
    // Start is called before the first frame update

    public Eexpressions eexpressions;
    public GameObject[] images;

    void Start()
    {
        switch(eexpressions)
        {
            case Eexpressions.buff:
                images[0].SetActive(true);
                break;              
            case Eexpressions.jeans:
                images[1].SetActive(true);
                break;
            case Eexpressions.emo:
                images[2].SetActive(true);  
                break;
            default:
                break;        

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
