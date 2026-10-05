using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapBackground : MonoBehaviour
{
  
    public AutoTile tile;
    public Tilemap background;
    public Tilemap fence;
    public Grid grid;
    void Start()
    {
        grid = new GameObject("Grid").AddComponent<Grid>();

        background = new GameObject("Background").AddComponent<Tilemap>();
        fence = new GameObject("Fence").AddComponent<Tilemap>();
        background.transform.SetParent(grid.transform);
        fence.transform.SetParent(grid.transform);

        TilemapRenderer renderer = background.AddComponent<TilemapRenderer>();


        PopulateBackground();


    }
    void PopulateBackground()
    {
        Vector3Int WorldSize = new Vector3Int(150, 150, 0);

        for (int x = -150; x < WorldSize.x; x++)
        {
            for (int y = -150; y < WorldSize.y; y++)
            {
                background.SetTile(new Vector3Int(x, y, 0), tile);

            }
        }

    }
}
