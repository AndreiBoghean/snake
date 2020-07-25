using System.Globalization;
using TMPro;
using UnityEngine;

using Color = UnityEngine.Color;
public class CustomizationScript : MonoBehaviour
{
    public TMP_InputField SnakeHeadInput;
    public Material SnakeHeadMat;
    public Color SnakeHeadDefault;
    
    public TMP_InputField SnakeBodyInput;
    public Material SnakeBodyMat;
    public Color SnakeBodyDefault;

    public TMP_InputField BorderInput;
    public Material BorderMat;
    public Color BorderDefault;

    public TMP_InputField BackgroundInput;
    public Material BackgroundMat;
    public Color BackgroundDefault;
    public Camera BackgroundCamera;

#region  snake head
    public void UpdateSnakeHead()
    {
        UpdateMat(SnakeHeadInput.text, SnakeHeadMat);
    }

    public void DefaultSnakeHead()
    {
        UpdateMat(SnakeHeadDefault, SnakeHeadMat);
    }
#endregion
#region  snake body
    public void UpdateSnakeBody()
    {
        UpdateMat(SnakeBodyInput.text, SnakeBodyMat);
    }

    public void DefaultSnakeBody()
    {
        UpdateMat(SnakeBodyDefault, SnakeBodyMat);
    }
#endregion
#region  border
    public void UpdateBorder()
    {
        UpdateMat(BorderInput.text, BorderMat);
    }

    public void DefaultBorder()
    {
        UpdateMat(BorderDefault, BorderMat);
    }
#endregion
#region  background
    public void UpdateBackground()
    {
        BackgroundCamera.backgroundColor = GetColFromHex(BackgroundInput.text);
    }

    public void DefaultBackground()
    {
        BackgroundCamera.backgroundColor = BackgroundDefault;
    }
    #endregion

    private void UpdateMat(dynamic col, Material Mat)
    {
        if (col is string)
        { Mat.color = GetColFromHex(col); }
        else if (col is Color)
        { Mat.color = col; }
    }

    public static Color GetColFromHex(string Hex)
    {
        Hex.Replace("#", "");
        int r, g, b;

        r = int.Parse(Hex.Substring(0, 2), NumberStyles.AllowHexSpecifier);
        g = int.Parse(Hex.Substring(2, 2), NumberStyles.AllowHexSpecifier);
        b = int.Parse(Hex.Substring(4, 2), NumberStyles.AllowHexSpecifier);

       return new Color(r, g, b);
    }
}