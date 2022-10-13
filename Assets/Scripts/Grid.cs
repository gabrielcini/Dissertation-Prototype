using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

	public bool onlyDisplayPathGizmos;
	public LayerMask unwalkableMask;
	public Vector2 gridWorldSize;
	public float nodeRadius;
	Node[,] grid;

	float nodeDiameter;
	int gridSizeX, gridSizeY;

	public Material mat;

	private Material lineMaterial;

	private Color mainColor = new Color(0, 0, 0, 1);
	private Color subColor = new Color(0, 1, 0, 1);
	private Color detectColor = new Color(1, 0, 0, 1);


	void Start() {
		//nodeDiameter = nodeRadius*2;
    nodeDiameter = nodeRadius*0.6f;
		gridSizeX = Mathf.RoundToInt(gridWorldSize.x/nodeDiameter);
		gridSizeY = Mathf.RoundToInt(gridWorldSize.y/nodeDiameter);
		CreateGrid();

	}



	public int MaxSize {
		get {
			return gridSizeX * gridSizeY;
		}
	}

	void CreateGrid() {
		grid = new Node[gridSizeX,gridSizeY];
		Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x/2 - Vector3.forward * gridWorldSize.y/2;

		for (int x = 0; x < gridSizeX; x ++) {
			for (int y = 0; y < gridSizeY; y ++) {
				Vector3 worldPoint = worldBottomLeft + Vector3.right * (x * nodeDiameter + nodeRadius) + Vector3.forward * (y * nodeDiameter + nodeRadius);
				bool walkable = !(Physics.CheckSphere(worldPoint,nodeRadius,unwalkableMask));
				grid[x,y] = new Node(walkable,worldPoint, x,y);
			}
		}
	}

	public List<Node> GetNeighbours(Node node) {
		List<Node> neighbours = new List<Node>();

		for (int x = -1; x <= 1; x++) {
			for (int y = -1; y <= 1; y++) {
				if (x == 0 && y == 0)
					continue;

				int checkX = node.gridX + x;
				int checkY = node.gridY + y;

				if (checkX >= 0 && checkX < gridSizeX && checkY >= 0 && checkY < gridSizeY) {
					neighbours.Add(grid[checkX,checkY]);
				}
			}
		}

		return neighbours;
	}


	public Node NodeFromWorldPoint(Vector3 worldPosition) {
		float percentX = (worldPosition.x + gridWorldSize.x/2) / gridWorldSize.x;
		float percentY = (worldPosition.z + gridWorldSize.y/2) / gridWorldSize.y;
		percentX = Mathf.Clamp01(percentX);
		percentY = Mathf.Clamp01(percentY);

		int x = Mathf.RoundToInt((gridSizeX-1) * percentX);
		int y = Mathf.RoundToInt((gridSizeY-1) * percentY);
		return grid[x,y];
	}

	public List<Node> path;

	void Update(){

		if (onlyDisplayPathGizmos) {
			if (path != null) {
				foreach (Node n in path) {
					//Gizmos.color = new Color(0, 0, 0, 0);
					//Gizmos.DrawCube(n.worldPosition, Vector3.one * (nodeDiameter-.1f));
          //Gizmos.DrawCube(n.worldPosition, new Vector3(0.5f, 0, 0.5f));

					GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

					cube.transform.localScale = new Vector3 (0.5f, 0.07f, 0.5f);

					Destroy(cube.GetComponent<Collider>());
        	cube.transform.position = n.worldPosition;
					Destroy(cube, 0.07f);

					Vector3[] positions = new Vector3[2] { n.worldPosition, new Vector3(0.5f, 0, 0.5f)};

				}
			}
		}
	}


	/*void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position,new Vector3(gridWorldSize.x,1,gridWorldSize.y));



		else {

			if (grid != null) {
				foreach (Node n in grid) {
					Gizmos.color = (n.walkable)?Color.white:Color.red;
					if (path != null)
						if (path.Contains(n))
							Gizmos.color = Color.red;
					//Gizmos.DrawCube(n.worldPosition, Vector3.one * (nodeDiameter-.1f));
          Gizmos.DrawCube(n.worldPosition, new Vector3(0.5f, 0, 0.5f));
					//DrawLine(n.worldPosition, new Vector3(4.5f, 4, 4.5f), Color.red);

					Vector3[] positions = new Vector3[2] { n.worldPosition, new Vector3(0.5f, 0, 0.5f)};

				}
			}
		}
	}*/

}
