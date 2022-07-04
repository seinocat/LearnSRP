using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipeline : RenderPipeline
{
    private CameraRender renderer = new CameraRender();
    
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        foreach (var camera in cameras)
        {
            renderer.Render(context, camera);
        }
    }

    public CustomRenderPipeline()
    {
        GraphicsSettings.useScriptableRenderPipelineBatching = true;
    }
}
