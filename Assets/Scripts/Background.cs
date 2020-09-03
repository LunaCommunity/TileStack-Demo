using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private MeshFilter meshFilter = null;
    [SerializeField] private MeshRenderer meshRenderer = null;
    [SerializeField] private Material material = null;

    [SerializeField]
    private Color topColor = Color.black;

    [SerializeField]
    private Color bottomColor = Color.grey;

    private void Awake()
    {
        var mat = new Material(material);
        var mesh = new Mesh
        {
            vertices = new[]
            {
                new Vector3(-20, 8, 0),
                new Vector3(20, 8, 0),
                new Vector3(-20, -8, 0),
                new Vector3(20, -8, 0)
            },
            colors = new[] { topColor, topColor, bottomColor, bottomColor },
            triangles = new[] { 0, 1, 2, 1, 3, 2 }
        };

        meshFilter.mesh = mesh;
        meshRenderer.material = mat;
    }
}
