using System.Linq;
using UnityEngine;

namespace ProjectionManagers {
[RequireComponent(typeof(Camera))]
public class HorizontalProjectionManager : ProjectionManager
{
    #region Field

    [SerializeField]
    private Camera[]        cameras;
    private RenderTexture[] _renderTextures;

    #endregion Field

    private void Start()
    {
        _renderTextures = cameras.Select(camera => camera.targetTexture).ToArray();
    }

    protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        HorizontalProjection(destination, _renderTextures);
    }
}}