using System;
using _02.Graphic_Editor;

    public class Program
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle();
            GraphicEditor myEditor = new GraphicEditor();
            myEditor.DrawShape(rectangle);
        }
    }

