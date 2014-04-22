using UnityEngine;
using System.Collections;

public class Trigon : MonoBehaviour 
{
    public Transform Left;
    public Transform Right;
    public Transform Up;
    public static Trigon  aa;

    void Start()
    {
        aa = this;
        SetProperty();
    }
     public   void   SetProperty() 
    {
        MeshFilter meshFilter = (MeshFilter)GameObject.Find("trigon").GetComponent(typeof(MeshFilter));
        Mesh mesh = meshFilter.mesh;
        Vector3[] vertices = new Vector3[3];
        int[] triangles = new int[3];
        vertices[0] = Left.localPosition;
        vertices[1] =Right.localPosition;
        vertices[2] = Up.localPosition;

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        
        mesh.vertices = vertices;
        mesh.triangles = triangles;
	}
    void Update()
    {
        SetProperty();
    }
}
