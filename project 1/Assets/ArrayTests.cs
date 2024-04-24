using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTests : MonoBehaviour
{
    // Start is called before the first frame update
    public string name_1;
    public string name_2;
    public string name_3;
    public string name_4;
    public string name_5;

    public string[] names;

    public GameObject cube;

    public int index;
    public float x;
    public float y;
    public float z;

    public bool isDead;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The Character name is : " + names[index]);
        cube.transform.position = new Vector3(x, y, z);
        cube.transform.localScale = new Vector3(x, y, z);

       

        //if(x > 5 || y > 5 || z > 5)
        //{
        //        Destroy(cube,2.5f);
        //    }
        //}
    }
}
