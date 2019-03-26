using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 5;

    public TextMeshPro text;

    public GameObject fighterPrefab;

    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;

        Resources();

    }

    void Resources()
    {
        if(tiberium <= 10)
        {
            coroutine = AccumulateTiberium();
            StartCoroutine(coroutine);
            //StopCoroutine(coroutine);
           
        }
         else if(tiberium >= 10)
        {
            StopCoroutine(coroutine);
            Spawn();  
        }
        
    }


    private void Spawn()
    {
        Instantiate(fighterPrefab, this.transform.position, Quaternion.identity);

        tiberium -= 10;
    }

 
    IEnumerator AccumulateTiberium()
    {
        yield return new WaitForSeconds(1.0f);
        tiberium = tiberium + (1 * Time.deltaTime);
        StartCoroutine(coroutine);

    }
}
