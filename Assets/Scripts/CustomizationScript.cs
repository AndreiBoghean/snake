using System.Collections;
using System.Collections.Generic;
using System.Windows.Media;
using TMPro;
using UnityEngine;
using Color = System.Windows.Media.Color;

public class CustomizationScript : MonoBehaviour
{
    public TMP_InputField SnakeHeadInput;
    public Material SnakeHeadMat;
    public string SnakeHeadDefault;
    
    public TMP_InputField SnakeBodyInput;
    public Material SnakeBodyMat;
    public string SnakeBodyDefault;

    public TMP_InputField BorderInput;
    public Material BorderMat;
    public string BorderDefault;

    public TMP_InputField BackgroundInput;
    public Material BackgroundMat;
    public string BackgroundDefault;

#region  snake head
    public void UpdateSnakeHead()
    {
        Update(SnakeHeadInput.text, SnakeHeadMat);
    }

    public void DefaultSnakeHead()
    {
        Update(SnakeHeadDefault, SnakeHeadMat);
    }
#endregion
#region  snake body
    public void UpdateSnakeBody()
    {
        Update(SnakeBodyInput.text, SnakeBodyMat);
    }

    public void DefaultSnakeBody()
    {
        Update(SnakeBodyDefault, SnakeBodyMat);
    }
#endregion
#region  border
    public void UpdateBorder()
    {
        Update(BorderInput.text, BorderMat);
    }

    public void DefaultBorder()
    {
        Update(BorderDefault, SnakeBodyMat);
    }
#endregion
#region  background
    public void UpdateBackground()
    {
        Update(BackgroundInput.text, SnakeBodyMat);
    }

    public void DefaultBackground()
    {
        Update(BackgroundDefault, SnakeBodyMat);
    }
    #endregion

    private void Update(string Hex, Material Mat)
    {
        Color temp = (Color)ColorConverter.ConvertFromString(Hex);
        Mat.color = new UnityEngine.Color(temp.R, temp.G, temp.B, temp.A);
    }
}