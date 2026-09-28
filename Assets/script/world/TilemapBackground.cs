using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapBackground : MonoBehaviour
{
  
    public AutoTile tile;
    public Tilemap tilemap;
    public Grid grid;
    void Start()
    {
        grid = new GameObject("Grid").AddComponent<Grid>();

        tilemap = new GameObject("Background").AddComponent<Tilemap>();
        tilemap.transform.SetParent(grid.transform);
       

        TilemapRenderer renderer = tilemap.AddComponent<TilemapRenderer>();

        grid.transform.localScale = new Vector3(0.2f, 0.2f, 1);

        PopulateBackground();


    }
    void PopulateBackground()
    {
        Vector3Int WorldSize = new Vector3Int(150, 150, 0);

        for (int x = -150; x < WorldSize.x; x++)
        {
            for (int y = -150; y < WorldSize.y; y++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), tile);

            }
        }

    }
}
