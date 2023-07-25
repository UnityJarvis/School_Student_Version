using System.Linq;
using UnityEngine;

public class PrismLineRenderer : MonoBehaviour
{
    LineRenderer lr;
    public Transform[] linePointsPositions;
    void Start()
    {
        linePointsPositions = GetComponentsInChildren<Transform>();
        lr = GetComponent<LineRenderer>();
        lr.positionCount = linePointsPositions.Length - 1;
    }
    public Vector3[] pos;
    void LineRendererSetPoints()
    {
        for(int i = 1; i < linePointsPositions.Length; i++)
        {
            lr.SetPosition(i-1, linePointsPositions[i].position);
        }
    }
    void Update()
    {
        LineRendererSetPoints();
    }
}
