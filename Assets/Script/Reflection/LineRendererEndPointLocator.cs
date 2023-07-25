using UnityEngine;

public class LineRendererEndPointLocator : MonoBehaviour
{
    LineRenderer lr;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    public float zPos = 2;
    void Update()
    {        
        RayHitter();
        lr.SetPosition(1,new Vector3(0,0,zPos));
    }

    RaycastHit RayHitter()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.yellow);
            Debug.Log(hitInfo.collider.name);
            zPos = hitInfo.distance;
            return hitInfo;
        }
        else
        {
            zPos = 2;
            return hitInfo;
        }
    }
}
