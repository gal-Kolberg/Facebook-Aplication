using System.Drawing;

namespace FacebookApplicationUI
{
    public interface IDanceable
    {
         Point Location { get; set; }

         Color BackColor { get; set; }
    }
}