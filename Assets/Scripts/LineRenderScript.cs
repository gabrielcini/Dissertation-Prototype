using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderScript : MonoBehaviour
{
  private LineRenderer lineRenderer;

  void Start()
  {
      lineRenderer = GetComponent<LineRenderer>();
  }

  void DrawLine(Vector3[] vertexPositions, float startWidth, float endWidth)
  {
      lineRenderer.startWidth = startWidth;
      lineRenderer.endWidth = endWidth;
      lineRenderer.loop = true;
      lineRenderer.positionCount = 2;
      lineRenderer.numCornerVertices = 5;
      lineRenderer.SetPositions(vertexPositions);
  }

  void Update(){
    Vector3[] positions = new Vector3[2] { new Vector3(0, 0.4f, 0), new Vector3(-9.43f, 0.4f, 11.76f)};
    DrawLine(positions, 0.12f, 0.12f);
  }
}
