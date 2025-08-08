using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBasicApp.Helpers;

public class WaveDrawable : IDrawable
{
    public static WaveDrawable Instance { get; } = new WaveDrawable();

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = Colors.White;

        var path = new PathF();
        path.MoveTo(0, 0);
        path.LineTo(0, dirtyRect.Height);
        path.QuadTo(dirtyRect.Width / 2, -dirtyRect.Height, dirtyRect.Width, dirtyRect.Height);
        path.LineTo(dirtyRect.Width, 0);
        path.Close();

        canvas.FillPath(path);
    }
}