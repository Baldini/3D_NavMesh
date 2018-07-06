using UnityEngine;
using UnityEngine.AI;

public class MazeGenerator : MonoBehaviour {

	public int width = 10;
	public int height = 10;
	public NavMeshSurface surface;

	public GameObject wall;
	public GameObject player;

	private bool playerSpawned = false;

	void Start () {
		GenerateLevel ();
		surface.BuildNavMesh ();
	}

	void GenerateLevel () {
		for (int x = 0; x <= width; x += 2) {
			for (int y = 0; y <= height; y += 2) {
				if (Random.value >.7f) {
					Vector3 pos = new Vector3 (x - width / 2f, 0f, y - height / 2f);
					Instantiate (wall, pos, Quaternion.identity, transform);
				} else if (!playerSpawned) {
					Vector3 pos = new Vector3 (x - width / 2f, 1.25f, y - height / 2f);
					Instantiate (player, pos, Quaternion.identity);
					playerSpawned = true;
				}
			}
		}
	}

}