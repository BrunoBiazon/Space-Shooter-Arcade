using UnityEngine;

public static class CameraUtils
{
    public static float GetLargura()
    {
        return Camera.main.orthographicSize * Camera.main.aspect;
    }

    public static float GetAltura()
    {
        return Camera.main.orthographicSize;
    }
}