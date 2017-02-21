using UnityEngine.UI;

public class NonDrawingGraphic : Graphic
{
    private NonDrawingGraphic() { useLegacyMeshGeneration = false; }

    public override void SetMaterialDirty() { }

    public override void SetVerticesDirty() { }

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();
    }
}
