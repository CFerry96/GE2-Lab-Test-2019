using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive: SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    
    public GameObject[] TargetBases;
    public GameObject Base1, Base2, Base3, Base4;
    //private GameObject TargetBase;
    
        
    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        int rnd = UnityEngine.Random.Range(0, 4);

        /*TargetBases = new GameObject[4];
        int rnd = UnityEngine.Random.Range(0, 4);
        Debug.Log(rnd);
        targetPosition = TargetBases[rnd].transform.position;
        //Debug.Log(TargetBases[rnd]);*/

        if (rnd == 0)
        {
            targetPosition = Base1.transform.position;
        }
        else if(rnd == 1)
        {
            targetPosition = Base2.transform.position;
        }
        else if (rnd == 2)
        {
            targetPosition = Base3.transform.position;
        }
        else if (rnd == 3)
        {
            targetPosition = Base4.transform.position;
        }
    }


}



/*
 *  public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;
        
    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = targetGameObject.transform.position;
        }
    }
*/