using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public class InvisibleWallUnderBlackBackGround : MonoBehaviour
{
    public Image ChangeColor;
    public TilemapCollider2D collider;
    public TilemapRenderer tilemapRenderer;

    void Start()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
    }

    void Update()
    {
        Material tilemapMaterial = tilemapRenderer.material;
        if (ChangeColor.enabled == true && ChangeColor.enabled != false) {
            collider.enabled = true;
            tilemapMaterial.SetColor("_Color", Color.white);
        } else {
            collider.enabled = false;
            tilemapMaterial.SetColor("_Color", Color.black);
        }
    }
}
